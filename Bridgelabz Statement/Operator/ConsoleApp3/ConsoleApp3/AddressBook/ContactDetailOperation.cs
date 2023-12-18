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


namespace ConsoleApp3.AddressBook
{
    internal class ContactDetailOperation
    {
        ContactDetailOperation list;
        public void ReadAddressBook(string filePath)
        {
            var json = File.ReadAllText(filePath);
            List<ContactDetails> list = JsonConvert.DeserializeObject<List<ContactDetails>>(json);
            foreach (var data in list)
            {
                Console.WriteLine(data.FirstName + " " + data.LastName + " " + data.PhoneNumber);
            }
        }
    }
}
