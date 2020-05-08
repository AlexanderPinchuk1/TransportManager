using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Vehicle;
using CRUD.Serializers;
using CRUD.Attributes;
using CRUD.VehicleForms.GrTransportForms;
using CRUD.VehicleForms.WTransportForms;
using CRUD.Vehicle.GrTransport;
using CRUD.Vehicle.WTransport;
using System.Reflection;

namespace CRUD
{
    public enum Mode
    {
        view,
        edit,
        create,
    }

    public partial class FMenu : Form
    {
        private static readonly List<object> TransportList = new List<object>();
        private readonly List<Type> TransportTypes = new List<Type>();
        private readonly List<Type> SerializersList = new List<Type>();
        private readonly List<Form> FormsList = new List<Form>();

        private string[] LibList;
        public FMenu()
        {
            InitializeComponent();
            listViewInfo.ContextMenuStrip = contextMenuStrip;
            FilltransportTypes();
            FillSerializersList();
            FillFormsList();
            ComboBoxTypeTransport.SelectedIndex = 0;
            ComboBTypeSer.SelectedIndex = 0;
            SetEncryptFiles();
            if (comboBCrypt.Items.Count != 0)
                comboBCrypt.SelectedIndex = 0;
        }
        private void SetEncryptFiles()
        {
            LibList = Directory.GetFiles(Application.StartupPath + "\\Plugins\\");
            foreach (String file in LibList)
                comboBCrypt.Items.Add(Path.GetFileNameWithoutExtension(file));
        }

        private void FillSerializersList()
        {
            SerializersList.Add(typeof(BinarySerializer));
            SerializersList.Add(typeof(JsonSerializer));
            SerializersList.Add(typeof(CustomSerializer));
        }

        private void FillFormsList()
        {
            FormsList.Add(new FAuto());
            FormsList.Add(new FMotorBike());
            FormsList.Add(new FSubmarine());
            FormsList.Add(new FMotorShip());
            FormsList.Add(new FSailboat());
        }

        private void FilltransportTypes()
        {
            TransportTypes.Add(typeof(Auto));
            TransportTypes.Add(typeof(MotorBike));
            TransportTypes.Add(typeof(Submarine));
            TransportTypes.Add(typeof(MotorShip));
            TransportTypes.Add(typeof(Sailboat));
        }

        private void RedrawTable()
        {
            listViewInfo.Items.Clear();
            foreach (Transport transport in TransportList)
            {
                Type type = transport.GetType();
                if (Attribute.IsDefined(type, typeof(TransportTypeAttribute)))
                {
                    var attributeValue = Attribute.GetCustomAttribute(type, typeof(TransportTypeAttribute)) as TransportTypeAttribute;
                    listViewInfo.Items.Add(attributeValue.TypeName);
                }
                else
                    listViewInfo.Items.Add("");
                listViewInfo.Items[listViewInfo.Items.Count - 1].SubItems.Add(transport.Name);
            }
        }

        private void CreateFormForAdd(Type transportType)
        {
            Form form = null;
            foreach (Form tmpForm in FormsList)
            {
                Type type = tmpForm.GetType();
                if (Attribute.IsDefined(type, typeof(FormWorkingTypesAttribute)))
                {
                    var attributeValue = Attribute.GetCustomAttribute(type, typeof(FormWorkingTypesAttribute)) as FormWorkingTypesAttribute;
                    if (attributeValue.CheckWorkersTypes(transportType))
                         form = (Form)Activator.CreateInstance(type);
                }
            }
            if (form != null)
                form.ShowDialog();
        }

        private void CreateFormForViewOrEdit(Object transport, bool readMode)
        {
            Form form = null;
            foreach (Form tmpForm in FormsList)
            {
                Type type = tmpForm.GetType();
                if (Attribute.IsDefined(type, typeof(FormWorkingTypesAttribute)))
                {
                    var attributeValue = Attribute.GetCustomAttribute(type, typeof(FormWorkingTypesAttribute)) as FormWorkingTypesAttribute;
                    if (attributeValue.CheckWorkersTypes(transport.GetType()))
                        form = (Form)Activator.CreateInstance(type, transport, readMode);
                }
            }
            if (form != null)
                form.ShowDialog();
        }

