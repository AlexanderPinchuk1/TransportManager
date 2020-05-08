using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.VehicleElements;

namespace CRUD.Vehicle
{
    [Serializable]
    abstract public class GroundTransport : Transport
    {
        public int NumOfWheels { get; set; }
        public Engine EngineInfo { get; set; }
        public Transmission TransmissionInfo { get; set; }
    }
}
