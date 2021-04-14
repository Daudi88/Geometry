using System;

namespace Geometry
{
    public class Circle : GeometricThing
    {
        public float Radius { get; set; }

        public override float Area()
        {
            if (Radius <= 0) return 0;
            return (float)(Math.PI * Math.Pow(Radius, 2));
        }

        public override float Perimiter()
        {
            if (Radius <= 0) return 0;
            return 2 * (float)Math.PI * Radius;
        }
    }
}
