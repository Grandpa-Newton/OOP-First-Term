using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber firstComplex = null;
            ComplexNumber secondComplex = null;
            
            firstComplex = InputComplex();

            if (firstComplex == null)
            {
                Console.ReadLine();
                return;
            }
                

            secondComplex = InputComplex();

            if (secondComplex == null)
            {
                Console.ReadLine();
                return;
            }
            

            Console.Write("Первое введённое число в комплексном виде: ");
            Console.WriteLine(firstComplex.OutputComplex());

            Console.WriteLine();

            Console.Write("Второе введённое число в комплексном виде: ");
            Console.WriteLine(secondComplex.OutputComplex());

            Console.WriteLine();

            Console.Write("Сумма двух чисел в комплексном виде: ");
            ComplexNumber complexSum = firstComplex + secondComplex;
            Console.WriteLine(complexSum.OutputComplex());

            Console.WriteLine();
            Console.Write("Произведение двух чисел в комплексном виде: ");
            ComplexNumber complexMultiplication = firstComplex * secondComplex;


            Console.WriteLine(complexMultiplication.OutputComplex());

            Console.ReadLine();
        }
        static public ComplexNumber InputComplex()
        {
            double re=0, im=0;

            Console.WriteLine("Введите действительную часть комплексного числа.");
            
            try
            {
                re = Convert.ToDouble(Console.ReadLine());
            }

            catch(SystemException exception)
            {
                Console.WriteLine("Некорректно введены данные.");
                return null;
            }

            Console.WriteLine("Введите мнимую часть комлпексного числа.");

            try
            {
                im = Convert.ToDouble(Console.ReadLine());
            }
            catch(SystemException exception)
            {
                Console.WriteLine("Некорректно введены данные.");
                return null;
            }

            return new ComplexNumber(re, im);
        }
    }

    public class ComplexException : Exception
    {
        public ComplexException(string message) : base (message)
        {

        }
    }
}
