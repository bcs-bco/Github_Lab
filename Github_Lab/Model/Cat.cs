using System;
using System.Collections.Generic;
using System.Text;

namespace Github_Lab.Model
{
    public class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Walk By Legs");
        }
    }
}
