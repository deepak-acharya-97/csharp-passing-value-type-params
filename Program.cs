using System;

namespace play_with_passing_value_type_params
{
    class Program
    {
        static void ChangeMadroNannana(int x, int y)
        {
            x+=10;
            y+=10;
        }

        static void ChangeMadroNannanaOut(out int x, out int y)
        {
            x=10;
            y=20;
        } // Out *Update* - all out params needs to be updated before control leaves the function
        public static void P(dynamic msg) => Console.WriteLine(msg);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x=1,y=1;
            ChangeMadroNannana(x,y);
            P("X = "+x);
            P("Y = "+y);

            ChangeMadroNannanaOut(out x,out y);
            P("X = "+x);
            P("Y = "+y);

            //Output

            // $ dotnet run
            // Hello World!
            // X = 1
            // Y = 1
            // X = 10
            // Y = 20

        }
    }
}
