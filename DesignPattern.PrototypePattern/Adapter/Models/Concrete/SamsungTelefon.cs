using Adapter.Models.Abstract;
using System;

namespace Adapter.Models.Concrete
{
    class SamsungTelefon : ITelefon
    {
        private int calismaVoltaji;
        public SamsungTelefon()
        {
            calismaVoltaji = 5;
        }
        public int sarjEt()
        {
            Console.WriteLine("Samsung phone is working");
            return calismaVoltaji;
        }
    }
}
