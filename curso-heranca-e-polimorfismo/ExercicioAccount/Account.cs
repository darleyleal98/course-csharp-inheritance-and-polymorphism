using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_heranca_e_polimorfismo.ExercicioI
{
    public class Account
    {
        private int Number {  get; set; }
        private string Holder { get; set; }
        private double Balance { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Number: {Number}");
            stringBuilder.AppendLine($"Holder: {Holder}");
            stringBuilder.AppendLine($"Balance: {Balance}");

            return stringBuilder.ToString();
        }
    }
}
