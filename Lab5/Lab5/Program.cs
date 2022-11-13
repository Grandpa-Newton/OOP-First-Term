using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mainArray = new string[4]; 

            Console.WriteLine("Введите ФИО тестируемого (Фамилия Имя Отчество):");
            mainArray[0] = Console.ReadLine();

            Console.WriteLine("Введите домашний адрес: Домашний адрес; XXXXXX (индекс) ");
            mainArray[1] = Console.ReadLine();

            Console.WriteLine("Введите ваш mail-адрес: text@text.text");
            mainArray[2] = Console.ReadLine();

            Console.WriteLine("Введите ваш номер телефона: +xxx(xx)xxx-xx-xx");
            mainArray[3] = Console.ReadLine();

            string verification = @"[А-Я][a-я]+\s[А-Я][а-я]+\s[А-Я][а-я]+";

            if (Regex.IsMatch(mainArray[0],verification))
                Console.WriteLine("ФИО заполнены корректно.");
            else
                Console.WriteLine("ФИО заполнены некорректно.");

            int postcodeIndex = mainArray[1].LastIndexOf(";");
            string postcode = mainArray[1].Substring(postcodeIndex + 2);

            verification = @"\d{6}";

            if(Regex.IsMatch(postcode,verification))
                Console.WriteLine("Почтовый индекс заполнен верно.");
            else
                Console.WriteLine("Почтовый индекс заполнен неверно.");

            verification = @"\S+\@[a-z]+\.[a-z]+";

            if (Regex.IsMatch(mainArray[2],verification))
                Console.WriteLine("e-mail адрес заполнен верно.");
            else
                Console.WriteLine("e-mail адрес заполнен неверно.");

            verification = @"\+[0-9]{3}\([0-9]{2}\)[0-9]{3}-[0-9]{2}-[0-9]{2}";

            if (Regex.IsMatch(mainArray[3],verification))
                Console.WriteLine("Номер телефона заполнен верно.");
            else
                Console.WriteLine("Номер телефона заполнен неверно.");
        }
    }
}
