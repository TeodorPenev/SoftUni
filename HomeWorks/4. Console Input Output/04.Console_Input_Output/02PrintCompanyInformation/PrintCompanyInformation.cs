using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name : ");
        string cName = Console.ReadLine();
        Console.Write("Company address : ");
        string cAddress = Console.ReadLine();
        Console.Write("Phone number : ");
        string pNumber = Console.ReadLine();
        Console.Write("Fax number : ");
        string fNumber = Console.ReadLine();
        if (fNumber == "")
        {
            fNumber = "(no fax)";
        }
        Console.Write("Web site : ");
        string wSite = Console.ReadLine();
        Console.Write("Manager first name : ");
        string mFirstName = Console.ReadLine();
        Console.Write("Manager last name : ");
        string mlastName = Console.ReadLine();
        Console.Write("Manager age : ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone : ");
        string mPhone = Console.ReadLine();
        Console.WriteLine("{0} \n Adress: {1} \n Tel. {2} \n Fax: {3} \n Web site: {4} \n Manager : {5} (age : {6}, tel. {7})", cName, cAddress, pNumber, fNumber, wSite, mFirstName, mlastName, age, mPhone);
    }
}

