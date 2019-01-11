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

        static void ChangeMadroNannanaRef(ref int x, ref int y)
        {
            P(x);
            x = 10;
            y = 20;
        } // Ref *Read and Write* - Read/Write Permission
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 1, y = 1;
            ChangeMadroNannana(x, y);
            P("X = " + x);
            P("Y = " + y);

            ChangeMadroNannanaRef(ref x, ref y);
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
