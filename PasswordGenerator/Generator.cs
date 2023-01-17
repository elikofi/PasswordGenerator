using System;
using System.Security.Cryptography;
using System.Text;


namespace PasswordGenerator
{
    public class Generator
    {

        public static string GeneratePassword(int length)
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
}

