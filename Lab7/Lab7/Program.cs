using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candy[] candies =
            {
                new Caramel("Malibu",5,"Malibu","Russia"),
                new Caramel("Ledenets s myatoy",2,"Spartak","Belarus"),
                new Caramel("Barbaris",2,"Spartak","Belarus"),
                new Chocolate("Snickers",9,"Mars","Russia"),
                new Chocolate("Twix",8,"Mars","Russia"),
                new Chocolate("Bounty",9,"Mars","Russia"),
                new Chocolate("Muesli",1,"Spartak","Belarus"),
                new Toffee("Vanyckers",4,"Ivan Prod.","Zimbabwe"),
                new Toffee("Letuchka",12,"Mathematica","Belarus"),
                new Caramel("Harryk Potter",4,"IP 'Ronald Wisley'","Great Britain"),
            };

            bool isFounded;
            int numberOfProducers = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < i; j++)
                {
                    if (candies[i].Producer.Name == candies[j].Producer.Name)
                    {
                        isFounded = true;
                    }
                }
                if (!isFounded)
                    numberOfProducers++;
            }

            Console.WriteLine("Количество производителей равно " + numberOfProducers);

            string[] producers = new string[numberOfProducers];
            producers[0] = candies[0].Producer.Name;

            int indexOfProducers = 1;

            

            for (int i = 1; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < producers.Length; j++)
                {
                    if (candies[i].Producer.Name == producers[j])
                    {
                        isFounded = true;
                        break;
                    }
                }
                if(!isFounded)
                {
                    producers[indexOfProducers]=candies[i].Producer.Name;
                    indexOfProducers++;
                }
            }

            /*Console.WriteLine("СПИСОК ПРОИЗВОДИТЕЛЕЙ");

            for (int i = 0; i < producers.Length; i++)
            {
                Console.WriteLine(producers[i]);
            }*/

            double sum; 
            int numberOfCandies;

            for (int i = 0; i < producers.Length; i++)
            {
                sum = 0;
                numberOfCandies = 0;
                for (int j = 0; j < candies.Length; j++)
                {
                    if (producers[i] == candies[j].Producer.Name)
                    {
                        numberOfCandies++;
                        sum += candies[j].Cost;
                    }
                }
                Console.WriteLine($"Средняя цена конфет производителя {producers[i]} равна {sum/numberOfCandies}");
            }

            /*for (int i = 0; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < i; j++)
                {
                    if (candies[i].ToString() == candies[j].ToString())
                    {
                        isFounded = true;
                    }
                }
                if (!isFounded)
                    numberOfProducers++;
            }*/

            int numberOfClasses = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < i; j++)
                {
                    if (candies[i].GetType() == candies[j].GetType())
                        isFounded = true;
                }
                if (!isFounded)
                    numberOfClasses++;
            }

            //Console.WriteLine(numberOfClasses);

            Type[] classes = new Type[numberOfClasses];
            classes[0] = candies[0].GetType();

            int indexOfClasses = 1;


            for (int i = 1; i < candies.Length; i++)
            {
                isFounded = false;
                for (int j = 0; j < classes.Length; j++)
                {
                    if (candies[i].GetType() == classes[j])
                    {
                        isFounded = true;
                        break;
                    }
                }
                if (!isFounded)
                {
                    classes[indexOfClasses] = candies[i].GetType();
                    indexOfClasses++;
                }
            }
           

            for (int i = 0; i < classes.Length; i++)
            {
                sum = 0;
                numberOfCandies = 0;
                for (int j = 0; j < candies.Length; j++)
                {
                    if (classes[i] == candies[j].GetType())
                    {
                        numberOfCandies++;
                        sum += candies[j].Cost;
                    }
                }
                Console.WriteLine($"Средняя цена конфет {classes[i].ToString().Substring(classes[i].ToString().LastIndexOf(".")+1)} равна {sum / numberOfCandies}");
            }


            Console.ReadLine();
        }
    }
}
