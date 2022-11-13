using System;

namespace Laba_1
{
    internal class Program
    {
        static void SetVertices (Rectangle rectangle)
        {
            Console.WriteLine("Введите X левой верхней точки прямоугольника");
            rectangle.X_lefttop = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y левой верхней точки прямоугольника");
            rectangle.Y_lefttop = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X правой верхней точки прямоугольника");
            rectangle.X_righttop = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y правой верхней точки прямоугольника");
            rectangle.Y_righttop = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X правой нижней точки прямоугольника");
            rectangle.X_rightbottom = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y правой нижней точки прямоугольника");
            rectangle.Y_rightbottom = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите X левой нижней точки прямоугольника");
            rectangle.X_leftbottom = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y левой нижней точки прямоугольника");
            rectangle.Y_leftbottom = Convert.ToDouble(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            SetVertices(rectangle);

            int menuItem=0;


            while(true)
            {
                Console.Clear();
                Console.WriteLine("МЕНЮ\n");
                Console.WriteLine("1. Проверка, существует ли фигура");
                Console.WriteLine("2. Вычисление длины сторон");
                Console.WriteLine("3. Вычисление периметра");
                Console.WriteLine("4. Вычисление площади");
                Console.WriteLine("5. Проверка, где находится точка по отношению к прямоугольнику");
                Console.WriteLine("6. Выход");

                menuItem=Convert.ToInt32(Console.ReadLine());

                switch(menuItem)
                {
                    case 1:
                        rectangle.DoesExists();
                        break;

                    case 2:
                        rectangle.GetSideLength();
                        break;

                    case 3:
                        rectangle.GetPerimeter();
                        break;

                    case 4:
                        rectangle.GetSquare();
                        break;

                    case 5:
                        rectangle.DoesBelongs();
                        break;
                    case 6:
                        return;
                        break;

                    default:
                        break;
                }
            }

        }
    }

    
    class Rectangle
    {
        public double X_lefttop;
        public double Y_lefttop;

        public double X_righttop;
        public double Y_righttop;

        public double X_rightbottom;
        public double Y_rightbottom;

        public double X_leftbottom;
        public double Y_leftbottom;

        public bool doesExists; // проверка на существование фигуры

        public void DoesExists()
        {
            // если существует, то doesExists=true, нет - doesExists=false;
        }

        public void GetSideLength()
        {
            if (!doesExists)
            {
                Console.WriteLine("Фигура не существует. Невозможно посчитать.");
                return;
            }
            else 
            {
            
            }
        }

        public void GetPerimeter()
        {

        }

        public void GetSquare()
        {

        }

        public void DoesBelongs()
        {

        }
    }
}
