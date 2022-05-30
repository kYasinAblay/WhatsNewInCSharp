using System;
using System.Collections.Generic;
using System.Drawing;

namespace PatternMatchingForCsharp8
{
    public struct shape
    {

    }

    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public PhoneNumber PhoneNumber { get; set; }

    }
    public class PhoneNumber
    {
        public int Number { get; set; }
        public int Code { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                PhoneNumber = new PhoneNumber { Code = 44, Number = 0 },
            };

            //Switch-Based Validation
            var error = person switch
            {
                null => "Object missing",
                { PhoneNumber: null } => "Phone number missing entirely",
                { PhoneNumber: { Number: 0 } } => "Actual number missing",
                { PhoneNumber: { Code: var code } } when code < 0 => "What the hell?",
                { } => null //no error
            };
            if (error != null)
                throw new ArgumentException(error);




            var type = shape switch
            {
                Rectangle((0, 0), 0, 0) => "Point at origin",
                Circle((0, 0), _) => "Circle at origin",
                Rectangle(_, var w, var h) when w == h => "Square",
                Rectangle((var x, var y), var w, var h) => $"A {w}x{h} rectangle at ({x},{y})",
                _ => "something else"

            };
        }

        IEnumerable<int> GetMainOfficeNumbers()
        {
            foreach (var pn in numbers)
            {
                if (pn is ExtendedPhoneNumber { Office: "main" })
                    yield return pn.Number;
            }
        }
    }
}
