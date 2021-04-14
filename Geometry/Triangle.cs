using System;

namespace Geometry
{
    public class Triangle : GeometricThing
    {
        public float Base { get; set; }
        public float Height { get; set; }

        public override float Area()
        {
            if (Base <= 0 || Height <= 0) return 0;
            return Base * Height / 2;
        }

        public override float Perimiter()
        {
            if (Base <= 0) return 0;
            return Base * 3;
        }
    }
}
