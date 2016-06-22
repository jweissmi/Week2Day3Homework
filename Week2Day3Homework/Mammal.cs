using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Day3Homework;

namespace Week2Day3Homework
{
    public abstract class Mammal : IAnimal
    {
        public string Species { get; set; }
        public string ExternalCovering { get; set; }
        public abstract int NumLegs();
        public abstract int AvgNumOffspring();
        public string Name { get; set; }
    }
}
