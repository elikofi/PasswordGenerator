using System.Security.Cryptography;
using System.Text;
using PasswordGenerator;
using System.Linq;
using System.Collections.Generic;

try
{
    do
    {
        Console.WriteLine("Enter the length you want the password to be: ");
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
        Console.ReadLine();
        Console.WriteLine("Do you want to generate a new password? - ( Yes = Y / No = N ).");
    } while (Console.ReadLine().ToUpper() == "Y");
    
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Value entered was not in the correct format. Length must be an integer.");
    Console.ReadLine();
    Console.ResetColor();
}
