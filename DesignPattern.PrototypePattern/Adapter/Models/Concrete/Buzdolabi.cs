using Adapter.Models.Abstract;
using System;

namespace Adapter.Models.Concrete
{
    class Buzdolabi : IElektrikliEvAletleri
    {
        private int volt;
        public Buzdolabi()
        {
            this.volt = 220;
        }
        public int prizeTakVeCalistir()
        {
            Console.WriteLine("The fridge is working");
            return volt;
        }
    }
}
