using System.Security.Cryptography;
using System.Text;
using PasswordGenerator;
using System.Linq;
using System.Collections.Generic;

try
{
    do
    {
        Console.WriteLine("Welcome to my Password Generator App.");
        Console.WriteLine("_____________________________________\n");
        Console.Write("Enter the length you want the password to be: - ");
        int length = Convert.ToInt32(Console.ReadLine());


        if (length >= 7)
        {
            Console.WriteLine($"Your password is: {Generator.GeneratePassword(length)}");
        }
        else if(length < 7)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Password length is too short. In order to get a stronger" +
                " password, length has to be higher than seven.");
            Console.ResetColor();
        }
        Console.WriteLine("\nDo you want to generate a new password? - ( Yes = Y / No = N ).\n");
    } while (Console.ReadLine().ToUpper() == "Y");
    Console.WriteLine("\nSee you next time!");
    Console.ReadLine();
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Value entered was not in the correct format. Length must be an integer.");
    Console.ResetColor();
    Console.WriteLine("\nPress enter to exit the application.");
    Console.ReadLine();   
}
