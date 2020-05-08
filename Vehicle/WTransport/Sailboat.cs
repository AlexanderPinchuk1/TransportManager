using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Attributes;

namespace CRUD.Vehicle.WTransport
{
    [Serializable]
    [TransportType("Паурсник")]
    class Sailboat : WaterTransport
    {
        public int NumSails { get; set; }
        public int NumMasts { get; set; }
    }
}
