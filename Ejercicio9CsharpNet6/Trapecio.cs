using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9CsharpNet6
{
    public class Trapecio : Cuadrilatero
    {
        public Trapecio(int AEjeX, int AEjeY, int BEjeX, int BEjeY, int CEjeX, int CEjeY, int DEjeX, int DEjeY) : base(AEjeX, AEjeY, BEjeX, BEjeY, CEjeX, CEjeY, DEjeX, DEjeY)
        {
        }

        public override double calcularArea()
        {
            double area = 0;
            double[] lados = new double[4];
            lados[0] = Math.Sqrt(Math.Pow((verticeB[0] - verticeA[0]), 2) + Math.Pow((verticeB[1] - verticeA[1]), 2));
            lados[1] = Math.Sqrt(Math.Pow((verticeC[0] - verticeB[0]), 2) + Math.Pow((verticeC[1] - verticeB[1]), 2));
            lados[2] = Math.Sqrt(Math.Pow((verticeD[0] - verticeC[0]), 2) + Math.Pow((verticeD[1] - verticeC[1]), 2));
            lados[3] = Math.Sqrt(Math.Pow((verticeA[0] - verticeD[0]), 2) + Math.Pow((verticeA[1] - verticeD[1]), 2));

            if (lados.Max() == lados[0])
            {
                area = (lados[0] + lados[2]) / 2 * 
                    (Math.Sqrt(Math.Pow(lados[1],2) - (Math.Pow(lados[1], 2) - Math.Pow(lados[3], 2) + Math.Pow(lados[0] - lados[2],2)) / 2 * (lados[0] - lados[2])));
                return area;
            }

            else if (lados.Max() == lados[1])
            {
                area = (lados[1] + lados[3]) / 2 *
                    (Math.Sqrt(Math.Pow(lados[2], 2) - (Math.Pow(lados[2], 2) - Math.Pow(lados[0], 2) + Math.Pow(lados[1] - lados[3], 2)) / 2 * (lados[1] - lados[3])));
                return area;
            }

            else if (lados.Max() == lados[2])
            {
                area = (lados[2] + lados[0]) / 2 *
                    (Math.Sqrt(Math.Pow(lados[3], 2) - (Math.Pow(lados[3], 2) - Math.Pow(lados[1], 2) + Math.Pow(lados[2] - lados[0], 2)) / 2 * (lados[2] - lados[0])));
                return area;
            }

            else
            {
                area = (lados[3] + lados[1]) / 2 *
                    (Math.Sqrt(Math.Pow(lados[0], 2) - (Math.Pow(lados[0], 2) - Math.Pow(lados[2], 2) + Math.Pow(lados[3] - lados[1], 2)) / 2 * (lados[3] - lados[1])));
                return area;
            }
            
        }
    }
}
