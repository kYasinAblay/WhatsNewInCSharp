﻿using System;

namespace LiteralImprovements
{

    public class LiteralImprovements
    {
        static void MainLI(string[] args)
        {
            int a = 123_321;
            int b = 123_321______123;

            // cannot do trailing
            //int c = 1_2_3___; // R# remove

            // also works for hex
            long h = 0xAB_BC_D123EF;

            // also binay
            var bin = 0b1110_0010_0011;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
