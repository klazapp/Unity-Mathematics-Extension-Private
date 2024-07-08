using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace com.Klazapp.Utility
{
    public static partial class mathExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float angle(float3 from, float3 to)
        {
            return math.degrees(math.acos(math.clamp(math.dot(math.normalize(from), math.normalize(to)), -1f, 1f)));
        }

        private const float EPSILON = 0.001f;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool approximately(float a, float b)
        {
            // If a or b is zero, compare that the other is less or equal to epsilon.
            // If neither a or b are 0, then find an epsilon that is good for
            // comparing numbers at the maximum magnitude of a and b.
            // Floating points have about 7 significant digits, so
            // 1.000001f can be represented while 1.0000001f is rounded to zero,
            // thus we could use an epsilon of 0.000001f for comparing values close to 1.
            // We multiply this epsilon by the biggest magnitude of a and b.
            return math.abs(b - a) < math.max(0.000001f * math.max(math.abs(a), math.abs(b)), math.EPSILON * 8);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AreEqual(float3 a, float3 b, float tolerance = 0.0001f)
        {
            return math.abs(a.x - b.x) < tolerance &&
                   math.abs(a.y - b.y) < tolerance &&
                   math.abs(a.z - b.z) < tolerance;
        }
    }
}
