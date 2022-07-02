using DesignPattern.BuilderPattern.Abstract.Builder;
using DesignPattern.BuilderPattern.Models;

namespace DesignPattern.BuilderPattern.Concrete.Builder
{
    class BMWConcreteBuilder : ICarBuilder
    {
        public BMWConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetKM() => car.KM = 25;
        public override void SetBrand() => car.Brand = "BMW";
        public override void SetModel() => car.Model = "X Bilmem Kaç";
        public override void SetGear() => car.Gear = true;
    }
}
