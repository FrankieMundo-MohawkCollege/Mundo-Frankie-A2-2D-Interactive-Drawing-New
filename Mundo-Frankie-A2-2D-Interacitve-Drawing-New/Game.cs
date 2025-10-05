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
        Color White = new Color(225, 225, 225);
        Color DarkBlue = new Color(0, 0, 139);
        Color OffWhite = new Color(250, 249, 246);
        Color DarkWhite = new Color(225, 217, 209);
        Color BloodMoon = new Color(191, 58, 85);
        Color BloodMoonDark = new Color(230, 106, 106);
        Color CurrentMoonColor = new Color(250, 249, 246);
        Color CurrentDarkMoonColor = new Color(225, 217, 209);
        bool isBloodMoon = false;
        int starX;
        int starY;


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Frankie Mundo - Interactive 2D A2");
            Window.SetSize(600, 800);
            Window.TargetFPS = 60;
            Window.ClearBackground(DarkBlue);
            for (int i = 0; i < 50; i++)
            {
                starX = Random.Integer(0, 600);
                starY = Random.Integer(0, 800);
                DrawStars();
            }

        }
         
       
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            
            DrawMoon();
            
            
            if (Input.IsKeyboardKeyReleased(KeyboardInput.Space))
            {
                
                if (isBloodMoon == false)
                {
                    CurrentMoonColor = BloodMoon;
                    CurrentDarkMoonColor = BloodMoonDark;
                    isBloodMoon = true;
                }
                else
                {
                    CurrentMoonColor = OffWhite;
                    CurrentDarkMoonColor = DarkWhite;
                    isBloodMoon = false;
                }

            }
            
        }


        void DrawStars()
        {
            Draw.LineSize = 0;
            Draw.FillColor = White;

            Draw.Circle(starX, starY, 2);
        }
        void DrawMoon()
        {
            Draw.FillColor = CurrentMoonColor;
            Draw.Circle(300, 400, 200);

            Draw.LineSize = 0;
            Draw.FillColor = CurrentDarkMoonColor;
            Draw.Circle(250, 350, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(210, 390, 30);

            Draw.LineSize = 0;
           
            Draw.Circle(257, 300, 35);

            Draw.LineSize = 0;
            
            Draw.Circle(250, 400, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(270, 450, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(250, 350, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(290, 490, 20);

            Draw.LineSize = 0;
           
            Draw.Circle(207, 250, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(250, 350, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(250, 350, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(450, 350, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(400, 490, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(428, 300, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(360, 360, 60);

            Draw.LineSize = 0;
            
            Draw.Circle(250, 560, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(360, 560, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(210, 488, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(180, 310, 20);

            Draw.LineSize = 0;
            
            Draw.Circle(140, 400, 20);
        }

        


        


      
    }   
}