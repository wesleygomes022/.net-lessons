using System;
using TestProj.Model.Enums;

namespace TestProj.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
