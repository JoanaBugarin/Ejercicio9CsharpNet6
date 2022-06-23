using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9CsharpNet6
{
    public abstract class Cuadrilatero
    {
        public int[] verticeA { get; set; }
        public int[] verticeB { get; set; }
        public int[] verticeC { get; set; }
        public int[] verticeD { get; set; }

        public Cuadrilatero(int AEjeX, int AEjeY, int BEjeX, int BEjeY,
            int CEjeX, int CEjeY, int DEjeX, int DEjeY)
        {
            verticeA = new int[2];
            verticeA[0] = AEjeX;
            verticeA[1] = AEjeY;
            
            verticeB = new int[2];
            verticeB[0] = BEjeX;
            verticeB[1] = BEjeY;

            verticeC = new int[2];
            verticeC[0] = CEjeX;
            verticeC[1] = CEjeY;

            verticeD = new int[2];
            verticeD[0] = DEjeX;
            verticeD[1] = DEjeY;
        }

        public abstract double calcularArea();
    }
}
