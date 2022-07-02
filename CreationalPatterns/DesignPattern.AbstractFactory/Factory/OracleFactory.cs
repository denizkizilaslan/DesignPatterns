using DesignPattern.AbstractFactory.Abstract;
using DesignPattern.AbstractFactory.Concrete;

namespace DesignPattern.AbstractFactory.Factory
{
    public class OracleFactory : DBFactory
    {
        public override Command CreateCommand()
        {
            return new OracleCommand();
        }

        public override Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
