using System;

namespace Geometry
{
    public class Rectangle : GeometricThing
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public override float Area()
        {
            if (Height <= 0 || Width <= 0) return 0;
            return Height * Width;
        }

        public override float Perimiter()
        {
            if (Height <= 0 || Width <= 0) return 0;
            return (Height + Width) * 2;
        }
    }
}
