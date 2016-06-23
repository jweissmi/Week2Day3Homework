using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3Homework
{
    public class Lizard : Reptile
    {
        public Lizard()
        {
        }
        public Lizard(int avgWeight)
        {
            AvgWeight = avgWeight;
        }
        public override int AvgWeight { get; set; }

        public bool IsDesertDweller = true;
    }
}
