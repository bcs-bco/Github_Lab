using Github_Lab.Model;
using System;

namespace Github_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            cat.Move();

            Animal bird = new Bird();
            bird.Move();

            Console.WriteLine("Animal World!");
        }
    }
}
