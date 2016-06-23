using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3Homework
{
    public class Dog : Mammal
    {
        public Dog()
        {
        }
        public Dog(string dogBreed)
        {
            DogBreed = dogBreed;
        }
        public string DogBreed { get; set; }
        public override int NumLegs()
        {
            return 4;
        }
        public override int AvgNumOffspring()
        {
            return 6;
        }
    }
}

