﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KozhevnikovDG.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            string[] lines = fileData.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries); 

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns]; 

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]); 
                }
            }

            for (int r = 0; r < rows; r++)
            {
                if (arrayValues[r, 7] % 5 == 0) 
                {
                    arrayValues[r, 7] = 2; 
                }
            }

            return arrayValues; 
        }
    }
}
