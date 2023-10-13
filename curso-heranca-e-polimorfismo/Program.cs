using curso_heranca_e_polimorfismo.ExercicioI;
using System;

namespace Course
{
    public class Program
    {
        static void Main()
        {
            BusinessAccount businessAccount = new BusinessAccount(8010, "Darley Leal", 100.0, 500.0);
            Console.WriteLine(businessAccount.ToString());
        }
    }
}