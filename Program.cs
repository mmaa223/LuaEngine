using System;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Linq;

class Lexer()
{
    private string[] lines;
    public struct Token(string kind, int value)
    {
        string Kind = kind;
        int Value = value;
    }

    public void Begin()
    {   

        try
        {
            lines = File.ReadAllLines("main.lua");
            Console.WriteLine(lines);
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
    
    
}



class Program
{
    static void Main()
    {

        Lexer lexer = new Lexer();
        lexer.Begin();
        
    }
}