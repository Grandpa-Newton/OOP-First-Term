using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("start.txt");
            Polygon[] polygons = new Polygon[lines.Length];
            string number = @"[0-9]";
            int amountOfNumbers;
            char[] tempArray;
            string[] stringArray;
            int[] tempCoordinateArray;

            for (int i = 0; i < lines.Length; i++)
            {
                amountOfNumbers = 1;
               // tempArray = lines[i].ToCharArray();
                /*for (int j = 1; j < tempArray.Length; j++)
                {
                    if (tempArray[j-1] == ' ' && tempArray[j] == Convert.ToChar(number))
                        amountOfNumbers++;
                }*/
                
                stringArray = lines[i].Split(' ');

                if (stringArray.Length == 5)
                {
                    tempCoordinateArray = new int[4];
                    for (int j = 0; j < 4; j++)
                    {
                        tempCoordinateArray[j] = Convert.ToInt32(stringArray[j]);
                    }
                    polygons[i] = new Rectangle("Rectangle", tempCoordinateArray, stringArray[4]);
                }
                else if (stringArray.Length==7)
                {
                    tempCoordinateArray = new int[6];
                    for (int j = 0; j < 6; j++)
                    {
                        tempCoordinateArray[j] = Convert.ToInt32(stringArray[j]);
                    }
                    polygons[i] = new Triangle("Triangle", tempCoordinateArray, stringArray[6]);
                }
            }
             //s
            for (int i = 0; i < polygons.Length; i++)
            {
                Console.WriteLine(polygons[i].GetInformation());
            }

            Polygon tempPolygon;

            for (int i = 0; i < polygons.Length-1; i++)
            {
                for (int j = i+1; j < polygons.Length; j++)
                {
                    if (polygons[i].GetS() > polygons[j].GetS())
                    {
                        tempPolygon = polygons[i];
                        polygons[i] = polygons[j];
                        polygons[j] = tempPolygon;
                    }
                }
            }

            Console.WriteLine("Отсортированный: ");

            for (int i = 0; i < polygons.Length; i++)
            {
                Console.WriteLine(polygons[i].GetInformation());
            }

            for (int i = 0; i < polygons.Length; i++)
            {
                if (polygons[i] is Triangle)
                {
                    double aSquare = Math.Pow(polygons[i].Coordinates[2] - polygons[i].Coordinates[0], 2) 
                        + Math.Pow(polygons[i].Coordinates[3] - polygons[i].Coordinates[1], 2);
                    double bSquare = Math.Pow(polygons[i].Coordinates[2] - polygons[i].Coordinates[4], 2) 
                        + Math.Pow(polygons[i].Coordinates[3] - polygons[i].Coordinates[5], 2);
                    double cSquare = Math.Pow(polygons[i].Coordinates[4] - polygons[i].Coordinates[0], 2)
                        + Math.Pow(polygons[i].Coordinates[5] - polygons[i].Coordinates[1], 2);

                    if (aSquare == (bSquare + cSquare) || bSquare == (cSquare + aSquare) 
                        || cSquare == (aSquare + bSquare))
                    {
                        if ((polygons[i].Coordinates[0] <= 0) && (polygons[i].Coordinates[2] <= 0) && (polygons[i].Coordinates[4]<=0)
                            && (polygons[i].Coordinates[1] >= 0) && (polygons[i].Coordinates[3] >= 0) && (polygons[i].Coordinates[5]>=0))
                        {
                            polygons[i].Color = "Green";
                        }
                    }
                    
                }


            }

            Console.WriteLine("С учётом прямоугольных треугольников в II четверти: ");

            for (int i = 0; i < polygons.Length; i++)
            {
                Console.WriteLine(polygons[i].GetInformation());
            }

        }
    }
}
