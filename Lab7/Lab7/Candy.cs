﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Candy
    {
        public string Name;
        public int Cost;
        private Producer producer;
        public string Type;

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
    }
}