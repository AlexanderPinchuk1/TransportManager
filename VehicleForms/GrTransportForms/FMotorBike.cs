using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Vehicle.GrTransport;
using CRUD.VehicleElements;
using CRUD.VehicleElementsForms;
using CRUD.Attributes;

namespace CRUD.VehicleForms.GrTransportForms
{
    [FormWorkingTypes((new Type[] { typeof(MotorBike) }))]
    public partial class FMotorBike : FGroundTransport
    {
        
        private MotorBike receivedMotorBike = null;
        public FMotorBike()
        {
            InitializeForm();
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
            foreach (var RadioButton in Controls.OfType<RadioButton>())
            {
                RadioButton.Enabled = false;
            }

            ButSave.Hide();
        }


        public FMotorBike(object transport, bool readMode)
        {
            InitializeForm();
            SetMotorBike((MotorBike)transport);
            if (readMode == true)
            {
                SetReadOnly();
                FEngine.ReadOnly = true;
                FTransmission.ReadOnly = true;
            }
        }


        private void InitializeForm()
        {
            InitializeComponent();
            RButSideCarNo.Checked = true;
            FEngine = new FEngine();
            FTransmission = new FTransmission();
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedMotorBike == null)
            {
                MotorBike motorBike = new MotorBike();
                EditMotorBike(motorBike);
                FMenu.AddTransport(motorBike);
            }
            else
                EditMotorBike(receivedMotorBike);
            Close();
        }

        public void SetSideCar(SideCar sideCar)
        {
            switch (sideCar)
            {
                case SideCar.yes: RButSideCarYes.Checked = true; break;
                case SideCar.no: RButSideCarNo.Checked = true; break;
            }
        }

        public SideCar GetSideCar()
        {
            if (RButSideCarYes.Checked == true)
                return SideCar.yes;
            else
                return SideCar.no;
        }

        private void EditMotorBike(MotorBike motorBike)
        {
            motorBike.Name = GetName();
            motorBike.MaxSpeed = GetMaxSpeed();
            motorBike.Weight = GetWeight();
            motorBike.Year = GetYear();
            motorBike.NumOfWheels = GetNumOfWheels();
            motorBike.SideCar = GetSideCar();
            Engine engine = new Engine(GetPower(), GetVolume(), GetTypeFuel());
            motorBike.EngineInfo = engine;
            Transmission transmission = new Transmission(GetNumGears(), GetTypeTransmission());
            motorBike.TransmissionInfo = transmission;
        }

        public void SetMotorBike(MotorBike motorBike)
        {
            receivedMotorBike = motorBike;
            SetName(motorBike.Name);
            SetMaxSpeed(motorBike.MaxSpeed);
            SetWeight(motorBike.Weight);
            SetYear(motorBike.Year);
            SetNumOfWheels(motorBike.NumOfWheels);
            SetSideCar(motorBike.SideCar);
            SetPower(motorBike.EngineInfo.Power);
            SetVolume(motorBike.EngineInfo.Volume);
            SetTypeFuel(motorBike.EngineInfo.TypeFuel);
            SetNumGears(motorBike.TransmissionInfo.NumGears);
            SetTypeTransmission(motorBike.TransmissionInfo.TypeTransmission);
        }
    }
}
