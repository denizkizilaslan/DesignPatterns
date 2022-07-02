namespace DesignPattern.PrototypePattern.Models
{
    public class Game : PrototypeGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GameType { get; set; }
        public bool Status { get; set; }

        public Game(int ıd, string name, string gameType, bool status)
        {
            this.Id = ıd;
            this.Name = name;
            this.GameType = gameType;
            this.Status = status;
        }

        public override PrototypeGame Clone()
        {
            return this.MemberwiseClone() as PrototypeGame;
            //MemberwiseClone metodu ile bir kopyası oluşturularak “PrototypeOyun” tipinde geri gönderilmektedir
        }
    }
}
