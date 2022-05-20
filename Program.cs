

// C# program to illustrate the
// concept of inheritance
using System;
namespace ConsoleApplication1
{
    //An abstract does do anything within itself
    public abstract class Customer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public abstract void FullName();
    }
    // Inheriting class from the base that uses the methods and variables from the abstract class
    class Program: Customer
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            p.FirstName = "Monica";
            p.LastName = "Iyabo";
            p.FullName();
            Console.ReadLine();

        }
        public override void FullName()
        {
            Console.WriteLine("Full Name:" + FirstName + " " + LastName);
        }
    }

    public sealed class Employee
    {
        string firstName;
        string lastName;
    }
    class Program1 : Employee
    {
        static void Main(string[] args)
        {

        }
    }


}

