using Adapter.Models.Adapter;
using Adapter.Models.Concrete;
using System;

namespace Adapter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Mesela servisten xml veri alıyorum diğer servise json gönderiyorum burada kullanabilirim.");
            Priz priz = new Priz();

            Utu utu = new Utu();
            Buzdolabi buzdolabi = new Buzdolabi();


            priz.eveltrikVer(utu);
            priz.eveltrikVer(buzdolabi);


            SamsungTelefon telefon = new SamsungTelefon();


            TelefonElektirkliEvAletidapter adapter = new TelefonElektirkliEvAletidapter(telefon);
            adapter.prizeTakVeCalistir();


            Console.ReadLine();
        }
    }
}
