using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    internal class Snake
    {
        public string Color { get; set; }

        public Snake(string color) { 
            Color = color;
        
        }

        public void SnakeColor()
        {
            Console.WriteLine("The color of the snake is " +Color);
        }
    }
}
