using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_04_2022_LearningProcess
{
    class _07_04_2022_Day24_Task
    {
        public static void Main()
        {
            IList<BookList> StrData = new List<BookList>()
            {
                 new BookList() { BookID = 1, Title = "The Alchemist", Author ="Paulo Colehlo", Price =350 },
                 new BookList() { BookID = 2, Title = "A Brief History of Time", Author ="Stephen Hawking", Price =250 },
                 new BookList() { BookID = 3, Title = "Harry Potter", Author = "J.K.Rowling", Price =600 },                 
                 new BookList() { BookID = 5, Title = "The Wings Of Fire", Author ="APJ.AbdulKalam", Price =1000},
            };

            //Display all Data

            Console.WriteLine("------ Display all Data ------\n");
            var alldata = from str in StrData
                        select str;
            foreach (var s in alldata)
                Console.WriteLine("BookID : {0} Title :   {1} Author :  {2} Price :  {3}", s.BookID, s.Title, s.Author, s.Price);

            //Order by Author

            Console.WriteLine("------ Order by Author ------\n");
            var OrdByAuth = StrData.OrderBy(s => s.Author);
            foreach (var s in OrdByAuth)
                Console.WriteLine(" Author : {0} Title : {1} ",s.Author, s.Title);

            //order by Price

            Console.WriteLine("------ order by Price ------\n");
            var OrdByPrice = StrData.OrderBy(s => s.Price);
            foreach (var s in OrdByPrice)
                Console.WriteLine(s.Price);

            //particular author

            Console.WriteLine("------ particular author ------\n");
            Console.Write("Enter the Author Name : ");
            string A = Console.ReadLine();
            var ParAuth = from str in StrData
                          select str;
            foreach (var s in OrdByAuth)
                if (A == s.Author)
                {
                    Console.WriteLine(s.Title);
                }


        }
    }
    class BookList
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
