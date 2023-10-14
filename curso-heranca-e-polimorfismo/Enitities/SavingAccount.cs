using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_heranca_e_polimorfismo.Entities
{
    public sealed class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount() { }
        public SavingAccount(int number, string holder, double balance, double interestRate)
                             : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance() => Balance += Balance * InterestRate;

        //Sobreposição do método, sealed indica que esse método não poderá ser sobrescrito
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}