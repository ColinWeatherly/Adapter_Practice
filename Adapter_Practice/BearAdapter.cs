using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Practice
{
    public class BearAdapter : ToyBear
    {
        Bear adaptee;

        public BearAdapter(Bear bear)
        {
            adaptee = bear;
        }

        void ToyBear.hug()
        {
            adaptee.maul();
        }
    }
}
