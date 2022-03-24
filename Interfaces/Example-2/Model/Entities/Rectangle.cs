using System;

namespace TestProj.Model.Entities
{
    class Rectangle : AbstractShape 
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {

            return "Rectangle color = "
                + Color
                + ", Width = "
                + Width.ToString("F2")
                + ", Height = "
                + Height.ToString("F2")
                + ", Area = "
                + Area().ToString("F2");
        }

    }
}
