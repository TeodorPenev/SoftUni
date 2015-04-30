using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Document_System
{
    public class Color
    {
        public static  Color Red {get{return new Color(255, 50, 50);}}

        public static  Color Green {get{return new Color(255, 50, 50);}}

        public static  Color Blue {get{return new Color(255, 50, 50);}}

        public byte RedValue { get; set; }

        public byte GreenValue { get; set; }

        public byte BlueValue { get; set; }

        public Color(byte red, byte green, byte blue)
        {
            this.RedValue = red;
            this.GreenValue = green;
            this.BlueValue = blue;
        }
        
    }
}
