/* Name: Colin Weatherly
 * Date: 2/11/22
 * File: Grizzly.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Practice
{
    class Grizzly : Bear
    {
        void Bear.maul()
        {
            Console.WriteLine("It killed something. Hopefully not a person.");
        }

        void Bear.hibernate()
        {
            Console.WriteLine("It hibernated for the winter. Hopefully not after having killed a person.");
        }
    }
}
