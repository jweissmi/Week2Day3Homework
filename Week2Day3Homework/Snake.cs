using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3Homework
{
    public class Snake : Reptile
    {
        public Snake()
        {
        }
        public Snake(int avgWeight)
        {
            AvgWeight = avgWeight;
        }
        public override int AvgWeight { get; set; }

        public bool IsVenomous = true;
    }
}
