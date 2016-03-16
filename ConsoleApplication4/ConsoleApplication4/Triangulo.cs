using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Triangulo : Figura
    {
    public override float Area()
    {
       return (Base * Altura) /2;
    }
    public float Perimetro()
      {
        return (Base * 3); 
      }
    public Triangulo(float Base, float Altura)
    {
        this.Base = Base;
        this.Altura = Altura;
    }
    }
}
