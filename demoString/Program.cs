using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoString
{
     class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Turza";
            var lastName = "Csharper";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] { "John" , "Jack" , "Chris" };

            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            //var text = "Hi Chris, \nLook into the following paths, \n\tC:\\projects\\CsharpBasic\\demoString\n\tC:\\projects\\CsharpBasic\\demoArray";
            var text = @"Hi Chris, 
Look into the following paths, 
C:\projects\CsharpBasic\demoString
C:\projects\CsharpBasic\demoArray";
            Console.WriteLine(text);
        }
    }
}
