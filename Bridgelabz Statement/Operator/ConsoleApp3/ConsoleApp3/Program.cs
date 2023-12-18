using ConsoleApp3.AddressBook;
using ConsoleApp3.Dict;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class program
    {
        
        static string inventory_filepath1 = @"D:\Bridgelabz Statement\Operator\ConsoleApp3\ConsoleApp3\Dict\dict.json";
        static void Main()
        {
            Console.WriteLine("Welcome To Address Book");
            Dictoperation details = new Dictoperation();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Process to be Done\n1.Read the Book\n2.Add the Contact\n3.Delete the Contact\n4.Edit the Contact\n5.Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:  
                        details.ReadDict(inventory_filepath1);
                        break;
                    case 2:
                        Console.WriteLine("\nWrite In book the contact Has to be added \nBook1,Book2(or)Book3");
                        string book = Console.ReadLine();
                        Console.WriteLine("Enter the detais :\n 1.First Name \n2.Last name \n3.Address \n4.City Name \n5.State Name \n.6.Zip code \n7.Phone Number \n8.Email Address ");
                        details.AddContactDetails(book);
                        details.WriteToJsonFile(inventory_filepath1);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Book name and First name Of the Contact");
                        string book1 = Console.ReadLine();
                        string name1 = Console.ReadLine();
                        details.DeleteContact(book1,name1);
                        details.WriteToJsonFile(inventory_filepath1);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Book name and First name Of the Contact");
                        string book2 = Console.ReadLine();
                        string name2 = Console.ReadLine();
                        details.EditContact(book2, name2);
                        details.WriteToJsonFile(inventory_filepath1);
                        break;
                    case 5:
                        flag = false;
                        break;

                } 
            }
        }
    }
}