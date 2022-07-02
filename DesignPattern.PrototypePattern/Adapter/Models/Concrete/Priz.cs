using Adapter.Models.Abstract;
using System;

namespace Adapter.Models.Concrete
{
    class Priz
    {
        public void eveltrikVer(IElektrikliEvAletleri elektrikliEvAletleri)
        {
            int volt = elektrikliEvAletleri.prizeTakVeCalistir();
            Console.WriteLine(volt);
        }
    }
}
