using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_heranca_e_polimorfismo.Employees
{
    public class Employee
    {
        protected string Name { get; set; }
        protected int Hours { get; set; }
        protected double ValuePerHour { get; set; }

        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment() => Hours * ValuePerHour;
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Name} - {Payment():c}");
            return builder.ToString();
        }
    }
}
