//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Gancho";
        string middleName = "Penkov";
        string lastName = "Semkov";
        decimal balance = 35483248.156M;
        string bankName = "DSK";
        string iban = "BG98 UNIC 8967 6542 4657 12";
        string bic = "ASDHGFRE";
        ulong cardOne = 5214519036076404;
        ulong cardTwo = 349398053299994;
        ulong cardThree = 4716760168770;
    }
}

