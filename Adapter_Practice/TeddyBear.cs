/* Name: Colin Weatherly
 * Date: 2/11/22
 * File: TeddyBear.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Practice
{
    class TeddyBear : ToyBear
    {
        void ToyBear.hug()
        {
            Console.WriteLine("You have the Teddy Bear hug you. Thank god it can't kill you.");
        }
    }
}
