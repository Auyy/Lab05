using System;
namespace Lab05
{
    public abstract class Operation
    {
        public abstract Double Execute();

        public void show()
        {
            Console.WriteLine("My astract class is Operation");
        }
    }
}

