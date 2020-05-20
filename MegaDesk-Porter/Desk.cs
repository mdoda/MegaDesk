using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Porter
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {

        //constants
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;

        //properties    
        public decimal Depth { get; set; }

        public decimal Width { get; set; }

        public int Drawers { get; set; }

        public DesktopMaterial DesktopMaterial { get; set; }

        public decimal Shipping {get; set;}
    }
}
