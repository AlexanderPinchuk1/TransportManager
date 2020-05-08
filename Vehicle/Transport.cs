using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Vehicle
{
    [Serializable]
    public abstract class Transport
    {
        public string Name { get; set; } = "";
        public int Year { get; set; }
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
    }
}
