using System;
using System.Text;
using curso_heranca_e_polimorfismo;
using curso_heranca_e_polimorfismo.ExercicioI;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace curso_heranca_e_polimorfismo.ExercicioI
{
    public class BusinessAccount : Account
    {
        private double LoanLimit { get; set; }

        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, 
                               double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            try
            {
                if (amount <= LoanLimit)
                {
                    Deposit(amount);
                }
            }
            catch
            {
                throw new Exception("Value exceeds allowed limit! Try again!");
            }
        }
        public override string ToString()
        {
            string toStringForBaseClass = base.ToString();
            StringBuilder stringBuilder = new StringBuilder(toStringForBaseClass);
            stringBuilder.AppendLine($"Loan Limit: {LoanLimit}");

            return stringBuilder.ToString();
        }
    }
}
