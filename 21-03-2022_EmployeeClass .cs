using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace _21_03_2022_LearningProcess
{
    class _21_03_2022_EmployeeClass
    {
        public static void Main()
        {
            Dictionary<int, string> dClass = new Dictionary<int, string>();
            dClass.Add(1, "Name: Nithin, Gender: Male, Age: 21");
            dClass.Add(2, "Name: Kavi, Gender: Male, Age: 21");
            dClass.Add(3, "Name: Rukeshkumar, Gender: Male, Age: 21");
            FileStream df = new FileStream("D:\\Softura training\\10_Day\\21-03-2022_EmployeeClass.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(df);
            foreach (var v in dClass)
                Console.WriteLine("Employee Id: {0}  {1}", v.Key, v.Value);
            foreach (var v in dClass)
            {
                bw.Write(v.Key + v.Value);
                bw.Write("\n");
            }

            bw.Flush();
            bw.Close();
            df.Close();

            Console.Read();
        }
    }
}
