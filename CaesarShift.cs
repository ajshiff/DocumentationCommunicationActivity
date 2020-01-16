using System;
using System.Linq;

namespace DocumentationCommunicationActivity
{
    public class CaesarShift
    {
        private string Value {get; set;}
        public string EncodedValue {get; set;}
        public CaesarShift(string value)
        {
            Value = value;
            EncodedValue = CaesarShiftEncode(Value);
        }

        public string CaesarShiftEncode (string value)
        {
            return value.Aggregate("", (acc, letter) => acc + (char)((int)letter + 3));
        }
        public string CaesarShiftDecode (string value)
        {
            return value.Aggregate("", (acc, letter) => acc + (char)((int)letter - 3));
        }

    }
}