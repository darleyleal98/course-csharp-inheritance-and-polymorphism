using System;

namespace curso_heranca_e_polimorfismo.Entities
{
    public class SavingAccount : Account
    {
        protected double InterestRate {  get; set; }
        public SavingAccount() { }
        public SavingAccount(int number, string holder, double balance, double InterestRate) 
                             : base(number, holder, balance)
        {
            InterestRate = InterestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
