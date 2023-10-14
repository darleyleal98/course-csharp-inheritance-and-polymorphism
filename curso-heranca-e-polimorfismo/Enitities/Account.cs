using System;
using System.Collections.Generic;
using System.Text;

namespace curso_heranca_e_polimorfismo.Entities
{
    public class Account
    {
        protected int Number {  get; set; }
        protected string Holder { get; set; }
        protected double Balance { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        // O virtual indica que o método pode ser sobrescrito
        public virtual void Withdraw(double amount) => Balance -= amount + 5.0;
        public void Deposit(double amount) => Balance += amount;

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
