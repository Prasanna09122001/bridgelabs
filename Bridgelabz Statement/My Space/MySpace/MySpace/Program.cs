using System;
using System.Transactions;

namespace  MySpace
{
    class program
    {
        static void Main()
        {
            SQLQuery sqlquery = new SQLQuery();
            Console.WriteLine("Enter the Operation to be Exectued\n1.Add Personal Details\n2.Get All Details\n3.Update Details\n4.Remove Details");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    sqlquery.PersonalDetail();
                    break;
                case 2:
                    sqlquery.GetAllDetails();
                    break;
                case 3: 
                    sqlquery.UpdateDetail(); 
                    break;
                case 4:
                    sqlquery.DeleteDetail();
                    break;
                default:
                    break;
            }

            StoredProcedures stored = new StoredProcedures();
            stored.CreateStoredProcedureForAddDetails();
            stored.CreateStoredProcedureForUpdateDetails();
            stored.CreateStoredProcedureForDeleteDetails();
            stored.CreateStoredProcedureForGetDetails();


            // Update the Details Using Column Name
            Console.WriteLine("Enter the id Number to be changed");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Column To be changed");
            string a = Convert.ToString(Console.Read());
            Console.WriteLine("Enter the Updated Value of the Column " + a);
            string b = Convert.ToString(Console.Read());
            string c = "Update PersonalDetails Set " + a + " ='" + b + "' Where id = "+id;
            Console.WriteLine(c); 
         }
    }
}

