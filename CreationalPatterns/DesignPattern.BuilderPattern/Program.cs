using DesignPattern.BuilderPattern.Abstract.Builder;
using DesignPattern.BuilderPattern.Concrete;
using DesignPattern.BuilderPattern.Concrete.Builder;
using System;

namespace DesignPattern.BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder deseni, karmaşık yapıdaki nesnelerin oluşturulmasında,istemcinin sadece nesne tipini belirterek üretimi gerçekleştirebilmesini sağlamak için kullanılmaktadır");

            Console.WriteLine("Projemiz inşa süresindeyken oluşturacağımız bazı nesnelerin üretimleri oldukça maliyetli olabilir, zamanla bu nesnelerin yapısı değişebilir yahut güncellenebilir.Anlayacağınız nesne üzerinde her türlü dinamik süreç yaşanabilir.İşte bu tarz inşa durumlarında Builder D.P.ile ilgili nesneler genişletilebilir bir hale getirilmekte ve en önemlisi kod karmaşalığı minimize edilmektedir.");
            Console.WriteLine("Product : İnşa sonucunda elde etmek istediğimiz nesnemizdir");
            Console.WriteLine("ConcreteBuilder : Nesneyi oluşturmaktadır. Oluşturulacak  Nesnenin temel özellik ve donanımını sağlayan sınıftır.");
            Console.WriteLine("Builder : Nesnesinin oluşturulması için gerekli arayüzü sağlar.");
            Console.WriteLine("Director : Yaptığımız tasarım sonucunda bir Builder referansı üzerinden Client tarafından nesne üretim talebine cevap verir.");



            ICarBuilder car = new NissanConcreteBuilder();
            ProduceCar producer = new ProduceCar();
            producer.Produce(car);

            Console.WriteLine(car.Car.ToString());

            car = new BMWConcreteBuilder();
            producer.Produce(car);
            Console.WriteLine(car.Car.ToString());


            car = new OpelConcreteBuilder();
            producer.Produce(car);
            Console.WriteLine(car.Car.ToString());

            Console.Read();



            Console.WriteLine("Hello World!");
        }
    }
}
