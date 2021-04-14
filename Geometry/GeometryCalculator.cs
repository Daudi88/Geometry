using System;

namespace Geometry
{
    public class GeometryCalculator
    {
        public float GetPerimiters(GeometricThing[] things)
        {
            if (things == null) return 0;
            var sum = 0.0f;
            foreach (var thing in things)
            {
                sum += thing.Perimiter();
            }
            return sum;
        }

        public float GetAreas(GeometricThing[] things)
        {
            if (things == null) return 0;
            var sum = 0.0f;
            foreach (var thing in things)
            {
                sum += thing.Area();
            }
            return sum;
        }
    }
}
