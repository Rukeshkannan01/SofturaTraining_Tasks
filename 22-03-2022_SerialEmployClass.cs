using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace _22_03_2022_LearningProcess
{
    [Serializable]
    class ClassEmployee
    {
        public int Id = 1;
        public string Name = "EmployeeName01";
        public string Gender = "Male";
        public int Age = 21;        

    }
    class _22_03_2022_SerialEmployClass
    {
        public void SerialEmployee()
        {
            ClassEmployee Emply = new ClassEmployee();
            FileStream Efile = new FileStream(@"D:\Softura training\11_Day\SerialEmployee.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter EfileSf = new SoapFormatter();
            EfileSf.Serialize(Efile, Emply);
            Efile.Close();

        }
        public void DeserialEmployee()
        {
            FileStream Efile = new FileStream(@"D:\Softura training\11_Day\SerialEmployee.txt", FileMode.Open, FileAccess.Read);
            SoapFormatter EfileSf = new SoapFormatter();
            ClassEmployee Emply01 = (ClassEmployee)EfileSf.Deserialize(Efile);
            Console.WriteLine(Emply01.Id);
            Console.WriteLine(Emply01.Name);
            Console.WriteLine(Emply01.Gender);
            Console.WriteLine(Emply01.Age);


        }
        public static void Main()
        {
            _22_03_2022_SerialEmployClass Eobj = new _22_03_2022_SerialEmployClass();
            Eobj.SerialEmployee();
            Eobj.DeserialEmployee();
            Console.Read();


        }
    }
}