        public static void AddTransport(object transport)
        {
            TransportList.Add(transport);
        }
        private void ButAdd_Click(object sender, EventArgs e)
        {
            CreateFormForAdd(TransportTypes[ComboBoxTypeTransport.SelectedIndex]);
            RedrawTable();
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (listViewInfo.SelectedItems.Count == 0)
                return;
            object[] selectedTransport = new object[listViewInfo.SelectedItems.Count];
            ListView.SelectedIndexCollection indexes = listViewInfo.SelectedIndices;
            int i = 0;
            foreach (int index in indexes)
            {
                selectedTransport[i] = TransportList[index];
                i++;
            }
            ISerializer serializer = (ISerializer)Activator.CreateInstance(SerializersList[ComboBTypeSer.SelectedIndex]);
            saveFileDialog.Filter = serializer.FileExtension;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = saveFileDialog.FileName;
            serializer.Serialize(selectedTransport, filePath);

            DialogResult choice = MessageBox.Show("Зашифровать файл?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (comboBCrypt.SelectedIndex == -1)
                {
                    MessageBox.Show("Не загружены алгоритмы для шифрования.");
                    return;
                }
                Assembly assembly = Assembly.LoadFile(LibList[comboBCrypt.SelectedIndex]);
                object obj = assembly.CreateInstance("Algorithms");
                Type type = obj.GetType();
                MethodInfo method = type.GetMethod("Encrypt");
                method.Invoke(obj, new object[] { filePath });
                File.Delete(filePath);
            }
        }

        private ISerializer GetSerializer(string filepath)
        {
            ISerializer serializer = null;
            bool flag = false;
            foreach (Type ser in SerializersList)
            {
                serializer = (ISerializer)Activator.CreateInstance(ser);
                if ((serializer.FileExtension).IndexOf(Path.GetExtension(filepath)) != -1)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                return serializer;
            else
                return null;
        }


        private bool DectyptFile(ref string filePath)
        {
            string extension = Path.GetExtension(filePath);
            foreach (string pluginPath in LibList)
            {
                Assembly assembly = Assembly.LoadFile(pluginPath);
                object obj = assembly.CreateInstance("Algorithms");
                var attrs = Attribute.GetCustomAttributes(obj.GetType());
                foreach (var attr in attrs)
                {
                    if (attr.GetType().Name == typeof(ExtensionAttribute).Name)
                        if (Convert.ToString(attr.GetType().GetProperty("Extension").GetValue(attr)) == extension)
                        {
                            MethodInfo method = obj.GetType().GetMethod("Decrypt");
                            method.Invoke(obj, new object[] { filePath });
                            filePath = filePath.Substring(0, filePath.Length - extension.Length);
                            return true;
                        }
                }
            }
            return false;
        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            object[] loadTransport;
            bool checkCryptFile = false;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = openFileDialog.FileName;

            try
            {

                if (GetSerializer(filePath) == null)
                    if (DectyptFile(ref filePath) == false)
                    {
                        MessageBox.Show("Не загружен алгоритм для дешифрования.");
                        return;
                    }

                ISerializer serializer = GetSerializer(filePath);
                if (serializer == null)
                {
                    MessageBox.Show("Десериализация не удалась!");
                    return;
                }

                loadTransport = serializer.Deserialize(filePath);
                foreach (Transport transport in loadTransport)
                    TransportList.Add(transport);
                RedrawTable();

                if (checkCryptFile)
                {
                    File.Delete(filePath);
                    checkCryptFile = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewInfo.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexes = listViewInfo.SelectedIndices;
                CreateFormForViewOrEdit(TransportList[indexes[0]], false);
                RedrawTable();
            }
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewInfo.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexes = listViewInfo.SelectedIndices;
                TransportList.RemoveAt(indexes[0]);
                RedrawTable();
            }
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewInfo.SelectedItems.Count == 1)
            {
                ListView.SelectedIndexCollection indexes = listViewInfo.SelectedIndices;
                CreateFormForViewOrEdit(TransportList[indexes[0]], true);
            }
        }
    }
}
