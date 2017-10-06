using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public struct Desk
    {
        // enums
        public enum DesktopMaterial
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

        public DesktopMaterial Material { get; set; }
    }
}
