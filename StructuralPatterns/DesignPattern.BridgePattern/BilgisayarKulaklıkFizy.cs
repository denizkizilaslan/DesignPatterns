using DesignPattern.BridgePattern.Bridge;
using DesignPattern.BridgePattern.Models.Abstract;
using DesignPattern.BridgePattern.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BridgePattern
{
    public class BilgisayarKulaklıkFizy : MuzikCalabilenBilgisayar
    {
        public BilgisayarKulaklıkFizy()
        {
            sesCihazi = new Kulaklik();
            muzikCalar = new Fizy();

        }

        void MuzikCal(Muzik muzik)
        {
            Console.WriteLine("Bilgisayar çalıştı");
            super.muzikCal(muzik);
        }
    }
}
