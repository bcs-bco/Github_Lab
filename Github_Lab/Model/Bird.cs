using System;
using System.Collections.Generic;
using System.Text;

namespace Github_Lab.Model
{
    public class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Fly with wings");
        }
    }
}
