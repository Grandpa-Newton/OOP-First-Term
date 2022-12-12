using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Triangle : Polygon
    {
        public Triangle(string typeOfPolygon, int[] coordinates, string color) : base(typeOfPolygon, coordinates, color)
        {
        }

        /* 0 - левый X, 1 - левый Y, 2 - центр X
         * 3 - центр Y, 4 - правый X, 5 - правый Y
        */
        public override double getPerimeter()
        {
            return (GetFirstSide() + GetSecondSide() + GetThirdSide());
        }

        public override double GetS()
        {
            double a = GetFirstSide();
            double b = GetSecondSide();
            double c = GetThirdSide();
            double S = 0.25 * Math.Sqrt((a + b - c) * (a - b + c) * (-a + b + c) * (a + b + c));
            return S;
        }

        double GetFirstSide()
        {
            return Math.Sqrt(Math.Pow(Coordinates[2] - Coordinates[0], 2) + Math.Pow(Coordinates[3] - Coordinates[1], 2));
        }

        double GetSecondSide()
        {
            return Math.Sqrt(Math.Pow(Coordinates[2] - Coordinates[4], 2) + Math.Pow(Coordinates[3] - Coordinates[5], 2));
        }

        double GetThirdSide()
        {
            return Math.Sqrt(Math.Pow(Coordinates[4] - Coordinates[0], 2) + Math.Pow(Coordinates[5] - Coordinates[1], 2));
        }

    }
}
