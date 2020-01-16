using System;

namespace DocumentationCommunicationActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mock Data
            string value = "joshandseththebest";
            string expectedEncodedValue = "mrvkdqgvhwkwkhehvw";
            CaesarShift myTestClass = null;
            string encodedValue = null;

            // Log Initial Values
            Console.WriteLine(value);
            Console.WriteLine(encodedValue);
            
            // Tests Go Here
            // Console Log Tests Here as Booleans. True = Pass. False == Fail.
            Console.WriteLine(true == true);
        }
    }
}