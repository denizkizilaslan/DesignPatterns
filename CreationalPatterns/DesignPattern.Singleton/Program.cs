using DesignPattern.Singleton.Models;
using System;
using System.Collections.Generic;

namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello Singleton Design Pattern ");
            Console.WriteLine("İlgili nesneden sadece bir instance üretmek istiyorsak kullanırız");
            Console.WriteLine("Singleton DP' de nesne hiç kullanılmayacak olasa bile bir adet instance oluşur.");
            Console.WriteLine("Kullanacağımız nesneleri, nesnenin ihtiyaç anından çok önce yaratır ve bekletirsek bu duruma Eager Loading denir");
            Console.WriteLine("Kullandığınız senaryoda bu durum performans kaybına neden oluyorsa çözüm;");
            Console.WriteLine("ilk ihtiyaç anýında oluşturmak ve sonraki ihtiyaçlarda aynı nesneyi kullanmaktır");
            Console.WriteLine("Double Checked Locking ile çift taraflı kontrol etmeyi unutmuyoruz.\n\n\n");


            List<int> referenceAddress = new List<int>();
            DbContext singleton = DbContext.GetContextInstance();
            DbContext singletonTwo = DbContext.GetContextInstance();

            referenceAddress.Add(singleton.GetHashCode());
            referenceAddress.Add(singletonTwo.GetHashCode());

            Console.WriteLine($"It is Instance referance address: {singleton.GetHashCode()}");
            Console.WriteLine($"It is Instance referance address: {singletonTwo.GetHashCode()}");

            Console.WriteLine($"Eşittir : {singleton.GetHashCode() == singletonTwo.GetHashCode()}");
            Console.WriteLine($"Equals  : {singleton.GetHashCode().Equals(singletonTwo.GetHashCode())}");

            Console.ReadLine();
        }
    }
}
