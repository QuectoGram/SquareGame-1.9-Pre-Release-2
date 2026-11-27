using System;
using System.IO;
using Raylib_cs;
using YamlDotNet.Serialization;
namespace SquareGame;
public sealed class SettingsConfig
{
    public string SquareColor { get; set; } = "GRAY";
}
internal static class Program
{
    private static void Main()
    {
        var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
        var config = deserializer.Deserialize<SettingsConfig>(File.ReadAllText("settings.yml")) ?? new SettingsConfig();
        string colorStr = config.SquareColor ?? "GRAY";
        Color squareColor = colorStr switch
        {
            "RED" => Color.Red,
            "BLUE" => Color.Blue,
            "BLACK" => Color.Black,
            "GREEN" => Color.Green,
            "ORANGE" => Color.Orange,
            _ => Color.Gray
        };
        Console.WriteLine("Welcome to SquareGame 1.9 a game made by U123573");
        Raylib.InitWindow(1300, 1000, "SquareGame 2.0 Pre-Release 1");
        Raylib.SetTargetFPS(65);
        float x = 650f;
        float y = 450f;
        float speed = 5.0f;
        while (!Raylib.WindowShouldClose())
        {
            if (Raylib.IsKeyDown(KeyboardKey.A)) x -= speed;
            if (Raylib.IsKeyDown(KeyboardKey.D)) x += speed;
            if (Raylib.IsKeyDown(KeyboardKey.W)) y -= speed;
            if (Raylib.IsKeyDown(KeyboardKey.S)) y += speed;
            if (Raylib.IsKeyDown(KeyboardKey.Left)) x -= speed;
            if (Raylib.IsKeyDown(KeyboardKey.Right)) x += speed;
            if (Raylib.IsKeyDown(KeyboardKey.Up)) y -= speed;
            if (Raylib.IsKeyDown(KeyboardKey.Down)) y += speed;
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RayWhite);
            Raylib.DrawRectangle((int)x, (int)y, 150, 150, squareColor);
            Raylib.DrawText("SQUARE", (int)x, (int)y, 35, Color.Black);
            Raylib.DrawText("SquareGame 1.9 PreRel 2", 500, 150, 50, Color.Black);
            Raylib.DrawText("MBU1", 15, 15, 40, Color.Black);
            Raylib.DrawText("WDRC++", 15, 65, 40, Color.Black);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}
