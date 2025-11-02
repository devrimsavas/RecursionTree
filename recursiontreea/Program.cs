using System;
using System.Numerics;
using recursiontreea.models;
using Raylib_cs;
using R = Raylib_cs.Raylib;

namespace recursiontreea.models
{
    internal class Program
    {
        public static InitWindow window = new InitWindow();

        public static void Main(string[] args)
        {
            window.CreateWindow();
            CreateTree createTree = new CreateTree();
            int maxDepth = 15;
            float[] variations = new float[maxDepth + 1];
            Random rnd = new Random();

            for (int i = 0; i <= maxDepth; i++)
                variations[i] = (float)(rnd.NextDouble() * 0f - 0.91f);

            while (!R.WindowShouldClose())
            {
                R.BeginDrawing();
                R.ClearBackground(Color.Black);

                Vector2 root = new(window.ScreenWidth / 2f, window.ScreenHeight + 91f);
                createTree.DrawTree(root, 350f, -MathF.PI / 2f, maxDepth, variations);

                R.EndDrawing();
            }

            R.CloseWindow();
        }
    }
}
