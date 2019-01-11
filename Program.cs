﻿using System;

namespace play_with_passing_value_type_params
{
    class Program
    {
        static void ChangeMadroNannana(int x, int y)
        {
            x+=10;
            y+=10;
        }

        static void ChangeMadroNannanaIn(in int x, in int y)
        {
            x=10;
            y=20;
        } // In ReadOnly - Can't Update Like x=10, y=20
        public static void P(dynamic msg) => Console.WriteLine(msg);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x=1,y=1;
            ChangeMadroNannana(x,y);
            P("X = "+x);
            P("Y = "+y);
        }
    }
}
