﻿namespace DesignPattern.BuilderPattern.Models
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public bool Gear { get; set; }
        public override string ToString()
        {
            return $"{Brand} marka araba {Model} modelinde {KM} kilometrede {Gear} vites olarak üretilmiştir.";
        }
    }
}
