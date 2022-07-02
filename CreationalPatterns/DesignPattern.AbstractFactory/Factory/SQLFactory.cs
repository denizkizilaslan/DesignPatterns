using DesignPattern.AbstractFactory.Abstract;
using DesignPattern.AbstractFactory.Concrete;

namespace DesignPattern.AbstractFactory.Factory
{
    public class SQLFactory : DBFactory
    {
        public override Command CreateCommand()
        {
            return new SQLCommand();
        }

        public override Connection CreateConnection()
        {
            return new SQLConnection();
        }
    }
}
