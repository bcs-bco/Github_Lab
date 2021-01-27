using System;
using System.Collections.Generic;
using System.Text;

namespace Github_Lab.Model
{
    public class Fish : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Fish Swim!");
        }
    }
}
