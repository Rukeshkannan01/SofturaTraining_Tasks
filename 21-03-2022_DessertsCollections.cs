using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_2022_LearningProcess
{
    class _21_03_2022_DessertsCollections
    {
        public static void Main()
        {
            Queue Desserts = new Queue();
            Desserts.Enqueue("Gulab Jamuns");
            Desserts.Enqueue("laddu");
            Desserts.Enqueue("Payasam");
            Desserts.Enqueue("Ice Cream");
            /*foreach (string i in Desserts)
                Console.WriteLine(i);
            */
            FileStream df = new FileStream("D:\\Softura training\\10_Day\\21-03-2022_DessertsCollections.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(df);
            bw.Write("Desserts lists : \n");
            foreach (string coll in Desserts)
            {
                bw.Write("\n"+coll);
            }
            //bw.BaseStream.Seek(0,SeekOrigin.End);
            //bw.Flush();
            bw.Close();
            df.Close();

            FileStream fs1 = new FileStream("D:\\Softura training\\10_Day\\21-03-2022_DessertsCollections.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs1);
            string str = br.ReadString();
            fs1.Close();

            FileInfo fi = new FileInfo("D:\\Softura training\\10_Day\\21-03-2022_DessertsCollections.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);

            Console.Read();
           

        }
    }
}
