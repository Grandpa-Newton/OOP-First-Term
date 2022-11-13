using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Workshop[] workByDays = new Workshop[3];

            Random random = new Random();

            int[] tempArray = new int[Enum.GetValues(typeof(Work)).Length];

            for (int i = 0; i < workByDays.Length; i++)
            {
                for (int j = 0; j < Enum.GetValues(typeof(Work)).Length; j++)
                {
                    tempArray[j] = random.Next(1, 10);
                }
                workByDays[i]=new Workshop(tempArray);
            }
            double sum = 0, count =0 ;

            int firstDay = 0, secondDay = 0 ;

            while (true)
            {
                Console.WriteLine("МЕНЮ");

                Console.WriteLine("0. Вывод выполненных работ за каждый день.");
                Console.WriteLine("1. Вывод количества заказов за период.");
                Console.WriteLine("2. Найти среднее количество работ в день по видам заказов.");
                Console.WriteLine("3. Найти наиболее востребованный вид работ за период.");
                Console.WriteLine("4. ВЫХОД");

                int choiceMenu=Convert.ToInt32(Console.ReadLine());

                switch (choiceMenu)
                {
                    case 0:
                        for (int i = 0; i < workByDays.Length; i++)
                        {
                            Console.WriteLine($"ДЕНЬ {i+1}");
                            for (int j = 0; j < Enum.GetValues(typeof(Work)).Length; j++)
                            {
                                Console.Write(Enum.GetNames(typeof(Work)).GetValue(j) + ":");
                                Console.WriteLine((int)workByDays[i].NumberOfWork[j]);
                            }
                        }
                        break;

                    case 1:
                        Console.WriteLine("Укажите первое значение дня.");
                        firstDay = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Укажите второе значение дня.");
                        secondDay = Convert.ToInt32(Console.ReadLine());
                        // добавить проверку, что sec>first + что не выходит за рамки

                        sum = 0;
                        for (int i = firstDay-1; i < secondDay; i++)
                        {
                            for (int j = 0; j < Enum.GetValues(typeof(Work)).Length; j++)
                            {
                                sum += (int)workByDays[i].NumberOfWork[j];
                            }
                        }

                        Console.WriteLine($"Количество выполненных заказов за период = {sum}");

                        break;

                    case 2:

                        for (int i = 0; i < Enum.GetValues(typeof(Work)).Length; i++)
                        {
                            sum = GetNumberOfWorksByDays(i, workByDays);
                            Console.WriteLine(Enum.GetNames(typeof(Work)).GetValue(i) + " за день = " + sum / Enum.GetValues(typeof(Work)).Length);
                        }

                        break;
                    case 3:
                        Console.WriteLine("Укажите первое значение дня.");
                        firstDay = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Укажите второе значение дня.");
                        secondDay = Convert.ToInt32(Console.ReadLine());

                        int max = 0, index=0;
                        for (int i = firstDay-1; i < secondDay; i++)
                        {
                            max += (int)workByDays[i].NumberOfWork[0];
                        }

                        int tempMax = 0;

                        for (int i = 1; i < workByDays.Length; i++)
                        {
                            tempMax = 0;
                            for (int j = firstDay-1; j < secondDay; j++)
                            {
                                tempMax += (int)workByDays[j].NumberOfWork[i];
                            }
                            if (tempMax>max)
                            {
                                index = i;
                                max = tempMax;
                            }
                        }

                        Console.WriteLine("Самый востребованный вид работ - " + Enum.GetNames(typeof(Work)).GetValue(index) + " с количеством = " + max);

                       
                        break;
                    case 4:
                        return;
                        

                    default:
                        break;
                }
            }

        }
        static int GetNumberOfWorksByDays(int index, Workshop[] workByDays)
        {
            int sum=0;
            for (int j = 0; j < workByDays.Length; j++)
            {
                sum += (int)workByDays[j].NumberOfWork[index];
            }

            return sum;
  
        }
    }

    /*public class Workshop
    {
        static private int enumWorkCount = Enum.GetNames(typeof(Work)).Length;
        public Work[] NumberOfWork = new Work[enumWorkCount];
        public Workshop(int[] numberOfWork)
        {
            for (int i=0; i<numberOfWork.Length;i++)
            {
                this.NumberOfWork[i] = (Work)numberOfWork[i];                
            }
        }
    }*/

    public enum Work
    {
        Expansion,
        Repair,
        Replacement,
    }
}

/* Workshop[] numberByDays =
             {
                 new Workshop(),
                 new Workshop(),
                 new Workshop(),
             };*/

/* for (int i = 0; i < 3; i++)
 {
     for (int j = 0; j < Enum.GetValues(typeof(Workshop)).Length; j++)
     {

     }
 }*/

//new Workshop[Enum.GetValues(typeof(Workshop)).Length];