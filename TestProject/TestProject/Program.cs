﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message();
            int num = Message();
            Console.ReadLine();
        }

        static void Message()
        {
            Console.WriteLine("Hello World");
        }
    }
}
