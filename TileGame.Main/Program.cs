using System;

namespace TileGame.Main
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var app = new AppHost();
            app.Init();
            app.Start("http://*:8080/");
            Console.WriteLine("AppHost created at port 8080");

            Console.ReadKey();
        }
    }
}