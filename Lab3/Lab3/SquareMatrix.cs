using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class SquareMatrix
    {
        private float[,] _matrix;

        public string Name;

        public int Length { get { return _matrix.GetLength(0); } }

        public SquareMatrix(int length, string name)
        {
            _matrix = new float[length, length];
            Name = name;
        }

        public static implicit operator string (SquareMatrix matrix)
        {
            float max, min;

            max = matrix.FindMax();
            min = matrix.FindMin();

            return $"Матрица {matrix.Name} {matrix.Length}x{matrix.Length}. Min элемент = {min}, max элемент = {max} ";
        }

        public float this[int i, int j]
        {
            get
            {
                return _matrix[i, j];
            }

            set
            {
                _matrix[i, j] = value;
            }
        }

        public void InputMatrix()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.WriteLine($"{Name}[{i}][{j}]");
                    _matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
        }

        public void OutputMatrix()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(_matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public float SumOfDiagonal()
        {
            float product = 1;
            for (int i = 0; i < Length; i++)
                product *= _matrix[i, i];
            return product;
        }

        public void SumOfDiagonal(int parameter)
        {
            float product = 1;
            bool ifHappen = false;

            if (parameter>=0)
            {
                for (int i = 0; i+parameter < Length; i++)
                {
                    product *= _matrix[i, i+parameter];
                    ifHappen = true;
                }
            }            
            else
            {
                for (int i = 0; i - parameter < Length; i++)
                {
                    product *= _matrix[i-parameter, i];
                    ifHappen = true;
                }

            }

            if (!ifHappen)
                Console.WriteLine("Некорректно указан параметр. Невозможно произвести вычисления.");
            else
                Console.WriteLine($"Произведение элементов диагонали равна {product}");
            
        }

        public float FindMax()
        {
            float max = _matrix[0,0];
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (_matrix[i,j] >= max)
                        max = _matrix[i,j];
                }
            }
            return max;
        }
        public float FindMin()
        {
            float min = _matrix[0, 0];
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (_matrix[i, j] <= min)
                        min = _matrix[i, j];
                }
            }
            return min;
        }

        public bool CheckIfEqual()
        {
            bool temp=true;

            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (_matrix[i, j] != 0)
                    {
                        temp = false;
                        break;
                    }
                        
                }
            }

            return temp;
        }

        public void MultipleMainDiagonal()
        {
            for (int i = 0; i < Length; i++)
            {
                if (_matrix[i, i] > 0)
                    _matrix[i, i] *= 2;
            }
        }

        public static SquareMatrix operator -(SquareMatrix firstMatrix, SquareMatrix secondMatrix)
        {
            SquareMatrix finalMatrix = new SquareMatrix(firstMatrix.Length, $"{firstMatrix.Name}-{secondMatrix.Name}");
            for (int i = 0; i < finalMatrix.Length; i++)
            {
                for (int j = 0; j < finalMatrix.Length; j++)
                {
                    finalMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                }
            }
            return finalMatrix;
        }
    }
}
