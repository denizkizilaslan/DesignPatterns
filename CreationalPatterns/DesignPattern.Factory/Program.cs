using DesignPattern.Factory.Models;
using System;

namespace DesignPattern.Factory
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Factory Design Pattern, nesne yaratma işlemi için bir arayüz tasarlanmasını gerektirir");
            Console.WriteLine("Alt sınıfların nesne üretmesine olanak sağlar");
            Console.WriteLine("Ayrıca, hangi sınıf nesnesinin oluşacağını da alt sınıflar kendileri belirler.Böylece nesne yaratma işlemini soyutlaştırır");
            Console.WriteLine("Birden fazla loglama türü olabilir, Her case için kontrol gerekir.Buda liskov prensibini ihlal eder.Koda sürekli müdahale gerekir ve clean code a aykırı olur");
            Console.WriteLine("Bunun çözümü olarak Abstract Factory Design kalıbı doğmuştur.");

          DateTime lastLog = DateTime.Now;

            while (true)
            {
                if (lastLog <= DateTime.Now)
                {
                    var result = $"Important work mas done at {DateTime.Now}";
                    var logger = LoggerFactory.CreateLogger(LoggerType.Console);
                    logger.Log(result);


                    var loggerFile = LoggerFactory.CreateLogger(LoggerType.File);
                    loggerFile.Log(result);

                    lastLog = DateTime.Now.AddSeconds(3);

                }
            }
        }
    }
}
