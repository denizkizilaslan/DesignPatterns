using DesignPattern.BuilderPattern.Abstract.Builder;

namespace DesignPattern.BuilderPattern.Concrete
{
    class ProduceCar
    {
        public void Produce(ICarBuilder car)
        {
            car.SetKM();
            car.SetBrand();
            car.SetModel();
            car.SetGear();
        }
    }
}
