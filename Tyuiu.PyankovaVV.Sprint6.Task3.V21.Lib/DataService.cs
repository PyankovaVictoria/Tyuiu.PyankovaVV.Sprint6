﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyankovaVV.Sprint6.Task3.V21.Lib
{
    public class DataService : ISprint6Task3V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            List<int> n = new List<int>();
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                n.Add(matrix[i, 0]);
                n.Sort((x, y) => x.CompareTo(y));

            }
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 0] = n[count];
                count++;
            }
            return matrix;
        }
    }
}
