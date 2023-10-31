using System;
using System.Runtime.InteropServices.ComTypes;

namespace InventoryManagementSystem;

public class Program
{
    
    
    public static int Main()
    {
        Console.WriteLine("Welcome to Your Inventory");
        Console.WriteLine("What do you want to do: ");
        Console.WriteLine("1. Add a product");
        Console.WriteLine("2. View all product");
        Console.WriteLine("3. Edit a product");
        Console.WriteLine("4. Delete a product");
        Console.WriteLine("5. Search for a product");
        Console.WriteLine("Write down the number of");
        Console.WriteLine("the command you want to do");
        Console.WriteLine("press anything else to exit");
        int comand = Console.Read();

        switch (comand)
        {
            case '1': 
                break;
            case '2': 
                break;
            case '3': 
                break;
            case '4':
                break;
            case '5':
                break;
            _ : 
                return 0;
        }


        return 0;
    }
}