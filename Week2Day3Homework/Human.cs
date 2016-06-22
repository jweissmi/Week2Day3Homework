using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3Homework
{
    public class Human : Mammal
    {
        public Human()
        {
        }
        public Human(string hairColor)
        {
            HairColor = hairColor;
        }
        public string HairColor { get; set; }
        public override int NumLegs()
        {
            return 2;
        }
        public override int AvgNumOffspring()
        {
            return 1;
        }
    }
}