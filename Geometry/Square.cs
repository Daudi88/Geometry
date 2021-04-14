using System;

namespace Geometry
{
    public class Square : GeometricThing
    {
        public float Side { get; set; }

        public override float Area()
        {
            if (Side <= 0) return 0;
            return (float)Math.Pow(Side, 2);
        }

        public override float Perimiter()
        {
            if (Side <= 0) return 0;
            return Side * 4;
        }
    }
}
