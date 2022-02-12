/* Name: Colin Weatherly
 * Date: 2/11/22
 * File: Program.cs
 * IDE: Visual Studio 2019
 */

using System;

namespace Adapter_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear Griz = new Grizzly();
            ToyBear Teddy = new TeddyBear();
            ToyBear ActuallyAlive = new BearAdapter(Griz);

            Console.WriteLine("Grizzly functions:\n");
            Griz.maul();
            Griz.hibernate();

            Console.WriteLine("\nTeddy Bear functions:\n");
            Teddy.hug();

            Console.WriteLine("\nBearAdapter functions:\n");
            ActuallyAlive.hug();
        }
    }
}
