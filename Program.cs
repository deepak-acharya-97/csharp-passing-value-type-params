using System;

namespace play_with_passing_value_type_params
{
    class Program
    {
        public static void P(dynamic msg) => Console.WriteLine(msg);

        static void ChangeMadroNannana(int x, int y)
        {
            x += 10;
            y += 10;
        }

        static void ChangeMadroNannanaOut(out int x, out int y)
        {
            //P(x) ---> Error
            //x+=10 ---> Error No Read Possible before Initialization
            x = 10;
            y = 20;
            P(x);
        } // Out - Although we can pass intialized variables out params need not have to be inilialized unlike ref. So if we pass the intialized params also out params treats it as unassigned. That's why we can't read them before intializing inside function scope
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 1, y = 1;
            ChangeMadroNannana(x, y);
            P("X = " + x);
            P("Y = " + y);

            ChangeMadroNannanaOut(out x, out y);
            P("X = " + x);
            P("Y = " + y);

            //Output

            // $ dotnet run
            // Hello World!
            // X = 1
            // Y = 1
            // 1
            // X = 10
            // Y = 20
        }
    }
}
