using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Candy
    {
        public string Name;
        public double Cost;
        public ProducerClass Producer;
        //public string Type;

        //public Candy(string name, double cost, string producerName, string producerCountry, string type )
        public Candy(string name, double cost, string producerName, string producerCountry)
        {
            Name = name;
            Cost = cost;
            Producer = new ProducerClass(producerName, producerCountry);
            //Type = type;
        }
        public class ProducerClass
        {
            public string Name;
            public string Country;

            public ProducerClass(string name, string country)
            {
                this.Name = name;
                this.Country = country;
            }
        }

      
    }
}
