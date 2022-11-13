using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length;
            string name;

            bool doesExist=true;

            Console.WriteLine("Матрица A: ");

            Console.WriteLine("Введите размерность квадратной матрицы.");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя квадратной матрицы.");
            name = Console.ReadLine();

            SquareMatrix firstMatrix = new SquareMatrix(length, name);

            Console.Clear();

            Console.WriteLine("Матрица A: ");

            firstMatrix.InputMatrix();

            Console.Clear();


            Console.WriteLine("Матрица B: ");

            Console.WriteLine("Введите размерность квадратной матрицы.");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя квадратной матрицы.");
            name = Console.ReadLine();

            SquareMatrix secondMatrix = new SquareMatrix(length, name);

            Console.Clear();

            secondMatrix.InputMatrix();

            Console.Clear();


            Console.WriteLine("Матрица C: ");

            Console.WriteLine("Введите размерность квадратной матрицы.");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя квадратной матрицы.");
            name = Console.ReadLine();

            SquareMatrix thirdMatrix = new SquareMatrix(length, name);

            Console.Clear();

            thirdMatrix.InputMatrix();

            Console.Clear();

            SquareMatrix matrixOfSubstraction = firstMatrix;

            if (firstMatrix.Length != secondMatrix.Length)
                doesExist = false;
            else
                matrixOfSubstraction = firstMatrix - secondMatrix;

            while (true)
            {
                int choiseMenu;
                int numberOfDiagonal;

                Console.WriteLine("МЕНЮ");
                Console.WriteLine("1. Вывод матриц.");
                Console.WriteLine("2. Вывод сведений о матрицах.");
                Console.WriteLine("3. Произведение главной и двух соседних диагоналей матрицы А.");
                Console.WriteLine("4. Произведение главной и двух соседних диагоналей матрицы A-B.");
                Console.WriteLine("5. Произведение элементов всех диагоналей матрицы C.");
                Console.WriteLine("6. Произведение элементов диагоналей с заданными номерами матрицы B.");
                Console.WriteLine("7. Проверка A=B => Увеличение всех положительных элементов главной диагонали в 2 раза");
                Console.WriteLine("8. ВЫХОД");

                choiseMenu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (choiseMenu)
                {
                    case 1:
                        Console.WriteLine("Матрица А: ");
                        firstMatrix.OutputMatrix();

                        Console.WriteLine("Матрица B: ");
                        secondMatrix.OutputMatrix();

                        Console.WriteLine("Матрица C: ");
                        thirdMatrix.OutputMatrix();
                        break;

                    case 2:
                        Console.WriteLine((string)firstMatrix);
                        Console.WriteLine((string)secondMatrix);
                        Console.WriteLine((string)thirdMatrix);
                        break;

                    case 3:
                        Console.WriteLine("Произведение элементов главной диагонали матрицы A: ");

                        Console.WriteLine(Convert.ToString(firstMatrix.SumOfDiagonal()));

                        Console.WriteLine("Произведение элементов соседней справа от главной диагонали матрицы А: ");

                        firstMatrix.SumOfDiagonal(1);

                        Console.WriteLine("Произведение элементов соседней слева от главной диагонали матрицы А: ");

                        firstMatrix.SumOfDiagonal(-1);
                        break;

                    case 4:
                        Console.WriteLine("Произведение элементов главной диагонали матрицы A-B: ");

                        Console.WriteLine(Convert.ToString(matrixOfSubstraction.SumOfDiagonal()));

                        Console.WriteLine("Произведение элементов соседней справа от главной диагонали матрицы А-B: ");

                        matrixOfSubstraction.SumOfDiagonal(1);

                        Console.WriteLine("Произведение элементов соседней слева от главной диагонали матрицы А-B: ");

                        matrixOfSubstraction.SumOfDiagonal(-1);

                        break;

                    case 5:
                        for (int i = 0; i < thirdMatrix.Length; i++)
                        {
                            Console.WriteLine($"Произведение элементов {i}-й от главной диагонали матрицы C");
                            thirdMatrix.SumOfDiagonal(i);
                            if (i!=0)
                            {
                                Console.WriteLine($"Произведение элементов -{i}-й от главной диагонали матрицы C");
                                thirdMatrix.SumOfDiagonal(-i);
                            }
                            
                        }
                        break;

                    case 6:
                        Console.WriteLine("Укажите номер диагонали от главной (0 - главная, 1 - соседняя справа и т.д.)");
                        numberOfDiagonal = Convert.ToInt32(Console.ReadLine());
                        secondMatrix.SumOfDiagonal(numberOfDiagonal);
                        break;

                    case 7:
                        if (!matrixOfSubstraction.CheckIfEqual() || !doesExist)
                            Console.WriteLine("Матрица А и B не равны");
                        else
                        {
                            firstMatrix.MultipleMainDiagonal();
                            secondMatrix.MultipleMainDiagonal();
                            Console.WriteLine("Положительные элементы главных диагоналей матриц A и B увеличены в два раза.");
                        }

                        break;

                    case 8:
                        return;
                }

                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
