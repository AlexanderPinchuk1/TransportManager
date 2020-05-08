using CRUD.Vehicle.WTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Attributes;

namespace CRUD.VehicleForms.WTransportForms
{

    [FormWorkingTypes((new Type[] { typeof(Submarine) }))]
    public partial class FSubmarine : FWaterTransport
    {
        private readonly Submarine receivedSubmarine = null;
        public FSubmarine()
        {
            InitializeComponent();
        }
        public void SetReadOnly()
        {
            foreach (var TextBox in Controls.OfType<TextBox>())
            {
                TextBox.ReadOnly = true;
            }
            ButSave.Hide();
        }

        public FSubmarine(object transport, bool readMode)
        {
            InitializeComponent();
            if (readMode == true)
                SetReadOnly();
            receivedSubmarine = (Submarine)transport;
            SetSubmarine();
        }

        public void SetMaxImmersionDepth(int tmpFirst)
        {
            if (tmpFirst != 0)
                TextBMaxImmersionDepth.Text = Convert.ToString(tmpFirst);
            else
                TextBMaxImmersionDepth.Text = "";
        }
        public int GetMaxImmersionDepth()
        {
            if (TextBMaxImmersionDepth.Text.Length != 0)
                return Convert.ToInt32(TextBMaxImmersionDepth.Text);
            else
                return 0;
        }

        public void SetNumTurbines(int tmpSecond)
        {
            if (tmpSecond != 0)
                TextBTurbines.Text = Convert.ToString(tmpSecond);
            else
                TextBTurbines.Text = "";
        }
        public int GetNumTurbines()
        {
            if (TextBTurbines.Text.Length != 0)
                return Convert.ToInt32(TextBTurbines.Text);
            else
                return 0;
        }


        private void SetSubmarine()
        {
            SetName(receivedSubmarine.Name);
            SetMaxSpeed(receivedSubmarine.MaxSpeed);
            SetWeight(receivedSubmarine.Weight);
            SetYear(receivedSubmarine.Year);
            SetCrew(receivedSubmarine.Crew);
            SetNumOfDecks(receivedSubmarine.NumOfDecks);
            SetDisplacement(receivedSubmarine.Displacement);
            SetMaxImmersionDepth(receivedSubmarine.MaxImmersionDepth);
            SetNumTurbines(receivedSubmarine.NumTurbines);
        }

        private void EditSubmarine(Submarine submarine)
        {
            submarine.Name = GetName();
            submarine.MaxSpeed = GetMaxSpeed();
            submarine.Weight = GetWeight();
            submarine.Year = GetYear();
            submarine.Crew = GetCrew();
            submarine.NumOfDecks = GetNumOfDecks();
            submarine.Displacement = GetDisplacement();
            submarine.MaxImmersionDepth = GetMaxImmersionDepth();
            submarine.NumTurbines = GetNumTurbines();
        }
        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedSubmarine == null)
            {
                Submarine submarine= new Submarine();
                EditSubmarine(submarine);
                FMenu.AddTransport(submarine);
            }
            else
                EditSubmarine(receivedSubmarine);

            Close();

        }

        private void TextBMaxImmersionDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void TextBTurbines_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
