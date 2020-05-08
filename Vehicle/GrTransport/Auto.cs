using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.VehicleElements;
using CRUD.Attributes;

namespace CRUD.Vehicle.GrTransport
{
    public enum DriveUnit
    {
        none,
        front,
        rear,
        full
    }
    public enum Body
    {
        none,
        sedan,
        hatchback,
        truck,
        coupe,
        supercar,
        suv,
        cuv,
        cabriolet,
        roadster,
        pickup,
        van
    }

    [Serializable]
    [TransportType("Автомобиль")]
    public class Auto : GroundTransport
    {
        public int NumDoors { get; set; }
        public Body Body { get; set; }
        public DriveUnit DriveUnit { get; set; }
        public Auto()
        {
            EngineInfo = new Engine();
            TransmissionInfo = new Transmission();
        }
    }
}
