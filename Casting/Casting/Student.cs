using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    internal class Student:Human
    {
        public int Point { get; set; }
        public override void Show()
        {
            Console.WriteLine($"{FullName} - {Age} - {Point}");
        }
    }
}
