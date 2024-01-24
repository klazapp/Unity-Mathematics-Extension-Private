using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace com.Klazapp.Utility
{
    public static partial class mathExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 lerp(Color32 start, Color32 end, float progress)
        {
            var startFloat4 = new float4(start.r / 255f, start.g / 255f, start.b / 255f, start.a / 255f);
            var endFloat4 = new float4(end.r / 255f, end.g / 255f, end.b / 255f, end.a / 255f);

            var lerpResult = Unity.Mathematics.math.lerp(startFloat4, endFloat4, progress);

            return new Color32(
                (byte)(lerpResult.x * 255),
                (byte)(lerpResult.y * 255),
                (byte)(lerpResult.z * 255),
                (byte)(lerpResult.w * 255)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color lerp(Color start, Color end, float progress)
        {
            var startFloat4 = new float4(start.r, start.g, start.b, start.a);
            var endFloat4 = new float4(end.r, end.g, end.b, end.a);

            var lerpResult = Unity.Mathematics.math.lerp(startFloat4, endFloat4, progress);

            return new Color(lerpResult.x, lerpResult.y, lerpResult.z, lerpResult.w);
        }
    }
}
