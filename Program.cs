

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
        private double d1;
        private double d2;

 
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
        public double Number1
        {
            get
            {
                return d1;
            }

            set
            {
                d1 = value;
            }
        }
        public double Number2
        {
            get
            {
                return d2;
            }

            set
            {
                d2 = value;
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
            p.Number1 = 12345678912345.5d;
            p.Number2 = 1.123456789123456d;
            p.FullName(); 


            Console.ReadLine();

                   }
        public override void FullName()
        {
            Console.WriteLine("Full Name:" + FirstName + " " + LastName+" "+Number1+" "+Number2);
            DateTime dt2 = new DateTime(2015, 12, 31);
            DateTime currentDateTime = DateTime.Now;
            DateTime minDateTimeValue = DateTime.MinValue;
            DateTime todaysDate = DateTime.Today; // returns today's date

            TimeSpan time = new TimeSpan(10, 5, 25, 50);
                
            Console.WriteLine(dt2+" "+ currentDateTime+"   "+ todaysDate+"   "+ minDateTimeValue+ "    "+ time);


            var str = "5/122020";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //A structure as a datatype
       
        }

    }
  
}

