using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var LastName = "Hamedani";

            var fullName = firstName + " " + LastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, LastName);

            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);
            
            //verbatim strings
            var text = @"Hi john
Look into the following paths
c:\\folder1\\folder2
c:\\folder3\\folder4";
            Console.WriteLine(text);



        }
    }
}
