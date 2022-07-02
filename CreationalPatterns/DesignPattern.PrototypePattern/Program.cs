using DesignPattern.PrototypePattern.Models;
using System;

namespace DesignPattern.PrototypePattern
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(@"Tasarım deseni yaklaşımlarından Prototype Design Pattern sayesinde elimizdeki mevcut nesnelerin prototiplerini oluşturabilmekte,
            birnevi bu nesnelerin kopyalarını elde edebilmekteyiz.Prototip deseninin tasarlanmasının asıl sebebi, ilgili nesne üzerinden
            aynı tipte başka bir nesneyi hızlıca üretebilmektir.Haliyle üretimi esnasında maliyetli olabilecek
            nesneleri(ki burada maliyetten kasıt, parametreli constructer vs.olabilir)
            var olan nesne üzerinden “new” anahtar sözcüğünü kullanmadan bir şekilde oluşturulmasını sağlayabilmektedir.");


            Console.WriteLine(@"   Biliyoruz ki, Shallow Copy ve Deep Copy olmak üzere iki tür nesne kopyalama işlemi mevcuttur. 
            Shallow Copy ile nesnelerin bellekteki adresleri kopyalanmakta dolayısıyla yüzeysel olarak bir kopyalama
            işlemi gerçekleştirileceği için yeni bir nesne üretilmemekte, var olan nesne üzerine referanslar ile
            işaretleme yapılmaktadır. Anlayacağınız Shallow Copy, Prototype Design Pattern için uygun tercih olmayacaktır.
            Lakin Deep Copy ile nesneler birebir kopyalanabilmekte ve bu kopya sonucu ile asıl nesne farklı referanslar ile
            işaretlenebilmektedir. İşte Prototype Design Pattern’de bu kopyalama yaklaşımında bulunmak en doğrusudur.");

            Console.WriteLine(@"Prototype Design Pattern’de üç temel yapı bulunmaktadır. Bu yapılara aşağıda değinilmiştir.
            Soyut Sınıf
            Yeni nesnelerin kopyalanmasını sağlayan ve bu işlem için Clone metodunu barındıran bir sınıftır. abstract class yahut interface olarak tasarlanabilir.
            Somut Prototip Nesneleri
            Soyut sınıfı uygulayacak olan ve projede herhangi bir amaç için kullanılacak olan nesnelerdir. Yani Prototype Design Pattern’i uygulayacağımız projedeki sınıflarımızdır.
            İstemci(Client) Uygulama
            Bunu talebi oluşturacak ve deseni kullanacak katman olarak tanımlayabiliriz.");


            Console.WriteLine(@"En son Client(İstemci) tarafından bir talep gerçekleştirilmiştir. Gördüğünüz gibi ikinci nesneyi new keywordü ile oluşturmaya kalkmayarak maliyeti göz ardı edip, var olan nesne üzerinden kopyalama işlemi gerçekleştirebiliyoruz. Burada dikkat etmeniz gereken husus, Prototype tasarım desenini uygulayabilmek için ilgili sınıftan öncelikle new keywordü ile bir nesne üretilmeli, ardından desenimiz üzerinden kopya üretimi tetiklenmelidir.");

            Game game = new Game(3, "Deniz Kızılaslan", "Savaş", true);
            Game gameCopy = (Game)game.Clone();

            int referensValueGame = game.GetHashCode();

            int referensValueGameCopy = gameCopy.GetHashCode();

            Console.WriteLine($"Referans Adress Game: {referensValueGame}");
            Console.WriteLine($"Referans Adress GameCopy: {referensValueGameCopy}");


            if (game == gameCopy)
            {
                Console.WriteLine("Referans Değerleri Eşit");
            }
            else
            {
                Console.WriteLine("Referans Değerleri Eşit Değil");
            }

            Console.ReadLine();
        }
    }
}
