using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.VehicleElements;
using CRUD.Attributes;

namespace CRUD.Vehicle.GrTransport
{
    public enum SideCar
    {
        yes,
        no
    }
    [Serializable]
    [TransportType("Мотоцикл")]
    public class MotorBike : GroundTransport
    {
        public SideCar SideCar { get; set; }

        public MotorBike()
        {
            EngineInfo = new Engine();
            TransmissionInfo = new Transmission();
        }
    }
}
