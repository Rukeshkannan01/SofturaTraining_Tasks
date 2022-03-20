using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Task
{
    class SalesMarketing
    {
        public void SandM(int SMsalary)
        {
            double Bsalary = SMsalary * 0.2;
            Console.WriteLine("Sale & Marketing department salary with bonus :");
            Console.WriteLine(SMsalary + Bsalary);
            
        }
    }
    class Production:SalesMarketing
    {
        public void Product(int Psalary)
        {
            double Bsalary = Psalary * 0.1;
            Console.WriteLine("Production department salary with bonus : ");
            Console.WriteLine(Psalary + Bsalary);

        }
    }
    class SalaryBonus
    {
        public static void Main()
        {
            Console.Write("Employee ID :");
            int Eid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name :");
            string name = Console.ReadLine();
            Console.Write("Gender :");
            string gender = Console.ReadLine();
            Console.Write("Years of eperience :");
            int YearofExp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary :");
            int salary = Convert.ToInt32(Console.ReadLine());
            Production Sobj = new Production();
            Sobj.Product(salary);
            Sobj.SandM(salary);
            Console.ReadLine();


        }
    }
}
