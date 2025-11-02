using System;
using System.Numerics;
using Raylib_cs;
using R = Raylib_cs.Raylib;

namespace recursiontreea.models
{
    public class CreateTree
    {
        public void DrawTree(Vector2 start, float length, float angle, int depth, float[] variations)
        {
            if (depth <= 0) return;

            Vector2 end = new(
                start.X + length * MathF.Cos(angle),
                start.Y + length * MathF.Sin(angle)
            );

            float thickness = MathF.Max(1f, depth * 0.31f);
            int colorIndex = Math.Clamp(depth, 0, ColorPalette.AllColors.Length - 1);
            R.DrawLineEx(start, end, thickness, ColorPalette.AllColors[colorIndex]);

            float newLen = length * 0.76f;
            float variation = variations[depth];
            float newAngleLeft = angle - (0.5f + variation);
            float newAngleRight = angle + (0.5f + variation);

            DrawTree(end, newLen, newAngleLeft+variation/10, depth - 1, variations);
            DrawTree(end, newLen, newAngleRight + variation / 8, depth - 1, variations);
            
        }
        
    }
}