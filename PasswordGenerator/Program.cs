using System.Security.Cryptography;
using System.Text;

do
{
    try
    {
        Console.WriteLine("Enter the length you want the password to be: ");
        int length = Convert.ToInt32(Console.ReadLine());


        if (length > 0)
        {
            Console.WriteLine(GeneratePassword(length));
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter a valid input.");
            Console.ResetColor();
        }
        Console.ReadLine();


        //method

        static string GeneratePassword(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "1234567890" +
                "@$!%&*+_";

            StringBuilder builder = new StringBuilder();

            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = RandomNumberGenerator.GetInt32(chars.Length);

                builder.Append(chars[index]);
            }
            return builder.ToString();
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter a valid input (number).");
        Console.ReadLine();
        Console.ResetColor();
    }
    Console.WriteLine("Do you want to generate a new password? ( Yes = Y / No = N ).");
} while (Console.ReadLine().ToUpper() == "Y");