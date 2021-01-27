using System;
using System.Collections.Generic;
using System.Text;

namespace Github_Lab.Model
{
    public abstract class Animal : IMovable
    {
        public string Name { get; set; }

        public abstract void Move();
       
    }
}
