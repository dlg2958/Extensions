using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public static class Extension
    {
        public static string Left(this string name, int length)
        {
            if (name == null)
                return null;
            int stringLength = name.Length;
            if (length >= stringLength)
                return name;
            return name.Substring(0, length);
        }
        public static string Right(this string name, int length)
        {
            if (name == null)
                return null;
            int stringLength = name.Length;
            if (length >= stringLength)
                return name;
            return name.Substring(stringLength - length, length);
        }
        public static string ZipCode(this int zip)
        {
            string zipCode = zip.ToString();
            if (zipCode == null)
                return null;
            while (zipCode.Length < 5)
                zipCode = ("0" + zipCode);
            return zipCode.Right(5);
        }
    }
    public class ExtensionTutorial
    {
        public ExtensionTutorial()
        {
            string empty = null;
            empty.Left(4);
            int zip = 123456;
            string zipCode = zip.ZipCode();
            Console.WriteLine(zipCode);
            zip = 123;
            zipCode = zip.ZipCode();
            Console.WriteLine(zipCode);

            var name = "Bob Dust";
            var firstName = name.Left(3);
            var lastName = name.Right(4);
            Console.WriteLine($"Name: {name}\t\tFirstName: {firstName}");
            Console.WriteLine($"LastName: {lastName}");
        }
    }
}
