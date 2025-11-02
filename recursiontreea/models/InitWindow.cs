using R = Raylib_cs.Raylib;
using Raylib_cs;

namespace recursiontreea.models
{
    public class InitWindow
    {

        public int ScreenWidth { get; set; } = 1920;

        public int ScreenHeight { get; set; } = 1350;

        public Color backgroundColor { get; set; } = Color.DarkBlue;
        public int FPS { get; set; } = 144;

        public InitWindow()
        {

        }

        public void CreateWindow()
        {
            R.SetTargetFPS(FPS);
            R.InitWindow(ScreenWidth, ScreenHeight, "RecursionTree");
        }
    }

}