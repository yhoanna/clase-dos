using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f;
            f = new Circulo(10);
            Console.WriteLine(f.Area());
            f = new Triangulo(5, 6);
            Console.WriteLine(f.Area());
            f = new Cuadrado(10, 5);
            Console.WriteLine(f.Area());
            f = new Circulo(5);
            Console.WriteLine(f.Perimetro());
            f = new Triangulo(3, 3);
            Console.WriteLine(f.Perimetro());
            f = new Cuadrado(6, 6);
            Console.WriteLine(f.Perimetro());
            Console.ReadKey();
        }
    }
}
