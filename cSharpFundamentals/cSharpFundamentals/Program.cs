using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpFundamentals.Math;

namespace cSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var ethan = new Person();

            ethan.FirstName = "Ethan";
            ethan.LastName = "Franson";

            ethan.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(2, 4);
            Console.WriteLine(result);
            

        }
    }

}
