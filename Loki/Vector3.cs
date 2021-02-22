using System;

namespace Loki
{
    public struct Vector3
    {
        public float X;
        public float Y;
        public float Z;
        public override string ToString() => $"({X},{Y},{Z})";

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float Length() => (float)Math.Sqrt((double)X * X + Y * Y + Z * Z);

        public void Normalise(float length = 1.0f) => Scale(length / Length());

        public void Scale(float factor)
        {
            X *= factor;
            Y *= factor;
            Z *= factor;
        }
    }
}
