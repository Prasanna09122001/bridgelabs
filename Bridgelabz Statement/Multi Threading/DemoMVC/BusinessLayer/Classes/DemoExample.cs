using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class DemoExample : IDemoExample
    {
        public int Add()
        {
            int a = 10, b = 20;
            int c = a + b;
            return c;
        }
        public int Sub()
        {
            int a = 20, b = 10;
            int c = a - b;
            return c;
        }
    }
}
