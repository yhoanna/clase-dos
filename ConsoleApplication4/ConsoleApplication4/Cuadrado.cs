using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Cuadrado : Figura
    {
          public override float Area()
    {
        return  (Base *Altura);
    }
    public float Perimetro()
      {
        return (Base * 4); 
      }
    public Cuadrado(float Base, float Altura)
    {
        this.Base = Base;
        this.Altura = Altura;
    }
        
    }
}
