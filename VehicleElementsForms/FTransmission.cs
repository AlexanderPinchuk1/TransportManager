using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.VehicleElements;

namespace CRUD.VehicleElementsForms
{
    public partial class FTransmission : Form
    {
        public bool ReadOnly = false;
        public FTransmission()
        {
            InitializeComponent();
            ComboBTypeTransmission.SelectedIndex = 0;
        }

        public void SetReadOnly()
        {
            foreach (var TextBox in Controls.OfType<TextBox>())
            {
                TextBox.ReadOnly = true;
            }
            foreach (var ComboBox in Controls.OfType<ComboBox>())
            {
                ComboBox.Enabled = false;
            }

            ButSave.Hide();
        }

        public void SetNumGears(int NumGears)
        {
            if (NumGears != 0)
                TextBNumGears.Text = Convert.ToString(NumGears);
            else
                TextBNumGears.Text = "";
        }
        public int GetNumGears()
        {
            if (TextBNumGears.Text.Length != 0)
                return Convert.ToInt32(TextBNumGears.Text);
            else
                return 0;
        }

        public void SetTypeTransmission(TypeTransmission TypeTransmission)
        {
            switch (TypeTransmission)
            {
                case TypeTransmission.none: ComboBTypeTransmission.SelectedIndex = 0; break;
                case TypeTransmission.mechanical: ComboBTypeTransmission.SelectedIndex = 1; break;
                case TypeTransmission.automatic: ComboBTypeTransmission.SelectedIndex = 2; break;
                case TypeTransmission.robotic: ComboBTypeTransmission.SelectedIndex = 3; break;
            }
        }
        public TypeTransmission GetTypeTransmission()
        {
            switch (ComboBTypeTransmission.SelectedIndex)
            {
                case 0: return TypeTransmission.none;
                case 1: return TypeTransmission.mechanical;
                case 2: return TypeTransmission.automatic;
                case 3: return TypeTransmission.robotic;
            }
            return TypeTransmission.none;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBNumGears_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FTransmission_Shown(object sender, EventArgs e)
        {
            if (ReadOnly == true)
                SetReadOnly();
        }
    }
}
