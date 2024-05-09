using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace com.Klazapp.Utility
{
    public static partial class mathExtension
    {
        [Serializable]
        public struct decimal2
        {
            public decimal x;
            public decimal y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public decimal2(decimal x, decimal y)
            {
                this.x = x;
                this.y = y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static decimal2 operator +(decimal2 a, decimal2 b)
            {
                return new decimal2(a.x + b.x, a.y + b.y);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static decimal2 operator -(decimal2 a, decimal2 b)
            {
                return new decimal2(a.x - b.x, a.y - b.y);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static decimal2 operator *(decimal2 a, decimal2 b)
            {
                return new decimal2(a.x * b.x, a.y * b.y);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static decimal2 operator /(decimal2 a, decimal2 b)
            {
                return new decimal2(a.x / b.x, a.y / b.y);
            }
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static decimal2 FromString(string xStr, string yStr)
            {
                if (decimal.TryParse(xStr, NumberStyles.Number, CultureInfo.InvariantCulture, out var x) &&
                    decimal.TryParse(yStr, NumberStyles.Number, CultureInfo.InvariantCulture, out var y))
                {
                    return new decimal2(x, y);
                }
                
                throw new ArgumentException("Invalid input strings. Cannot convert to decimal.");
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override string ToString()
            {
                return $"({x}, {y})";
            }
        }
    }
}