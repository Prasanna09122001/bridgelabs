using System;
using System.Net;

namespace ADODemo
{
    class Program
    {
        static void Main()
        {
              Console.WriteLine("Welcome");
            //operation.CreateDataBase();
            //operation.DeleteDataBase();
            // operation.ReadfromDatabase();


            EmployeeOperation employeeoperation = new EmployeeOperation();
            List<person> list = new List<person>();
            list.Add(new person() { name = "a", city = "a", address="a" });
            list.Add(new person() { name = "b", city = "b", address="b" });
            list.Add(new person() { name = "c", city = "c", address="c" });
            list.Add(new person() { name = "d", city = "d", address="d" });
            list.Add(new person() { name = "e", city = "e", address="e" });
            list.Add(new person() { name = "f", city = "f", address="f" });
            DateTime start = DateTime.Now;
            foreach (var data in list)
            {
                employeeoperation.Addemployeee(data);
              }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duration Without Thread"+(end-start));
            // employeeoperation.deletemployeee(3);
            // employeeoperation.UpdateEmployee(employee1);
            //  employeeoperation.GetAllEmployee();
        }

    }
}