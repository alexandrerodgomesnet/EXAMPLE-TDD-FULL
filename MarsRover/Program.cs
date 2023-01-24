// See https://aka.ms/new-console-template for more information
using System;
namespace MarsRover;

class Program
{
    static void Main(string[] args)
    {
        //example command
        //.\MarsRover\bin\Debug\net7.0\MarsRover.exe 0:0:N MMMMMMLLLLRRRRRMMMML
        Console.WriteLine(new MarsRover(args[0]).Execute(args[1]));
    }
}