using curso_heranca_e_polimorfismo.Entities;
using System;

namespace Course
{
    public class Program
    {
        static void Main()
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500);

            // Upcasting
           
            Account account2 = businessAccount;

            Console.WriteLine(account);
            Console.WriteLine(businessAccount);
            Console.WriteLine(account2);

            Account account3 = new BusinessAccount(1003, "Darley", 0.0, 200.0);
            Account account4 = new BusinessAccount(1004, "Anna", 0.0, 0.01);

            Console.WriteLine(account3);
            Console.WriteLine(account4);

            // Downcasting

            BusinessAccount account5 = account2 as BusinessAccount;
            Console.WriteLine(account5);
            account5.Loan(100.0);
            Console.WriteLine(account5);

            Account account6 = new SavingAccount(1005, "Anna", 0.0, 0.1);

            if (account6 is BusinessAccount) // Não entra nesse IF
            {
                try
                {
                    // BusinessAccount account5 = (BusinessAccount)account6; // Geraria uma exceção

                }
                catch
                {
                    throw new Exception();
                }
            }
        }
    }
}