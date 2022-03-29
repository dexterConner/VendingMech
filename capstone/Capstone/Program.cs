using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Make all the Values in the Dic = 5
           
            
            bool isShoppings = true;
            //int menuNumber = int.Parse(menuSelection);
            try
            {
                while (isShoppings)
                {
                    VendingMech vendingMech = new VendingMech();

                    vendingMech.MainMenu();
                    string menuSelection = Console.ReadLine();

                    if (menuSelection == "1")
                    {
                        Console.Clear();
                        vendingMech.ProductDisplay();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("YOU WILL BE RETURNED TO THE MAIN MENU SHORTLY...");
                        Thread.Sleep(7000);
                        //Console.ReadLine();
                        //vendingMech.MainMenu();

                    }
                    else if (menuSelection == "2")
                    {
                        vendingMech.PuchaseMenu();
                    }
                    else if (menuSelection == "3")
                    {
                        vendingMech.ExitMenu();
                        Thread.Sleep(4000);
                        isShoppings = false; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }

               
            }
            catch(InvalidDataException invalid)
            {
                Console.WriteLine("invalid");
                Console.WriteLine(invalid.Message);
            }
            catch (NullReferenceException empty)
            {
                Console.WriteLine("Must insert word.");
                Console.WriteLine(empty.Message);
            }
            Console.ReadLine();
        }
      
    }
}
