//Problem 11.	Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string holderName = ("Ivan, Petrov, Ivanov");
        decimal mBalance = 911.10M;
        string bankName = "PostBank";
        string iBan = "IT96W0585611601050570111111";
        ulong creditCard1 = 1214519036076404;
        ulong creditCard2 = 139398053299994;
        ulong creditCard3 = 37456760168770;
        Console.WriteLine(holderName);
        Console.WriteLine(mBalance);
        Console.WriteLine(bankName);
        Console.WriteLine(iBan);
        Console.WriteLine(creditCard1);
        Console.WriteLine(creditCard2);
        Console.WriteLine(creditCard3);
    }
}

