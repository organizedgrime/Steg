using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steg
{
    class DCTFunctions
    {

        double[,] p = new double[,]
        {
            { .3536, .3536, .3536, .3536, .3536, .3536, .3536, .3536 },
            { .3536, .3536, .3536, .3536, .3536, .3536, .3536, .3536 },
            { .3536, .3536, .3536, .3536, .3536, .3536, .3536, .3536 },
            { .3536, .3536, .3536, .3536, .3536, .3536, .3536, .3536 },
            { .3536, .3536, .3536, .3536, .3536, .3536, .3536, .3536 },
            { .3536, .3536, .3536, .3536, .3536, .3536, .3536, .3536 },
            { .3536, .3536, .3536, .3536, .3536, .3536, .3536, .3536 },
            { .3536, .3536, .3536, .3536, .3536, .3536, .3536, .3536 }
        };

        
        public static double[,] theDCT(double[,] p)
        {
            
            //2D version of DCT II
            double[,] D = new double[,] { };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //the 2D DCT equation for an 8x8 grid of pixels
                    D[i, j] = (1/4)*C(i)*C(j) * getSum(i, j, p);
                }
            }
            


            return D;
        }

        public static double C(int u)
        {
            if (u == 0)
            {
                return (1 / 4);
            }
            else if (u > 0)
            {
                return 1;
            }
            return 0;
        }

        public static double getSum(int i, int j, double[,] p)
        {
            double sum = 0;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    sum += p[x, y] * Math.Cos(((2 * x + 1) * i * Math.PI) / 16) * Math.Cos(((2 * y + 1) * j * Math.PI) / 16);
                }
            }
            return sum;
        }

    }
}
