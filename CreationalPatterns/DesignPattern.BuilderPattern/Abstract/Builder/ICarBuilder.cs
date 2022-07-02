using DesignPattern.BuilderPattern.Models;

namespace DesignPattern.BuilderPattern.Abstract.Builder
{
    abstract class ICarBuilder
    {
        protected Car car;
        public Car Car
        {
            get { return car; }
        }

        public abstract void SetBrand();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetGear();
    }
}
