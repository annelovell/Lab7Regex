using System;
using System.Text.RegularExpressions;


namespace Lab_7__Regex
{
    class Program
    {

        static void Main(string[] args)

        {
            Regex Name = new Regex(@"^([A-z]{1,30})$");
            string input1;

            Console.Write("Enter a name: ");
            input1 = Console.ReadLine();
            input1 = char.ToUpper(input1[0]) + input1.Substring(1);

            while (Name.Match(input1).Success == false)
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.Write("Enter a name: ");
                input1 = Console.ReadLine();
            }

            Console.WriteLine($"{input1} is a valid name.");

            Regex email = new Regex(@"^(\w{5,30}\@\w{5,10}\.\w{2,3})$");
            string input2;

            Console.Write("Enter an email: ");
            input2 = Console.ReadLine();

            while (email.Match(input2).Success == false)
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.Write("Enter an email: ");
                input2 = Console.ReadLine();
            }

            Console.WriteLine($"{input2} is a valid email.");

            Regex phoneNum = new Regex(@"^(\d{3}-\d{3}-\d{4})$");
            string input3;


            Console.Write("Enter a phone number: ");
            input3 = Console.ReadLine();

            while (phoneNum.Match(input3).Success == false)
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.Write("Enter a phone number: ");
                input3 = Console.ReadLine();
            }

            Console.WriteLine($"{input3} is a valid phone number.");

            Regex DateValid = new Regex(@"^[0-9]{2}\/[0-9]{2}\/[0-9]{4}$");
            string input4;

            Console.Write("Enter a Date: ");
            input4 = Console.ReadLine();

            while (DateValid.Match(input4).Success == false)
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.Write("Enter a Date: ");
                input4 = Console.ReadLine();
            }

            Console.WriteLine($"{input4} is a valid date.");




        }



    }

}
