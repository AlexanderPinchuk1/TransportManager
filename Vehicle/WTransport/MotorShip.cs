using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Attributes;

namespace CRUD.Vehicle.WTransport
{
    [Serializable]
    [TransportType("Теплоход")]
    class MotorShip : WaterTransport
    {
        public int NumScrews { get; set; }
        public int NumPipes { get; set; }
    }
}
