using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Caramel : Candy
    {
        //public Caramel(string name, double cost, string producerName, string producerCountry,string type) : base(name, cost, producerName,producerCountry,type)
        public Caramel(string name, double cost, string producerName, string producerCountry) : base(name, cost, producerName, producerCountry)
        {

        }
    }
}
