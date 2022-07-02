using DesignPattern.AbstractFactory.Abstract;

namespace DesignPattern.AbstractFactory.Factory
{
    public abstract class DBFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
