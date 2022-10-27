using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class BookList
    {
        List<Book1> Books = new List<Book1>();

        public string ID { get; private set; }

        public BookList()
        {
            Books = new List<Book1>();
        }
        public void CreateBooks()
        {

        }
        public void Input()
        {
            Console.Write(" Input n Book:");

            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Book1 booka = new Book1();
                booka.Input();
                Books.Add(booka);
            }

        }
        public void showInfor()
        {
            for (int i = 0; i < Books.Count; i++)
                Books[i].Display();
            if(Books.Count > 0)
         {
          
         }
            else { Console.WriteLine("-----Nothing-----"); }
        }

        public void SearchByNameBook()
        {
            int a = 0;
            Console.Write("- Input the Name of Book: ");
            String searching = Console.ReadLine();
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.Equals(searching))
                {
                    Books[i].Display();
                    a = 1;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("-----Nothing-----");
            }
        }
        public void SearchByAuthorBook()
        {
            int a = 0;
            Console.Write("- Input the Author of Book: ");
            String searching = Console.ReadLine();
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Author.Equals(searching))
                {
                    Books[i].Display();
                    a = 1;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("-----Nothing-----");
            }
        }
        public int SearchByID()
        {
            int a = 0;
            Console.Write("- Input the ID of Book: ");
            String searching = Console.ReadLine();
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].ID.Equals(searching))
                {
                    Books[i].Display();
                    a = 1;
                    return i;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("-----Nothing-----");

            }
            return -1;
        }
        public Book1 FindByID(string ID)
        {
            Book1 searchResult = null;
            if (Books != null && Books.Count > 0)
            {
                foreach (Book1 bk in Books)
                {
                    if (bk.ID.Equals(ID))
                    {
                        searchResult = bk;
                    }
                }
            }
            return searchResult;
        }
        public bool DeleteById()
        {
            bool IsDeleted = false;
            //find ID and Delete
            Console.Write("- Input the ID of Book: ");
            String ID = Console.ReadLine();
            Book1 bk = FindByID(ID);
            if (bk != null)
            {
                IsDeleted = Books.Remove(bk);
                Console.WriteLine("Success");
            }
            else
            {

                Console.WriteLine("nothing");
            }
            return IsDeleted;
        }
        public void UpdateBook()
        {
            Console.Write("- Input the ID of Book: ");
            String ID = Console.ReadLine();
            Book1 bk = FindByID(ID);
            if (bk != null)
            {
                Console.Write("Input the name of Book: ");
                string Name = Convert.ToString(Console.ReadLine());
                if (Name != null && Name.Length > 0)
                {
                    bk.Name = Name;
                }

                Console.Write("Input the Author of Book: ");
                string Author = Convert.ToString(Console.ReadLine());
                if (Author != null && Author.Length > 0)
                {
                    bk.Author = Author;
                }

                Console.Write("Input the YearPublish of Book: ");
                string YearPublish = Convert.ToString(Console.ReadLine());
         
                if (YearPublish != null && YearPublish.Length > 0)
                {
                    bk.YearPublish = YearPublish;
                }

            }
            else
            {
                Console.WriteLine(" Wrong ID for Update ", ID);
            }

        }
       


     
       
        
      
       
    }
}