using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo
{
    public class Book1
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string YearPublish { get; set; }
        public string ID { get; set; }

        public Book1(string Name, string Author, string YearPublish)
        {
            this.Name = Name;
            this.Author = Author;
            this.YearPublish = YearPublish;
            this.ID = ID;
        }

        public Book1()
        {
        }
        // admin
        public void Input()
        {
            Console.Write("\n - Information Name of Book: ");
            Name = Console.ReadLine();
            Console.Write(" - Information Author of Book: ");
            Author = Console.ReadLine();
            Console.Write(" - Publishing Year: ");
            YearPublish = Console.ReadLine();
            Console.Write(" - ID of Book: ");
            ID = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("---LIST INFORMATION---");
            Console.WriteLine("- Name of Book:  {0}", Name);
            Console.WriteLine("- Author of Book:   {0}", Author);
            Console.WriteLine("- Publishing Year:   {0}", YearPublish);
            Console.WriteLine("- ID of Book    {0}", ID);
        }


    }


}