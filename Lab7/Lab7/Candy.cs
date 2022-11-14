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
        private Producer producer;
        public string Type;

        public Candy(string name, double cost, string producerName, string producerCountry, string type )
        {
            Name = name;
            Cost = cost;
            producer = new Producer(producerName, producerCountry);
            Type = type;
        }
        private class Producer
        {
            private string name;
            private string country;

            public Producer(string name, string country)
            {
                this.name = name;
                this.country = country;
            }
        }

      /*  public string GetProducerName()
        {
            return producer.name;
        }*/
    }
}
