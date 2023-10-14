using System;
using System.Text;
using curso_heranca_e_polimorfismo.Entities;
using curso_heranca_e_polimorfismo.Employees;

namespace curso_heranca_e_polimorfismo
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("How many employees will be registered?");
                int quantity = int.Parse(Console.ReadLine());

                List<Employee> employees = new List<Employee>();
                for (int i = 0; i < quantity; i++)
                {
                    Console.WriteLine($"Employee #{i + 1} data: ");

                    Console.Write("Outsourced? (Y/N) ");
                    string outsourced = Console.ReadLine().ToUpper();

                    Console.Write("Name: ");
                    string employeeName = Console.ReadLine();

                    Console.Write("Hours: ");
                    int employeeHours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double employeeValuePerHours = double.Parse(Console.ReadLine());

                    if (outsourced.StartsWith('Y'))
                    {
                        Console.Write("Additional Charge: ");
                        double additionalCharge = double.Parse(Console.ReadLine());
                        employees.Add(new OutsourceEmployee(employeeName, employeeHours,
                                                            employeeValuePerHours, additionalCharge));
                    }
                    else
                    {
                        employees.Add(new Employee(employeeName, employeeHours, employeeValuePerHours));
                    }
                }
                Console.WriteLine("PAYMENTS: ");
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
