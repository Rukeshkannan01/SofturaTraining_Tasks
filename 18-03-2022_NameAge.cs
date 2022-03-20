using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Task
{
    class NameAge
    {
        public void Name()
        {
            Console.WriteLine("enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine(name);
        }
        public void Age(int age)
        {
            Console.WriteLine(age);

        }
        public static void Main()
        {
            NameAge Nobj = new NameAge();
            Nobj.Name();
            Console.WriteLine("enter you age :");
            int age = Convert.ToInt32(Console.ReadLine());
            NameAge Aobj = new NameAge();
            Aobj.Age(age);
            Console.ReadLine();

        }
    }


}
