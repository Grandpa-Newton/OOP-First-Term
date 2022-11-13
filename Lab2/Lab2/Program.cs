using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber firstComplex = InputComplex();

            ComplexNumber secondComplex = InputComplex();

            Console.Write("Первое введённое число в комплексном виде: ");
            firstComplex.OutputComplex();

            Console.WriteLine();

            Console.Write("Второе введённое число в комплексном виде: ");
            secondComplex.OutputComplex();

            Console.WriteLine();

            Console.Write("Сумма двух чисел в комплексном виде: ");
            ComplexNumber complexSum = firstComplex + secondComplex;
            complexSum.OutputComplex();

            Console.WriteLine();
            Console.Write("Произведение двух чисел в комплексном виде: ");
            ComplexNumber complexMultiplication = firstComplex * secondComplex;


            complexMultiplication.OutputComplex();

            Console.ReadLine();
        }
        static public ComplexNumber InputComplex()
        {
            double re, im;

            Console.WriteLine("Введите действительную часть комплексного числа.");
            re = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите мнимую часть комлпексного числа.");
            im = Convert.ToDouble(Console.ReadLine());

            return new ComplexNumber(re, im);
        }
    }
}
