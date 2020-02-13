using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SpaceTrader
{
    public class Location : IEquatable<Location>
    {
        public double x { get; set; }

        public double y { get; set; }

        public bool Equals([AllowNull] Location other)
        {
            return this.x == other.x && this.y == other.y;
        }
    }
}