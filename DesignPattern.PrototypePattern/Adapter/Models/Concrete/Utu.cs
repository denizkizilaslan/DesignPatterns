using Adapter.Models.Abstract;
using System;

namespace Adapter.Models.Concrete
{
    class Utu : IElektrikliEvAletleri
    {
        private int volt;
        public Utu()
        {
            this.volt = 220;
        }
        public int prizeTakVeCalistir()
        {
            Console.WriteLine("Ütü çalışıyor");
            return volt;
        }
    }
}
