using DesignPattern.AbstractFactory.Abstract;
using System;

namespace DesignPattern.AbstractFactory.Concrete
{
    public class SQLCommand : Command
    {
        public override string Query { get => query; set => query = value; }

        public override void Execute()
        {
            Console.WriteLine("T-SQL worked");
        }
    }
}
