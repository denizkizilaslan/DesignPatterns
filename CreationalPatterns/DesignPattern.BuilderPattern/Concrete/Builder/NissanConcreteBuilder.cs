using DesignPattern.BuilderPattern.Abstract.Builder;
using DesignPattern.BuilderPattern.Models;


namespace DesignPattern.BuilderPattern.Concrete.Builder
{
    class NissanConcreteBuilder : ICarBuilder
    {
        public NissanConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetKM() => car.KM = 150;
        public override void SetBrand() => car.Brand = "Nissan";
        public override void SetModel() => car.Model = "Juke";
        public override void SetGear() => car.Gear = true;
    }
}
