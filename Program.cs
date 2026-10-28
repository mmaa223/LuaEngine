using System;
using System.Numerics;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;


namespace Core;



class Program
{
    static void Main()
    {

        GameWindow window = new GameWindow();
        window.Init(600, 600, "hello");
        window.Run();
        
    }
}