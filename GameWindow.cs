using System;
using System.Numerics;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;

namespace Core;

class GameWindow()
{
    private static IWindow window;
    private static GL gL;

    public void Init(int width, int height, string title)
    {
        WindowOptions options = WindowOptions.Default with
        {
            Size = new Silk.NET.Maths.Vector2D<int>(width, height),
            Title = title
        };

        window = Window.Create(options);
        window.Load += Begin;
        window.Update += Update;
        window.Render += Draw;
    }

    public void Run()
    {
        window.Run();
    }

    public static void Begin()
    {   //тут создаётся контекст и отчищяется цвет на тот чо в систем дравинг колор и там цвета
        gL = window.CreateOpenGL();
        gL.ClearColor(System.Drawing.Color.AliceBlue);
    }
    public static void Update(double delta)
    {
        gL.Clear(ClearBufferMask.ColorBufferBit);
    }
    public static void Draw(double delta)
    {
        
    }
}