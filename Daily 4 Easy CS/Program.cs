using System;


namespace Daily_4_Easy_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Password af = new Password();
            Console.WriteLine(af.randonPassword());

            // Suspend the console.
            Console.ReadKey();
        }
    }
}
