using System;

namespace Step120Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee(1) { firstName = "Sample", lastName = "Student" };

            sample.SayName();

            Console.ReadLine();
        }
    }
}
