using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    internal class Reptile
    {
        public bool IsVenomous { get; set; }

        public Reptile()
        {
            Console.WriteLine("Hello this is Reptile Class");
        }

        public Reptile(bool isVenomous)
        {
            IsVenomous = isVenomous;
        }

        
    }
}
