using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace demo
{
    class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public Account()
        {

        }
        public Account(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
    class ManageLibrary
    {
        List<Account> users { get; set; }

        public ManageLibrary()
        {
            users = new List<Account>();

        }

        public void CreateAccount()
        {
            Account user = new Account();
            Console.Write(" Create user name: ");
            user.UserName = Console.ReadLine();
            Console.Write(" Create Password: ");
            user.Password = Console.ReadLine();
            users.Add(user);
        }
        public int Login()
        {
            string userName;
            string password;
            Console.WriteLine("-----Login-----");
            Console.Write("   UserName: ");
            userName = Console.ReadLine();
            Console.Write("   Password: ");
            password = Console.ReadLine();

            int check = -1;

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserName == userName && users[i].Password == password)
                {
                    check = i;
                }
            }
            return check;
        }
        public void ReadAdmin()
        {
            Account user = new Account();
            user.UserName = "admin";
            user.Password = "123";
            user.Role = 1;
            users.Add(user);
        }
        
        public class Program
        {

            public static void Main()
            {
                ManageLibrary manageLibrary = new ManageLibrary();
                manageLibrary.ReadAdmin();
                int save = -1;
                
                while (true)
                {
                    Console.WriteLine(" 1. To Exit ");
                    Console.WriteLine(" 2. Login");
                    Console.WriteLine(" 3. Create Account");
                    Console.Write(" Input Option: ");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1) return;
                    if (option == 2)
                    {
                        save = manageLibrary.Login();
                        if (save == -1) Console.WriteLine("Username or Password wrong!!!");
                        else break;
                    }
                    if (option == 3) manageLibrary.CreateAccount();
                }
                
                while (true)
                {
                    BookList b = new BookList();
                  
                    
                    if (manageLibrary.users[save].Role == 1)
                        
                    {
                        //for admin
                        Console.WriteLine("--------------");
                        Console.WriteLine(" You Are ADMIN");
                        Console.WriteLine(" ENTER To Continue ");
                        Console.ReadKey();
                        int choose;




                        do
                        {
                            Console.WriteLine("\n_________________Menu___________________");
                            Console.WriteLine(" 1. Input n information of book");
                            Console.WriteLine(" 2. List of Book");
                            Console.WriteLine(" 3. Search for by Name of Book");
                            Console.WriteLine(" 4. Search for by Author of Book");
                            Console.WriteLine(" 5. Search for by ID of Book");
                            Console.WriteLine(" 6. Delete for ID of Book");
                            Console.WriteLine(" 7. Update for ID of Book");
                            Console.WriteLine(" 8. Logout");
                            Console.WriteLine(" 9. Exit");
                            Console.Write(" Input Option:");
                            choose = Int32.Parse(Console.ReadLine());

                            switch (choose)
                            {
                                case 1:
                                    b.Input();
                                    break;
                                case 2:
                                    b.showInfor();
                                    break;
                                case 3:
                                    b.SearchByNameBook();
                                    break;
                                case 4:
                                    b.SearchByAuthorBook();
                                    break;
                                case 5:
                                    b.SearchByID();
                                    break;
                                case 6:
                                    b.DeleteById();
                                    break;
                                case 7:
                                    b.UpdateBook();
                                    break;
                                case 8:
                                    Console.WriteLine(" 1. Exit");
                                    Console.WriteLine(" 2. Login");                                 
                                    Console.Write(" Input Option: ");                                    
                                    int option = int.Parse(Console.ReadLine());
                                    if (option == 1) return;
                                    save = manageLibrary.Login();
                                    
                                    break;
                                case 9:
                                    return;
                                    
                                default:
                                    Console.WriteLine(" Please, Input 1-9");
                                    break;
                            }
                            if (choose == 8) break;
                        } while (choose != 9);
                    }

                    else
                    {   //for user
                        int choice;

                        Console.WriteLine(" You are User");
                        Console.WriteLine("ENTER To Continue");
                        Console.ReadKey();
                        
                        
                        while (true)
                        {
                            do
                            {
                                Console.WriteLine("\n_________________Menu___________________");
                                Console.WriteLine(" 1. Search by Name of Book");
                                Console.WriteLine(" 2. Search by Author of Book");
                                Console.WriteLine(" 3. Search By ID of Book");
                                Console.WriteLine(" 4. Logout");
                                Console.WriteLine(" 5. Exit");
                              

                                Console.WriteLine(" Input Option:");
                                choice = Convert.ToInt32(Console.ReadLine());


                                switch (choice)
                                {
                                    case 1:
                                        b.SearchByNameBook();
                                        break;
                                    case 2:
                                        b.SearchByAuthorBook();
                                        break;
                                    case 3:
                                        b.SearchByID();
                                        break;
                                    case 4:
                                        Console.WriteLine(" 1. Exit");
                                        Console.WriteLine(" 2. Login");
                                        Console.WriteLine(" Input Option: ");
                                        int option = int.Parse(Console.ReadLine());
                                        if (option == 1) return;
                                        save = manageLibrary.Login();
                                        break;

                                    
                                    case 5:

                                        return;
                                    default:
                                        Console.WriteLine(" Please input 1-5 ");
                                        break;
                                    
                                }
                                if (choice == 4) break;
                            } while (choice != 5);
                        }
                    }
                }
            }
        }
    }
}