using System;

namespace Tasks
{
    class MyHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("myhello");
            string name_user;
            name_user = Console.ReadLine();
            Console.WriteLine($"Привет, {name_user}");
        }
    }
}
