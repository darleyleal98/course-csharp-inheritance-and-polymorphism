using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_heranca_e_polimorfismo.Employees
{
    public class OutsourceEmployee : Employee
    {
        protected double AdditionalCharge { get; set; }
        public OutsourceEmployee() { }
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
                                 : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public sealed override double Payment() => (Hours * ValuePerHour) + (AdditionalCharge * 1.1);
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Name} - {Payment():c}");
            return builder.ToString();
        }
    }
}
