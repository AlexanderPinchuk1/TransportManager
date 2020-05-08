using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.VehicleElements
{
    public enum TypeTransmission
    {
        none,
        mechanical,
        automatic,
        robotic
    }

    [Serializable]
    public class Transmission
    {
        public int NumGears { get; set; }
        public TypeTransmission TypeTransmission { get; set; }


        public Transmission()
        {
        }

        public Transmission(int numGears, TypeTransmission typeTransmission)
        {
            this.NumGears = numGears;
            this.TypeTransmission = typeTransmission;
        }
    }
}