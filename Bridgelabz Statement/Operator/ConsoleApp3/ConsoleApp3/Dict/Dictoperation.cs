using System;
using Newtonsoft;
using ConsoleApp3.AddressBook;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace ConsoleApp3.Dict
{
    internal class Dictoperation
    {
        Dict list;
        public void ReadDict(string filePath)
        {
            var json = File.ReadAllText(filePath);
            list = JsonConvert.DeserializeObject<Dict>(json);

            Display(list.Book1);
            Display(list.Book2);
            Display(list.Book3);
        }
        public void AddContactDetails(string objectName)
        {
            ContactDetails details = new ContactDetails()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToInt32(Console.ReadLine()),
                PhoneNumber = Convert.ToInt64(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            if (objectName.ToLower().Equals("book1"))
            {
                list.Book1.Add(details);
                Console.WriteLine("The data is Added");
            }
            if (objectName.ToLower().Equals("book2"))
            {
                list.Book2.Add(details);
                Console.WriteLine("The Data is Added");
            }
            if (objectName.ToLower().Equals("book3"))
            {
                list.Book3.Add(details);
                Console.WriteLine("The Data is Added");
            }
        }
        public void DeleteContact(string objectName, string InventoryName)
        {
            ContactDetails details = new ContactDetails();
            if (objectName.ToLower().Equals("book1"))
            {
                foreach (var data in list.Book1)
                {
                    if (data.FirstName.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                    list.Book1.Remove(details);
                Console.WriteLine("The Contact is Removed");
            }
            if (objectName.ToLower().Equals("book2"))
            {
                foreach (var data in list.Book2)
                {
                    if (data.FirstName.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                    list.Book2.Remove(details);
                Console.WriteLine("The Contact is Removed");
            }
            if (objectName.ToLower().Equals("book3"))
            {
                foreach (var data in list.Book3)
                {
                    if (data.FirstName.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                    list.Book3.Remove(details);
                Console.WriteLine("The Contact is Removed");
            }
        }
        public void EditContact(string objectName, string InventoryName)
        {
            ContactDetails details = new ContactDetails();
            if (objectName.ToLower().Equals("book1"))
            {
                foreach (var data in list.Book1)
                {
                    if (data.FirstName.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                {
                    Console.WriteLine("Enter the detais :\n1.Last name \n2.Address \n3.City Name \n4.State Name \n.5.Zip code \n6.Phone Number \n7.Email Address ");
                    details.LastName = Console.ReadLine();
                    details.Address = Console.ReadLine();
                    details.City = Console.ReadLine();
                    details.State = Console.ReadLine();
                    details.Zip = Convert.ToInt32(Console.ReadLine());
                    details.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    details.Email = Console.ReadLine();
                }
            }
            if (objectName.ToLower().Equals("book2"))
            {
                foreach (var data in list.Book2)
                {
                    if (data.FirstName.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                {
                    Console.WriteLine("Enter the detais :\n1.Last name \n2.Address \n3.City Name \n4.State Name \n.5.Zip code \n6.Phone Number \n7.Email Address ");
                    details.LastName = Console.ReadLine();
                    details.Address = Console.ReadLine();
                    details.City = Console.ReadLine();
                    details.State = Console.ReadLine();
                    details.Zip = Convert.ToInt32(Console.ReadLine());
                    details.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    details.Email = Console.ReadLine();
                }
            }
            if (objectName.ToLower().Equals("book3"))
            {
                foreach (var data in list.Book3)
                {
                    if (data.FirstName.Equals(InventoryName))
                        details = data;
                }
                if (details != null)
                {
                    Console.WriteLine("Enter the detais :\n1.Last name \n2.Address \n3.City Name \n4.State Name \n.5.Zip code \n6.Phone Number \n7.Email Address ");
                    details.LastName = Console.ReadLine();
                    details.Address = Console.ReadLine();
                    details.City = Console.ReadLine();
                    details.State = Console.ReadLine();
                    details.Zip = Convert.ToInt32(Console.ReadLine());
                    details.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    details.Email = Console.ReadLine();
                }
            }
        }
        public void WriteToJsonFile(string filepath)
        {
            var json = JsonConvert.SerializeObject(list);
            File.WriteAllText(filepath, json);
        }
        public void Display(List<ContactDetails> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.FirstName + " " + data.LastName + " " + data.PhoneNumber);
            }
        }
    }
}
