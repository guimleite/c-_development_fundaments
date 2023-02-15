using System;
using System.Security;
using System.Text;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Bethany";
            string anotherName = "name";

            name += " Smith";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Another name: " + anotherName);

            string lowerCaseName = name.ToLower();

            string indexes = string.Empty;
            for (int i = 0; i < 2500; i++)
            {
                indexes += i.ToString();
            }

            string firstName = "Bethany";
            string lastName = "Smith";

            StringBuilder builder = new StringBuilder();

            builder.Append("Last name: ");
            builder.AppendLine(lastName);
            builder.Append("Firts name: ");
            builder.Append(firstName);
            string result = builder.ToString();

            Console.WriteLine(result);
        }
    }
}
