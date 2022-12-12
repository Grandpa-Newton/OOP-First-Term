using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class Polygon
    {
        public string TypeOfPolygon;
        public int[] Coordinates;
        public string Color;

        public Polygon(string typeOfPolygon, int[] coordinates, string color)
        {
            TypeOfPolygon = typeOfPolygon;
            Coordinates = coordinates;
            Color = color;
        }

        public abstract double GetS();

        public abstract double getPerimeter();

        public string GetInformation()
        {
            string infoString="";
            infoString += $"{TypeOfPolygon}: ";
            for (int i = 0; i < Coordinates.Length; i++)
            {
                infoString += Coordinates[i] + " ";
            }

            infoString += Color;
            infoString += " P = " + getPerimeter();
            infoString += " S = " + GetS() +"\r\n";

            return infoString;
        }
    }
}
