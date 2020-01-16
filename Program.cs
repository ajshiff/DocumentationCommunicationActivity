using System;

namespace DocumentationCommunicationActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tests Go Here
            string value = "joshandseththebest";
            string expectedEncodedValue = "mrvkdqgvhwkwkhehvw";
            CaesarShift myTestClass = new CaesarShift(value);
            string encodedValue = myTestClass.EncodedValue;

            // Log Initial Values
            Console.WriteLine(value);
            Console.WriteLine(encodedValue);
            
            // Tests Caesar Shift accuracy with known answer
            Console.WriteLine(encodedValue == expectedEncodedValue);
            // Tests Encode Functionality
            Console.WriteLine(myTestClass.CaesarShiftEncode(value) == encodedValue);
            // Tests Decode Functionality
            Console.WriteLine(myTestClass.CaesarShiftDecode(encodedValue) == value);


        }
    }
}
