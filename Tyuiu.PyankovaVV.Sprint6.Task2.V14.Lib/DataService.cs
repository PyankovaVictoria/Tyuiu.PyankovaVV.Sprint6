using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyankovaVV.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] massive = new double[len];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = 5 - 3 * x + (1 + Math.Sin(x)) / (2 * x - 0.5);
                y = Math.Round(y, 2);
                if (2 * x - 0.5 == 0)
                {
                    y = 0;
                }

                massive[i] = y;
                i++;
            }
            return (massive);
        }
    }
}
