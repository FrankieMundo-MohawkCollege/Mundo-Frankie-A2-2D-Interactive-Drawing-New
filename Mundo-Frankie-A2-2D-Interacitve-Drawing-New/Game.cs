// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color White = new Color(255, 255, 255);
        Color Red = new Color(255, 0, 0);


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Frankie Mundo - Interactive 2D A2");
            Window.SetSize(600, 800);
            Window.TargetFPS = 60;
        }

       
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(White);
            DrawHeart();

        }

        void DrawHeart()
        {
            Draw.LineSize = 0;
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.Red;
            Draw.Circle(200, 400, 55);

            Draw.LineSize = 0;
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.Red;
            Draw.Rectangle(145, 400, 110, 150);

            Draw.LineSize = 0;
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.Red;
            Draw.Rectangle(200, 400, 100, 150); 
            
        }
    }
}


