using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Rectangle : Polygon
    {
        public Rectangle(string typeOfPolygon, int[] coordinates, string color) : base(typeOfPolygon, coordinates, color)
        {
        } 
        /* 0 - левый верх X, 1 - левый верх Y, 2 - правый низ X
           * 3 - правый низ Y
        */
        public override double getPerimeter()
        {
            double P = 2 * (GetHorizontalSide() + GetLateralSide());
            return P;
        }

        public override double GetS()
        {
            double S = GetHorizontalSide() * GetLateralSide();
            return S;
        }

        public int GetLateralSide()
        {
            return Coordinates[1] - Coordinates[3];
        }

        public int GetHorizontalSide()
        {
            return Coordinates[2] - Coordinates[0];
        }
    }
}
