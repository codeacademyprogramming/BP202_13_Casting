using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    internal class Human
    {
        public string FullName { get; set; }
        public byte Age { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"{FullName} - {Age}");
        }
    }
}
