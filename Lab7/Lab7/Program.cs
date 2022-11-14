using System;
using System.Collections.Generic;
using System.Linq;
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
                new Caramel("Malibu",5,"Malibu","Russia","Caramel"),
                new Caramel("Ledenets s myatoy",2,"Spartak","Belarus","Caramel"),
                new Caramel("Barbaris",2,"Spartak","Belarus","Caramel"),
                new Chocolate("Snickers",9,"Mars","Russia","Chocolate"),
                new Chocolate("Twix",8,"Mars","Russia","Chocolate"),
                new Chocolate("Bounty",9,"Mars","Russia","Chocolate"),
                new Chocolate("Muesli",1,"Spartak","Belarus","Chocolate"),
                new Toffee("Vanyckers",4,"Ivan Prod.","Zimbabwe","Toffee"),
                new Toffee("Letuchka",12,"Mathematica","Belarus","Toffee"),
                new Caramel("Harryk Potter",4,"IP 'Ronald Wisley'","Great Britain","Caramel");
            }
        }
    }
}
