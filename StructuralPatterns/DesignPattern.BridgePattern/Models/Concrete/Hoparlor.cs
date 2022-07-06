using DesignPattern.BridgePattern.Models.Abstract;
using System;

namespace DesignPattern.BridgePattern.Models.Concrete
{
    public class Hoparlor : ISesCihazi
    {
        public void sesCal(string ses)
        {
            Console.WriteLine($"Kulaklık {ses} çalıyor");
        }
    }
}
