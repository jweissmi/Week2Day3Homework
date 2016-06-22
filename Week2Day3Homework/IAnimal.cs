using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3Homework
{
    public interface IAnimal
    {
        string Species { get; set; }
        string ExternalCovering { get; set; }
        string Name { get; set; }
    }
}
