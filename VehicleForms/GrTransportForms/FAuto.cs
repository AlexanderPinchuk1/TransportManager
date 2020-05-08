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
using CRUD.Attributes;

namespace CRUD.VehicleForms.GrTransportForms
{
    [FormWorkingTypes((new Type[] { typeof(Auto) }))]
    public partial class FAuto : FGroundTransport
    {
        private Auto receivedAuto = null;
        public FAuto()
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

            ButSave.Hide();
        }

        public FAuto(object transport, bool readMode)
        {
            InitializeForm();
            SetAuto((Auto)transport);
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
            comboBTypeBody.SelectedIndex = 0;
            comboBDriveUnit.SelectedIndex = 0;
        }


        private void TextBNumDoors_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnterData(sender, e);
        }

        public Body GetBody()
        {
            switch (comboBTypeBody.SelectedIndex)
            {
                case 0: return Body.none;
                case 1: return Body.sedan;
                case 2: return Body.hatchback;
                case 3: return Body.truck;
                case 4: return Body.coupe;
                case 5: return Body.supercar;
                case 6: return Body.suv;
                case 7: return Body.cuv;
                case 8: return Body.cabriolet;
                case 9: return Body.roadster;
                case 10: return Body.pickup;
                case 11: return Body.van;
            }
            return Body.sedan;
        }

        public void SetBody(Body body)
        {
            switch (body)
            {
                case Body.none: comboBTypeBody.SelectedIndex = 0; break;
                case Body.sedan: comboBTypeBody.SelectedIndex = 1; break;
                case Body.hatchback: comboBTypeBody.SelectedIndex = 2; break;
                case Body.truck: comboBTypeBody.SelectedIndex = 3; break;
                case Body.coupe: comboBTypeBody.SelectedIndex = 4; break;
                case Body.supercar: comboBTypeBody.SelectedIndex = 5; break;
                case Body.suv: comboBTypeBody.SelectedIndex = 6; break;
                case Body.cuv: comboBTypeBody.SelectedIndex = 7; break;
                case Body.cabriolet: comboBTypeBody.SelectedIndex = 8; break;
                case Body.roadster: comboBTypeBody.SelectedIndex = 9; break;
                case Body.pickup: comboBTypeBody.SelectedIndex = 10; break;
                case Body.van: comboBTypeBody.SelectedIndex = 11; break;
            }
        }

        public void SetDriveUnit(DriveUnit driveUnit)
        {
            switch (driveUnit)
            {
                case DriveUnit.none: comboBDriveUnit.SelectedIndex = 0; break;
                case DriveUnit.front: comboBDriveUnit.SelectedIndex = 1; break;
                case DriveUnit.rear: comboBDriveUnit.SelectedIndex = 2; break;
                case DriveUnit.full: comboBDriveUnit.SelectedIndex = 3; break;
            }

        }
        public DriveUnit GetDriveUnit()
        {
            switch (comboBDriveUnit.SelectedIndex)
            {
                case 0: return DriveUnit.none;
                case 1: return DriveUnit.front;
                case 2: return DriveUnit.rear;
                case 3: return DriveUnit.full;
            }
            return DriveUnit.front;
        }

        public void SetNumDoors(int numDoors)
        {
            if (numDoors != 0)
                TextBNumDoors.Text = Convert.ToString(numDoors);
            else
                TextBNumDoors.Text = "";
        }
        public int GetNumDoors()
        {
            if (TextBNumDoors.Text.Length != 0)
                return Convert.ToInt32(TextBNumDoors.Text);
            else
                return 0;
        }

        private void EditAuto(Auto auto)
        {
            auto.Name = GetName();
            auto.MaxSpeed = GetMaxSpeed();
            auto.NumDoors = GetNumDoors();
            auto.Weight = GetWeight();
            auto.Year = GetYear();
            auto.NumOfWheels = GetNumOfWheels();
            auto.Body = GetBody();
            auto.DriveUnit = GetDriveUnit();
            Engine engine = new Engine(GetPower(), GetVolume(), GetTypeFuel());
            auto.EngineInfo = engine;
            Transmission transmission = new Transmission(GetNumGears(), GetTypeTransmission());
            auto.TransmissionInfo = transmission;
        }

        public void SetAuto(Auto auto)
        {
            receivedAuto = auto;
            SetName(auto.Name);
            SetMaxSpeed(auto.MaxSpeed);
            SetNumDoors(auto.NumDoors);
            SetWeight(auto.Weight);
            SetYear(auto.Year);
            SetNumOfWheels(auto.NumOfWheels);
            SetBody(auto.Body);
            SetDriveUnit(auto.DriveUnit);
            SetPower(auto.EngineInfo.Power);
            SetVolume(auto.EngineInfo.Volume);
            SetTypeFuel(auto.EngineInfo.TypeFuel);
            SetNumGears(auto.TransmissionInfo.NumGears);
            SetTypeTransmission(auto.TransmissionInfo.TypeTransmission);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (receivedAuto == null)
            {
                Auto auto = new Auto();
                EditAuto(auto);
                FMenu.AddTransport(auto);
            }
            else
                EditAuto(receivedAuto);
            Close();
        }

    }
}
