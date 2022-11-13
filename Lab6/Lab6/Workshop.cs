using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Workshop
    {
        static private int enumWorkCount = Enum.GetNames(typeof(Work)).Length;
        public Work[] NumberOfWork = new Work[enumWorkCount];
        public Workshop(int[] numberOfWork)
        {
            for (int i = 0; i < numberOfWork.Length; i++)
            {
                this.NumberOfWork[i] = (Work)numberOfWork[i];
            }
        }
    }
}
