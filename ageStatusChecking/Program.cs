using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your gender: ");
        string gender = Console.ReadLine().ToLower();
        string gend1 = "female";
        string gend2 = "male";

        while (gender != gend1 && (gender != gend2))

        {
            Console.WriteLine("Enter the correct gender: ");
            gender = Console.ReadLine().ToLower();
        }

        if (gender == gend1 && age >= 60)
        {
            Console.WriteLine("You are eligible to receive a pension.");
        }
        else if (gender == gend2 && age >= 65)
        {
            Console.WriteLine("You are eligible to receive a pension.");
        }
        else
        {
            Console.WriteLine("You are not eligible to receive a pension.");
        }

    }
}
        
         
      


       

    
