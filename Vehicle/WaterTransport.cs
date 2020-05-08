using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Vehicle
{
    [Serializable]
    abstract class WaterTransport : Transport
    {
        public int NumOfDecks { set; get; }
        public int Displacement { set; get; }
        public int Crew { set; get; }
    }
}
