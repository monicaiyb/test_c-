using System;
public class IfExample
{
    public static void Main(string[] args)
    {
        //if else condition
        Console.WriteLine("Enter a number:");
        int num0 = Convert.ToInt32(Console.ReadLine());

        if (num0 % 2 == 0)
        {
            Console.WriteLine("It is even number");
        }
        else
        {
            Console.WriteLine("It is odd number");
        }

        //if elseif
        //hck
        Console.WriteLine("Enter a number to check grade:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0 || num > 100)
        {
            Console.WriteLine("wrong number");
        }
        else if (num >= 0 && num < 50)
        {
            Console.WriteLine("Fail");
        }
        else if (num >= 50 && num < 60)
        {
            Console.WriteLine("D Grade");
        }
        else if (num >= 60 && num < 70)
        {
            Console.WriteLine("C Grade");
        }
        else if (num >= 70 && num < 80)
        {
            Console.WriteLine("B Grade");
        }
        else if (num >= 80 && num < 90)
        {
            Console.WriteLine("A Grade");
        }
        else if (num >= 90 && num <= 100)
        {
            Console.WriteLine("A+ Grade");
        }

        //switch statement
        Console.WriteLine("Enter a number for switch statement:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        switch (num1)
        {
            case 10: Console.WriteLine("It is 10"); break;
            case 20: Console.WriteLine("It is 20"); break;
            case 30: Console.WriteLine("It is 30"); break;
            default: Console.WriteLine("Not 10, 20 or 30"); break;
        }

        //for loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //Nested for loop
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine(i + " " + j);
            }
        }

        //while loop
        int men = 1;
        while (men <= 6)
        {
            Console.WriteLine(men);
            men++;
        }

        Console.Read();

    
    }
}


