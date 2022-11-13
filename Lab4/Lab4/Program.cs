using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            string mainString;
            bool temp = true;
            Console.WriteLine("Введите количество строк массива символов.");
            rows=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов массива символов.");
            columns=Convert.ToInt32(Console.ReadLine());

            char[,] mainMatrix = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"mainMatrix[{i}][{j}]");
                    mainMatrix[i, j] = Convert.ToChar(Console.ReadLine());
                }
            }

            Console.WriteLine("Введите исходную строку.");
            mainString=Console.ReadLine();

            char[] mainArray = mainString.ToCharArray();

            for (int i = 0; i < mainArray.Length && temp; i++)
            {
                temp = false;

                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        if (mainMatrix[j, k] == mainArray[i])
                        {
                            mainMatrix[j, k] = ' ';
                            temp = true;
                            break;
                        }
                    }
                }
            }

            if(temp)
                Console.WriteLine("Возможно составить слово.");
            else
                Console.WriteLine("Невозможно составить слово.");
        }
    }
}
