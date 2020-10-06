using System;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);

            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);

            System.Console.WriteLine(method.ToString());

            // using WriteLine automatically uses the ToString method
            System.Console.WriteLine(method);
            // so the above two WriteLines produce the same result

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
