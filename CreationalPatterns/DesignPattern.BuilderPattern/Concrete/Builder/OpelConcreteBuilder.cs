using DesignPattern.BuilderPattern.Abstract.Builder;
using DesignPattern.BuilderPattern.Models;

namespace DesignPattern.BuilderPattern.Concrete.Builder
{
    class OpelConcreteBuilder : ICarBuilder
    {
        public OpelConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetKM() => car.KM = 100;
        public override void SetBrand() => car.Brand = "Opel";
        public override void SetModel() => car.Model = "Astra";
        public override void SetGear() => car.Gear = true;
    }
}
