using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Day3Homework;

namespace Week2Day3Homework
{
    public abstract class Reptile : IAnimal
    {
        public string Species { get; set; }
        public string ExternalCovering { get; set; }
        public abstract int AvgWeight { get; set; }
        public string Name { get; set; }
    }
}
