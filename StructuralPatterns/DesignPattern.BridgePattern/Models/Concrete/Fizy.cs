using DesignPattern.BridgePattern.Bridge;
using DesignPattern.BridgePattern.Models.Abstract;
using System;

namespace DesignPattern.BridgePattern.Models.Concrete
{
    public class Fizy : IMuzikCalar
    {
        public string MuzikCal(Muzik muzik)
        {
            Console.WriteLine($"Fizy {muzik} çalıyor.");
            return muzik.getAdi();
        }
    }
}
