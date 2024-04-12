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

            // Set Window Background Color

            // Game Loop
            while (!Raylib.WindowShouldClose())
            {
                // Update
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                Raylib.DrawText("Hello, World!", 10, 10, 20, Color.Black);
                Raylib.EndDrawing();
            }

            // Close Window
            Raylib.CloseWindow();
        }
    }
}
