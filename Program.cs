using System;
// See https://aka.ms/new-console-template for more information
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail =2,
    Express =3
}

class Program
{
    static void Main(string[] args)
    {
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId);
        Console.WriteLine(method.ToString());
        var methodName = "Express";


        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        var number = new int[3];
        number[0] = 1;

        Console.WriteLine(number[0]);
        Console.WriteLine(number[1]);
        Console.WriteLine(number[2]);

        var firstName = "Mosh";

        var lastName = "john";

        var fullNAme = firstName + " " + lastName;

        var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
        var names = new string[3] { "John", "Jack", "Mary" };
        var formattedNames = string.Join(",", names);

        Console.WriteLine(formattedNames);
        Console.WriteLine(names[2]);
        Console.WriteLine(myFullName);

        var text = "Hi john\nlook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
        Console.WriteLine(text);

        var texta = @"Hi john
look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
        Console.WriteLine(texta);
    }
}
