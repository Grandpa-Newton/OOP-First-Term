using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mainString;
            Console.WriteLine("Введите исходный HTML-код");
            mainString = Console.ReadLine();

            StringBuilder[] sb = new StringBuilder[3];
        
            sb[0] = new StringBuilder(GetSubstring("<html>", mainString));
            sb[1] = new StringBuilder(GetSubstring("<form>", mainString));
            sb[2] = new StringBuilder(GetSubstring("<h1>", mainString));

            Console.WriteLine(sb[0]);
            Console.WriteLine(sb[1]);
            Console.WriteLine(sb[2]);
           // salam<html> <form> <h1> asalama hello </h1> <input button> </form> aga <p> hello </p> </html>

        }

        static string GetSubstring(string tag, string mainString)
        {
            int firstIndex = mainString.IndexOf(tag);
            int secondIndex = mainString.IndexOf(tag.Insert(1, "/"));

            return mainString.Substring(firstIndex, secondIndex - firstIndex + tag.Length + 1);
        }
    }
}
