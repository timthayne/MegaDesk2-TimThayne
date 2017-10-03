using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        // enums
        public enum Surface
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        // properties
        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int NumberOfDrawers { get; set; }

        public Surface SurfaceMaterial { get; set; }
    }
}
