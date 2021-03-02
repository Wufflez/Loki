using System;

namespace Loki
{
    public struct Vector2i: IEquatable<Vector2i>
    {
        public int X;
        public int Y;

        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"({X},{Y})";

        public bool Equals(Vector2i other) => X == other.X && Y == other.Y;

        public override bool Equals(object obj) => obj is Vector2i other && Equals(other);

        public override int GetHashCode() => HashCode.Combine(X, Y);

        public static bool operator ==(Vector2i left, Vector2i right) => left.Equals(right);

        public static bool operator !=(Vector2i left, Vector2i right) => !left.Equals(right);
    }
}
