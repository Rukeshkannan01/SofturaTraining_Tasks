using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace _12_04_2022_LearningProcessData
{
    // Create a core console application.
    //Write methods to insert, update and delete record in the table Enrollment, both by using query and stored procedure.    
    class _12_04_2022_Day27_Task
    {
        SqlConnection sqlconn = new SqlConnection("data source = DESKTOP-5BF33K3; database = Trial; user id = sa; password = P@ssw0rd");     
        public void InstEnrollTbl()
        {
            string Entbl = "insert EnrollmentList(FirstName, LastName, Gender, EmailID, ContactNo) values('Nithin','P','M','nithin001@gmail.com','8945761247')";
            SqlCommand cmmd = new SqlCommand(Entbl, sqlconn);
            sqlconn.Open();
            cmmd.ExecuteNonQuery();
            sqlconn.Close();
            Console.WriteLine("Row Inserted");
        }
        public void UpdEnrollTbl()
        {
            string upEntbl = "update EnrollmentList set FirstName = 'Nithin Kumar' where FirstName = 'Nithin'";
            SqlCommand cmmd = new SqlCommand(upEntbl, sqlconn);
            sqlconn.Open();
            cmmd.ExecuteNonQuery();
            sqlconn.Close();
            Console.WriteLine(" Table updated ");
        }
        public void DelEnrollTbl()
        {
            string delEntbl = "delete EnrollmentList where StudentID = 2006";
            SqlCommand cmmd = new SqlCommand(delEntbl, sqlconn);
            sqlconn.Open();
            cmmd.ExecuteNonQuery();
            sqlconn.Close();
            Console.WriteLine("Row deleted");
        }
        //------------------------------------------------

        // -----------using stored procedure-----------

        public void InstEnrollTbl_SP()
        {
            SqlCommand cmd = new SqlCommand("sp_enrolltbl", sqlconn); 
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = "Nithin";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = "p";
            cmd.Parameters.Add("@Gender", SqlDbType.Char).Value = "M";
            cmd.Parameters.Add("@EmailID", SqlDbType.VarChar).Value = "nithin2001@gmail.com";
            cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = "6854795638";
            sqlconn.Open();
            cmd.ExecuteNonQuery();
            sqlconn.Close();
            Console.WriteLine("Row Inserted");
        }
        public void UpdEnrollTbl_SP()
        {
            SqlCommand cmd = new SqlCommand("sp_upenroltbl", sqlconn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = "Nithin Kumar";            
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = "p";
            cmd.Parameters.Add("@Gender", SqlDbType.Char).Value = "M";
            cmd.Parameters.Add("@EmailID", SqlDbType.VarChar).Value = "nithin2001@gmail.com";
            cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = "6854795638";
            sqlconn.Open();
            cmd.ExecuteNonQuery();
            sqlconn.Close();
            Console.WriteLine(" Table updated ");
        }
        public void DelEnrollTbl_SP()
        {
            SqlCommand cmd = new SqlCommand("sp_delenroltbl", sqlconn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = "Nithin Kumar";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = "p";
            cmd.Parameters.Add("@Gender", SqlDbType.Char).Value = "M";
            cmd.Parameters.Add("@EmailID", SqlDbType.VarChar).Value = "nithin2001@gmail.com";
            cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = "6854795638";
            sqlconn.Open();
            cmd.ExecuteNonQuery();
            sqlconn.Close();
            Console.WriteLine("Row deleted");

        }
        public static void Main()
        {
            _12_04_2022_Day27_Task obj = new _12_04_2022_Day27_Task();
            //obj.InstEnrollTbl();
            //obj.UpdEnrollTbl();
            //obj.DelEnrollTbl();
            //obj.InstEnrollTbl_SP();
            //obj.UpdEnrollTbl_SP();
            obj.DelEnrollTbl_SP();
        }
    }
}
