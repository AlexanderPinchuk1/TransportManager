using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Attributes;

namespace CRUD.Vehicle.WTransport
{
    [Serializable]
    [TransportType("Подлодка")]
    class Submarine : WaterTransport
    {
        public int MaxImmersionDepth { get; set; }
        public int NumTurbines { get; set; }
    }
}
