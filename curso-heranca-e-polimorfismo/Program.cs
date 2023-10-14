using System;
using System.Text;
using curso_heranca_e_polimorfismo;
using curso_heranca_e_polimorfismo.Entities;

namespace curso_heranca_e_polimorfismo.Entities
{
    public class Program
    {
        static void Main()
        {
            Account account1 = new Account(1001, "Alex", 500.0);
            Account account2 = new SavingAccount(1002, "Anna", 500.0, 0.01);

            account1.Withdraw(10.0);
            account2.Withdraw(10.0);

            Console.WriteLine(account1.ToString());
            Console.WriteLine(account2.ToString());
        }
    }
}
