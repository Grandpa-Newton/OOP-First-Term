﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Chocolate : Candy 
    {
        public Chocolate(string name, double cost, string producerName, string producerCountry, string type) : base(name, cost, producerName, producerCountry, type)
        {

        }
    }
}