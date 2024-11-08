// A given company has name, address, phone number, fax number, web 
// site and manager. The manager has name, surname and phone number.
// Write a program that reads information about the company and its 
// manager and then prints it on the console.

class CompanyInfo
{
    static void Main()
    {
        string cName, cAddress, website, mName, mSurname;
        ulong cPhoneNum, cFaxNum, mPhoneNum;
        bool isUlong;

        Console.WriteLine("Program to read info about a company and " +
        "its manager and prints it on the console.");
        Console.Write("Company name: ");
        cName = Console.ReadLine();
        Console.Write("Company address: ");
        cAddress = Console.ReadLine();
        Console.Write("Website: ");
        website = Console.ReadLine();
        Console.Write("Company's phone number: ");
        isUlong = ulong.TryParse(Console.ReadLine(), out cPhoneNum);
        Console.Write(isUlong ? "" : "Invalid phone number\n");
        Console.Write("Company's fax number: ");
        isUlong = ulong.TryParse(Console.ReadLine(), out cFaxNum);
        Console.Write(isUlong ? "" : "Invalid fax number\n");
        Console.Write("Manager first name: ");
        mName = Console.ReadLine();
        Console.Write("Manager surname: ");
        mSurname = Console.ReadLine();
        Console.Write("Manager's phone number: ");
        isUlong = ulong.TryParse(Console.ReadLine(), out mPhoneNum);
        Console.Write(isUlong ? "" : "Invalid phone number\n");

        Console.WriteLine($"{"Company name",20} : {cName}");
        Console.WriteLine($"{"Company address",20} : {cAddress}");
        Console.WriteLine($"{"Website",20} : {website}");
        Console.WriteLine($"{"Company phone number", 20} : {cPhoneNum:+91 #### ### ###}");
        Console.WriteLine($"{"Company fax number",20} : {cFaxNum:(###)-###-####}");
        Console.WriteLine($"{"Manager name",20} : {mName} {mSurname}");
        Console.WriteLine($"{"Manager phone number",20} : {mPhoneNum:+91 #### ### ###}");
    }
}