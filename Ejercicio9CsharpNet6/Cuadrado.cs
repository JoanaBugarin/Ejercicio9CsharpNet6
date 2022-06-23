using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9CsharpNet6
{
    public class Cuadrado : Cuadrilatero
    {

        public Cuadrado(int AEjeX, int AEjeY, int BEjeX, int BEjeY, int CEjeX, int CEjeY, int DEjeX, int DEjeY) : base(AEjeX, AEjeY, BEjeX, BEjeY, CEjeX, CEjeY, DEjeX, DEjeY)
        {
            
        }

        public override double calcularArea()
        {
            double lado = Math.Sqrt(Math.Pow((verticeB[0] - verticeA[0]),2) + Math.Pow((verticeB[1] - verticeA[1]),2));
            double area = lado * lado;
            return area;
        }
    }
}
