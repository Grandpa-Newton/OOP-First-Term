using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Toffee : Candy
    {
        //public Toffee(string name, double cost, string producerName, string producerCountry, string type) : base(name, cost, producerName, producerCountry, type)
        public Toffee(string name, double cost, string producerName, string producerCountry) : base(name, cost, producerName, producerCountry)
        {

        }
    }
}
