using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _11_04_2022_LearningProcess
{
    class _11_04_2022_Day26_Task
    {
        public static void Main()
        {
            IList<DoctorDetails> DDSourceData = new List<DoctorDetails>()
            {
                new DoctorDetails(){DoctorID=1,Name="Nithin",Specialization=" General Surgery ", Gender='M',Age=28,PhoneNo="8946327516",Experience=3},
                new DoctorDetails(){DoctorID=2,Name="Lara",Specialization=" Paediatrician ", Gender='F',Age=35,PhoneNo="8946327516",Experience=8},
                new DoctorDetails(){DoctorID=3,Name="Kavi",Specialization=" Anaesthesia ", Gender='M',Age=28,PhoneNo="8946327516",Experience=3},

            };
            IList<SpecializationList> SpecializationData = new List<SpecializationList>()
            {
                new SpecializationList(){SpecializationID = 101,Specialization=" General Surgery ",MinimumSalary=100000,MaximumSalary=175000},
                new SpecializationList(){SpecializationID = 201,Specialization=" Paediatrician ",MinimumSalary=100000,MaximumSalary=195000},
                new SpecializationList(){SpecializationID = 301,Specialization=" Anaesthesia ",MinimumSalary=100000,MaximumSalary=200000},
            };
            var JoinData = DDSourceData.Join(
                SpecializationData,
                spName => spName.Specialization,
                splName => splName.Specialization,
                (spName, splName) => new
                {
                    DoctorID = spName.DoctorID,
                    DoctorName = spName.Name,
                    specializationID = splName.SpecializationID,
                    Specialization = splName.Specialization

                }
                );
            foreach (var v in JoinData)
                Console.WriteLine("ID : {0}, Name : {1}, SpecializationID : {2}, Specialization : {3}", v.DoctorID, v.DoctorName, v.specializationID, v.Specialization);           
        }
    }

    public  class DoctorDetails
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNo { get; set; }
        public int Experience { get; set; }
        
    }

    public class SpecializationList
    {
        public int SpecializationID { get; set; }
        public string Specialization { get; set; }
        public int MinimumSalary { get; set; }
        public int MaximumSalary { get; set; }

    }
}