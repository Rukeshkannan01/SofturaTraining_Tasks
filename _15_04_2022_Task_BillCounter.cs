using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace _15_04_2022_LearningProcess
{
    class _15_04_2022_Task_BillCounter
    {
        SqlConnection sqlconn = new SqlConnection("data source = DESKTOP-5BF33K3; database = ProductStore; user id = sa; password = P@ssw0rd");       

        public void NewCustomer()
        {
            Console.WriteLine("Welcome to our store \n");
            Console.Write("Enter your Name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter your Gender : ");
            string Gender = Console.ReadLine();
            Console.Write("Enter your DoB : ");
            string DoB = Console.ReadLine();
            Console.Write("Enter your ContactNo : ");
            string ContactNo = Console.ReadLine();
            Console.Write("Enter your EmailID : ");
            string EmailID = Console.ReadLine();
            Console.Write("Choose your city ( chennai, bangalore, mumbai, hyderabad ) : ");
            string City = Console.ReadLine();
            string CustDetails = "insert CustomerList(Name, Gender, DoB, ContactNo, EmailID, City) values('" + Name + "','" + Gender + "','" + DoB + "','" + ContactNo + "','" + EmailID + "','" + City + "')";
            SqlCommand cmd = new SqlCommand(CustDetails, sqlconn);
            sqlconn.Open();
            cmd.ExecuteNonQuery();
            sqlconn.Close();
            _15_04_2022_Task_BillCounter obj = new _15_04_2022_Task_BillCounter();
            obj.GetNewCustId(ContactNo);                

        }
        public void GetNewCustId(string contNo)
        {
            SqlCommand cmd = new SqlCommand("select CustomerID from CustomerList where ContactNo = " + contNo + "", sqlconn);
            sqlconn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int custid = Convert.ToInt32(dr[0]);
                Console.WriteLine("Successfully registered and your  customerID : " + custid);
            }            
        }
        public void ProductList()
        {
            SqlCommand cmd = new SqlCommand("select ProductID, ProductName, Price, MfgDate, ExpDate  from ProductList", sqlconn);
            sqlconn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine();
                Console.WriteLine("ProductID : " + dr[0] + " ProductName : " + dr[1] + " Price : " + dr[2] + " MfgDate : " + dr[3] + " ExpDate : " + dr[4]);
            }
            sqlconn.Close();
        }
        public void Purchase(int id, int prdId, int qty)
        {
            string p = "select Price * " + qty + ",ProductName,Price from ProductList where ProductID = " + prdId + "";
            SqlCommand cmd = new SqlCommand(p, sqlconn);
            sqlconn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int TotalAmount = Convert.ToInt32(dr[0]);
                Console.WriteLine();
                Console.WriteLine("ProductID : " + prdId + " ProductName : " + dr[1] + " Price : " + dr[2] +" Quantity : "+ qty+ " Total Amount :" + TotalAmount);
                _15_04_2022_Task_BillCounter obj = new _15_04_2022_Task_BillCounter();
                obj.Purchasetbl(id, prdId, qty, TotalAmount);
            }
            sqlconn.Close();
        }

        public void Purchasetbl(int id, int prdId, int qty, int totalamt)
        {
            string bill = "insert PurchaseDetails(CustomerID,ProductID,Quantity,TotalAmount) values('" + id + "','" + prdId + "','" + qty + "','" + totalamt + "')";
            SqlCommand cmd = new SqlCommand(bill, sqlconn);
            sqlconn.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Thank you for shopping");
            sqlconn.Close();            
        }
        
        public void CustPurchDet(int id)
        {
            string purchDetl = "select CustomerID,pl.ProductID,ProductName,Price,Quantity,TotalAmount from ProductList as pl join PurchaseDetails as pd on pl.ProductID = pd.ProductID where CustomerID = " + id + "";
            SqlCommand cmd = new SqlCommand(purchDetl, sqlconn);
            sqlconn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("CustomerID : " + dr[0] + "  ProductID : " + dr[1] + "  ProductName : " + dr[2] + "  Price : " + dr[3] + "  Quantity : " + dr[4] + "  TotalAmount : " + dr[5]);
            }
            sqlconn.Close();
        }


        public void ShowBydate()
        {
            Console.Write("\nEnter date to see purchase details : ");
            var bdate = Convert.ToString(Console.ReadLine());
            string purchDetl = "select CustomerID,pl.ProductID,ProductName,Price,Quantity,TotalAmount from ProductList as pl join PurchaseDetails as pd on pl.ProductID = pd.ProductID where BillDate = '" + bdate + "'";
            SqlCommand cmd = new SqlCommand(purchDetl, sqlconn);
            sqlconn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("CustomerID : " + dr[0] + "  ProductID : " + dr[1] + "  ProductName : " + dr[2] + "  Price : " + dr[3] + "  Quantity : " + dr[4] + "  TotalAmount : " + dr[5]);
            }

            sqlconn.Close();
        }
        public static void Main()
        {
            _15_04_2022_Task_BillCounter obj = new _15_04_2022_Task_BillCounter();
            Console.Write("Existing Customer enter (yes or no) : ");
            string ValCust = Console.ReadLine();
            if (ValCust == "YES" || ValCust == "yes" || ValCust == "Yes")
            {
                Console.WriteLine("Welcome to our store \n");
                Console.Write("Enter your CustomerID  : ");
                int id = Convert.ToInt32(Console.ReadLine());

                SqlConnection sqlconn = new SqlConnection("data source = DESKTOP-5BF33K3; database = ProductStore; user id = sa; password = P@ssw0rd");
                SqlCommand cmd = new SqlCommand("Select CustomerID from CustomerList where customerID=" + id + "", sqlconn);
                sqlconn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    obj.ProductList();

                    Console.WriteLine("\nChoose the products based on the about product list ");

                    Console.Write("\nEnter the product (Note use productID ) : ");
                    int prdid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter product quantity : ");
                    int unit = Convert.ToInt32(Console.ReadLine());
                    obj.Purchase(id, prdid, unit);
                }
                sqlconn.Close();
            }
            else
                obj.NewCustomer();

            Console.Write("\nEnter CustomerID to see purchase details : ");
            int custID = Convert.ToInt32(Console.ReadLine());

            obj.CustPurchDet(custID);

            obj.ShowBydate();

        }
    }
}
