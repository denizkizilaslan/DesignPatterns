using DesignPattern.BridgePattern.Bridge;
using DesignPattern.BridgePattern.Models.Abstract;
using System;

namespace DesignPattern.BridgePattern.Models.Concrete
{
    public class Spotify : IMuzikCalar
    {
        public string MuzikCal(Muzik muzik)
        {
            Console.WriteLine($"Spotify {muzik} çalıyor.");
            return muzik.getAdi();
        }
    }
}
