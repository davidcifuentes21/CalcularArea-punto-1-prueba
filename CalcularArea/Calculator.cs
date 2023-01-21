using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    public class Calculator
    {
        public static double CircleCalculator(double radio)
        {

            return 2 * Math.PI * radio;
        }

        public static int RectangleCalculator(int altura, int bas)
        {
            return altura * bas;
        }

    }
}
