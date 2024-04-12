using System;
using System.Collections.Generic;
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

            // Create List of plot points
            var points = new List<Point>();

            // Loop through this code 10 times
            // increasing the value of i by 1 each time
            // starting at 0 and ending at 9
            for(int i = 0; i < 10; i++)
            {
                points.Add(new Point
                {
                    X = i * 10,
                    Y = i * 10
                });
            }

            // Game Loop
            while (!Raylib.WindowShouldClose())
            {
                // Update
                Raylib.BeginDrawing();
                Raylib.ClearBackground(myColor);

                // Button Logic
                // If Mouse is in button rectangle bounds is true
                if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), button))
                {
                    // If Mouse Left Button is Pressed evaluates as true
                    if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                    {
                        // Change Background Color
                        myColor = Color.Red;

                        // Set buttonClicked to true
                        buttonClicked = true;
                    }
                }

                Raylib.DrawRectangleRec(button, Color.Gray);

                Raylib.DrawText("Hello, World!", 10, 10, 20, Color.Black);
                Raylib.EndDrawing();
            }

            // Close Window
            Raylib.CloseWindow();
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
