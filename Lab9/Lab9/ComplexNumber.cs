using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class ComplexNumber
    {
        private double real;
        private double imagine;

        public ComplexNumber(double re, double im)
        {
            real = re;
            imagine = im;
        }

        public static ComplexNumber operator +(ComplexNumber firstValue, ComplexNumber secondValue)
        {
            return new ComplexNumber(firstValue.real + secondValue.real, firstValue.imagine + secondValue.imagine);
        }

        public static ComplexNumber operator *(ComplexNumber firstValue, ComplexNumber secondValue)
        {
            return new ComplexNumber(firstValue.real * secondValue.real - firstValue.imagine * secondValue.imagine, firstValue.real * secondValue.imagine + secondValue.real * firstValue.imagine);
        }

        // (x1+iy1)*(x2+iy2)=(x1*x2-y1*y2)+i(x1*y2+x2*y1)

        public string OutputComplex()
        {
            if (imagine > 0)
                return($"{real}+{imagine}i");
            else
                return($"{real}{imagine}i");
        }
    }
}
