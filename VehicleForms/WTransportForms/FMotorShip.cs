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
    [FormWorkingTypes((new Type[] { typeof(MotorShip) }))]
    public partial class FMotorShip : FWaterTransport
    {
        private readonly MotorShip receivedMotorShip = null;
        public FMotorShip()
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


        public FMotorShip(object transport, bool readMode)
        {
            InitializeComponent();
            if (readMode == true)
                SetReadOnly();
            receivedMotorShip = (MotorShip)transport;
            SetMotorShip();
        }

        public void SetNumScrews(int tmpFirst)
        {
            if (tmpFirst != 0)
                TextNumScrews.Text = Convert.ToString(tmpFirst);
            else
                TextNumScrews.Text = "";
        }
        public int GetNumScrews()
        {
            if (TextNumScrews.Text.Length != 0)
                return Convert.ToInt32(TextNumScrews.Text);
            else
                return 0;
        }

        public void SetNumPipes(int tmpSecond)
        {
            if (tmpSecond != 0)
                TextBNumPipes.Text = Convert.ToString(tmpSecond);
            else
                TextBNumPipes.Text = "";
        }
        public int GetNumPipes()
        {
            if (TextBNumPipes.Text.Length != 0)
                return Convert.ToInt32(TextBNumPipes.Text);
            else
                return 0;
        }

        private void SetMotorShip()
        {
            SetName(receivedMotorShip.Name);
            SetMaxSpeed(receivedMotorShip.MaxSpeed);
            SetWeight(receivedMotorShip.Weight);
            SetYear(receivedMotorShip.Year);
            SetCrew(receivedMotorShip.Crew);
            SetNumOfDecks(receivedMotorShip.NumOfDecks);
            SetDisplacement(receivedMotorShip.Displacement);
            SetNumPipes(receivedMotorShip.NumPipes);
            SetNumScrews(receivedMotorShip.NumScrews);
        }


        private void EditMotorShip(MotorShip motorShip)
        {
            motorShip.Name = GetName();
            motorShip.MaxSpeed = GetMaxSpeed();
            motorShip.Weight = GetWeight();
            motorShip.Year = GetYear();
            motorShip.Crew = GetCrew();
            motorShip.NumOfDecks = GetNumOfDecks();
            motorShip.Displacement = GetDisplacement();
            motorShip.NumPipes = GetNumPipes();
            motorShip.NumScrews = GetNumScrews();
        }
        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedMotorShip == null)
            {
                MotorShip motorShip = new MotorShip();
                EditMotorShip(motorShip);
                FMenu.AddTransport(motorShip);
            }
            else
                EditMotorShip((MotorShip)receivedMotorShip);

            Close();
        }

        private void TextNumScrews_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        private void TextBNumPipes_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }
    }
}
