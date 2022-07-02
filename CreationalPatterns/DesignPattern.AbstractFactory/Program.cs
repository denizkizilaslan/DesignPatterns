using DesignPattern.AbstractFactory.Abstract;
using DesignPattern.AbstractFactory.Factory;
using DesignPattern.AbstractFactory.Utils;
using System;

namespace DesignPattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilişkisel olan birden fazla nesnenin üretimini ortak bir arayüz aracılığıyla tek bir sınıf üzerinden yapılacak bir talep ile gerçekleştirmek");
            Console.WriteLine("Nesne üretim anında istemcinin üretilen nesneye olan bağımlılığını sıfıra indirmeyi hedeflemektedir.");
            Console.WriteLine("İlişkisel olan birden fazla nesnenin üretimini tek bir arayüz tarafından değil her ürün ailesi için farklı bir arayüz tanımlayarak sağlamaktadır.");
            Console.WriteLine("Birden fazla ürün ailesi ile çalışmak zorunda kaldığımız durumlarda, istemciyi bu yapılardan soyutlamak için kullanılır.");
            Console.WriteLine("Clienttan yapılacak talepte bağımlılığı ortadan kaldırmak hedeflenir");

            Console.WriteLine("Abstract Factory paterni, farklı nesne aileleri ile çalışan bir istemcide,istemcinin nesnelerin üretiminden haberdar / sorumlu olmaması istenildiği durumlarda kullanılır.");
            Console.WriteLine("İstemci nesneleri bir abstract class(factory) aracılığı ile yaratır.\n");
            Console.WriteLine("Paternin uygulanmasında temel olarak 5 kısım vardır;\n");
            Console.WriteLine("1-: AbstractFactory => Soyut ürünler yaratan işlemler için bir arayüz bildirir.(DBFactory)");
            Console.WriteLine("2-: ConcreteFactory => Somut ürün oluşturma işlemlerini yürütür.(SQLFactory, OracleFactory)");
            Console.WriteLine("3-: AbstractProduct => Ürün nesnesinin tipi için arayüz bildirir.(Command, Connection)");
            Console.WriteLine("4-: Product => ConcreteFactory tarafından oluşturulacak taban nesnesini tanımlar.(SQLCommand, SQLConnection, OracleCommand, OracleConnection)");
            Console.WriteLine("5-: Client => AbstractFactory ve AbstractProduct sınıfları tarafından bildirilen arayüzleri kullanır.(Programcs)");
     

            DBFactory db = FactoryUtil.GetFactory("SQL");
            Connection con = db.CreateConnection();
            con.Connect();
            Command cmd = db.CreateCommand();
            cmd.Query = "select * from table";
            cmd.Execute();

            db = FactoryUtil.GetFactory("Oracle");
            con = db.CreateConnection();
            con.Connect();
            cmd = db.CreateCommand();
            cmd.Query = "select * from table";
            cmd.Execute();

            Console.ReadKey();

        }
    }
}
