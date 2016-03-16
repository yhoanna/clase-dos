using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Circulo : Figura
    {
        public override float Area()
        {
           return (float)Math.PI * Radio * Radio;
        }
        public float Perimetro()
        {
           return (Radio * Radio);
        }
        public Circulo(float Radio)
        {
            this.Radio = Radio;
        }
    }
}
