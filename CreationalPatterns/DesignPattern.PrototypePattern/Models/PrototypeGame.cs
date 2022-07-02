namespace DesignPattern.PrototypePattern.Models
{
    public abstract class PrototypeGame
    {
        public abstract PrototypeGame Clone();

        /*
         “Oyun” sınıfımızı bu soyut sınıftan türettiğimiz zaman, 
        ilgili “Oyun” nesnesini Clone metodu ile kopyalayacak ve
        çok biçimlilik ile “PrototypeOyun” tipinde bir referansa atayabileceğiz.
         */
    }
}
