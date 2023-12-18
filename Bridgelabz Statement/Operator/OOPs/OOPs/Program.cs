using OOPs.DataInventoryManagement;
using OOPs.InventoryManagement;
using System;
using System.Security.AccessControl;

namespace OOPs
{
    class program
    {
        static string inventory_filepath = @"D:\Bridgelabz Statement\Operator\OOPs\OOPs\Inventory Mangement\InventoryMangementData.json";
        static void Main()
        {
            InventoryManagementOperation details = new InventoryManagementOperation();
            details.ReadInventoryJson(inventory_filepath);
            Console.WriteLine("\nWrite What crop Has been to added \nRice,Wheat(or)Pulses");
            string crop = Console.ReadLine();
            Console.WriteLine("Enter the Name,Weight and PriceperKg");
            details.AddInventoryManagement(crop);
            details.WriteToJsonFile(inventory_filepath);
        }
    }
}