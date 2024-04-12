using System;
using System.Net.Http;
using Raylib_cs;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init Raylib game window
            Raylib.InitWindow(800, 600, "Raylib C# Example");

            bool buttonClicked = false;
            var myColor = Color.White;

            // Set Window Background Color
            Raylib.ClearBackground(myColor);

            // Create Button Object -> Rectangle
            Rectangle button = new Rectangle(10, 10, 100, 50);

            // Game Loop
            while (!Raylib.WindowShouldClose())
            {
                // Update
                Raylib.BeginDrawing();
                Raylib.ClearBackground(myColor);

                // Button Logic
                if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), button))
                {
                    if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                    {

                        buttonClicked = true;
                    }
                }


                Raylib.DrawText("Hello, World!", 10, 10, 20, Color.Black);
                Raylib.EndDrawing();
            }

            // Close Window
            Raylib.CloseWindow();
        }
    }
}
