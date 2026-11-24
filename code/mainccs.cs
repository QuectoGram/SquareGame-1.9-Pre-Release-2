using System;
using System.Collections.Generic;
using System.IO;
using Raylib_cs;
using YamlDotNet.Serialization;
var deserializer = new DeserializerBuilder().Build();
var config = deserializer.Deserialize<Dictionary<string, string>>(File.ReadAllText("settings.yml"));
string colorStr = config["SquareColor"];
Color squareColor = Color.Gray;
if (colorStr == "RED") squareColor = Color.Red;
else if (colorStr == "BLUE") squareColor = Color.Blue;
else if (colorStr == "BLACK") squareColor = Color.Black;
else if (colorStr == "GREEN") squareColor = Color.Green;
else if (colorStr == "ORANGE") squareColor = Color.Orange;
Console.WriteLine("Welcome to SquareGame 1.9 a game made by U123573");
Raylib.InitWindow(1300, 1000, "SquareGame 2.0 Pre-Release 1");
Raylib.SetTargetFPS(65);
float x = 650;
float y = 450;
float speed = 5.0f;
while (!Raylib.WindowShouldClose())
{
    if (Raylib.IsKeyDown(KeyboardKey.A) || Raylib.IsKeyDown(KeyboardKey.Left)) x -= speed;
    if (Raylib.IsKeyDown(KeyboardKey.D) || Raylib.IsKeyDown(KeyboardKey.Right)) x += speed;
    if (Raylib.IsKeyDown(KeyboardKey.W) || Raylib.IsKeyDown(KeyboardKey.Up)) y -= speed;
    if (Raylib.IsKeyDown(KeyboardKey.S) || Raylib.IsKeyDown(KeyboardKey.Down)) y += speed;
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
return 0;
