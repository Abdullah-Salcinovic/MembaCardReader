using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string phoneNumberPattern = @"^\+?[0-9]{1,3}-?[0-9]{2,3}-?[0-9]{2,3}-?[0-9]{2,3}$";
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        string phoneNumber = "+360-3411151";
        string num1 = "060-341-1151";
        string num2 = "060-341-11-51";
        string num3 = "061-824-259";
        string email = "example@example.com";

        bool isPhoneNumberValid = Regex.IsMatch(phoneNumber, phoneNumberPattern);
        bool valid = Regex.IsMatch(num1, phoneNumberPattern);
        bool valid2 = Regex.IsMatch(num2, phoneNumberPattern);
        bool valid3 = Regex.IsMatch(num3, phoneNumberPattern);
        bool isEmailValid = Regex.IsMatch(email, emailPattern);

        Console.WriteLine($"Is phone number 1 valid? {isPhoneNumberValid}");
        Console.WriteLine($"Is phone number 2 valid? {valid}");
        Console.WriteLine($"Is phone number 3 valid? {valid2}");
        Console.WriteLine($"Is phone number 4 valid? {valid3}");
        Console.WriteLine($"Is email valid? {isEmailValid}");
    }
}