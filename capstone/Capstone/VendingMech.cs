using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Capstone
{
    public class VendingMech : Products
    {
        public Dictionary<string, int> ProductQuantityDictionary { get; set; } = new Dictionary<string, int>()
        {
            { "A1", 5 },
            { "A2" , 5 },
            { "A3", 5 },
            { "A4" , 5 },
            { "B1", 5 },
            { "B2" , 5 },
            { "B3", 5 },
            { "B4" , 5 },
            { "C1", 5 },
            { "C2" , 5 },
            { "C3", 5 },
            { "C4" , 5 },
            { "D1", 5 },
            { "D2" , 5 },
            { "D3", 5 },
            { "D4" , 5 }
        };
        public decimal VendingMechBalance { get; set; } = 0.00M;

        //int ValueDerement = 5;
        public void MainMenu()
        {
           

            Console.Clear();
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine();
            Console.WriteLine("Plese make selection:");
            //Console.Clear();

        }

        

        public void PuchaseMenu()
        {
            Console.Clear();
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            Console.WriteLine();
            Console.WriteLine("Plese make selection:");
            Console.WriteLine();
            Console.WriteLine($"Current Money Provided: { VendingMechBalance}");
            string menuSelection = Console.ReadLine();
            if (menuSelection == "1")
            {
                FeedMoneyMenu();

            }
            else if(menuSelection == "2")
            {
                SelectProductMenu();
            }
            else if(menuSelection == "3")
            {
                FinishTransactionMenu();
            }
           

        }

        private void FinishTransactionMenu()
        {
            throw new NotImplementedException();
        }

        public decimal FinishTransactionMenu(decimal vendingbalance)
        {
            Console.Clear();
            Console.WriteLine("Would you like your change? (y) (n)");
            Console.WriteLine("Press (n) to return to the Purchase Menu");
            string changeDespnce = Console.ReadLine();

            try
            {

                if (changeDespnce == "y")
                {

                    Console.Clear();
                    decimal change = VendingMechBalance;
                    MakeChange(change);
                    //Console.ReadLine();
                    //Moved Give Change log because it was never firing
                    VendingMechBalance = 0.00m;
                    vendingbalance = VendingMechBalance;
                    //MainMenu();



                }
                
                else
                {

                    vendingbalance = VendingMechBalance;

                }
                return vendingbalance;
            }
            catch(IOException)
            {
                return vendingbalance;
            }
           




        }

        public decimal MakeChange(decimal change)
        {
            GiveChangeLog(VendingMechBalance, "0.00");
            
            int[] coins = { 25, 10, 5, 1 };
            int amount, count, i;
            amount = Convert.ToInt32(VendingMechBalance * 100);
            Console.WriteLine();
            for (i = 0; i < coins.Length; i++)
            {
                count = amount / coins[i];
                if (count != 0)
                    Console.WriteLine("Count of {0} cent(s) :{1}", coins[i], count);
                amount %= coins[i];
                change = 0.00M;
            }
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            return change;
          
        }



        public void ExitMenu()
        {
            Console.Clear();
            Console.WriteLine("Thank You, Enjoy Your Day");
            // In while loop

        }

        //FEED MONEY TEST
        //CHECK CURRENTMONEYPROVIDED IS UPDATING IS UPDATING VENDINGMECHBALANCE 
        //Adding still off
        public void FeedMoneyMenu()
        {
            try
            {
                decimal addZero = 0.00M;
                bool AddingMoney = false;
                while (AddingMoney == false)
                {
                    Console.Clear();
                    Console.WriteLine($"Current Money Provided: {VendingMechBalance}");
                    Console.WriteLine("$1, $2, $5, or $10.");
                    Console.Write("Enter Ammout: $");
                    int dollarAmmount = int.Parse(Console.ReadLine());
                    decimal currentMoneyProvided = ((decimal)dollarAmmount + addZero);
                    //decimal currentMoneyProvided = decimal.Parse(Console.ReadLine());
                    
                    //decimal currentMoneyProvided = decimal.Parse(Console.ReadLine()) + addZero;
                    Console.WriteLine();


                    Console.WriteLine("Are you sure? (y) or (n)");
                    string addingMoneyInput = Console.ReadLine();
                    Console.WriteLine();

                    if (addingMoneyInput == "y")
                    {
                        VendingMechBalance += currentMoneyProvided;
                        AddingMoney = true;
                        FeedMoneyLog(VendingMechBalance, @currentMoneyProvided);
                        PuchaseMenu();
                    }
                    else if(addingMoneyInput == "n")
                    {
                        
                        Console.WriteLine($"Current Money Provided: { VendingMechBalance}");
                        //Add a method that will print out the money added to the 
                        FeedMoneyMenu();

                    }
                 

                }


            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("whole ammout only");
                FeedMoneyMenu();
                

            }   


            




        }

        public void SelectProductMenu()
        {

            Console.Clear();

            
            //bool stillSelecting = false;

           
            
                try
                {
                    ProductDisplay();


                    Console.WriteLine("-----------------------");
                    Console.WriteLine();
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Current Money Provided: { VendingMechBalance}");
                    Console.WriteLine();
                    Console.Write("Make your selection: "); 
                  
                    string productSelectionInput = Console.ReadLine().ToUpper();

                    Item item = new Item();

                  int five = 0;
                   foreach (KeyValuePair<string, int> product in ProductQuantityDictionary) //System.InvalidOperationException: 'Collection was modified; enumeration operation may not execute.'
                   { 

                    
                    
                        if (product.Key == productSelectionInput.ToUpper())
                        {

                                five = product.Value-1;
                                 item.Position = product.Key;

                        }
                        
                        if (product.Value == 0 && product.Key == productSelectionInput.ToUpper())
                        {
                            Console.Clear();
                            Console.WriteLine("Sold Out...");
                            Thread.Sleep(2000);
                            PuchaseMenu();
                            //Thread.Sleep(2000);
                        }
                    


                   }
                   if(productSelectionInput != item.Position)
                   {
                    Console.Clear();
                    Console.WriteLine("Invalid Input...");
                    Thread.Sleep(2000);
                    PuchaseMenu();
                   }
                    ProductQuantityDictionary[productSelectionInput] = five;
            
                    Dispensing(productSelectionInput);
                    


            }
            catch (IOException e)
                {
                  Console.WriteLine("Error reading the file");
                  Thread.Sleep(2000);
                  Console.WriteLine(e.Message);
                  PuchaseMenu();
                }






         


        }


        //Make Method to despence items
        public void Dispensing(string productSelection)
        {
            Item item = new Item();

            Console.Clear();
            const string relativeFileName = @"..\..\..\..\vendingmachine.csv";
            string directory = Environment.CurrentDirectory;
            string filename = Path.Combine(directory, relativeFileName);
            string fullPath = Path.GetFullPath(filename);

            try
            {
          
                
                 
                        using (StreamReader sr = new StreamReader(fullPath))
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = "";

                                line = sr.ReadLine();

                                string[] itemsArray = line.Split('|');

                                decimal trueCost = decimal.Parse(itemsArray[2]);

                                if (VendingMechBalance >= trueCost)
                                {
                                    if (productSelection == itemsArray[0])
                                    {
                                        item.Name = itemsArray[1];
                                        item.Price = decimal.Parse(itemsArray[2]);
                                        item.Type = itemsArray[3];
                                        item.Position = itemsArray[0];
                                    }




                                }




                            }
                            decimal testBalance = VendingMechBalance - item.Price;
                            ProductSelctionLog(item.Name, item.Position, VendingMechBalance, testBalance);
                        }

                        VendingMechBalance -= item.Price;
                        if (item.Type == "Chip")
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine($"Item: {item.Name} Price: ${item.Price} Balance: ${VendingMechBalance}: Crunch Crunch, Yum! ");

                        }
                        else if (item.Type == "Candy")
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine($"Item: {item.Name} Price: ${item.Price} Balance: ${VendingMechBalance}: Munch Munch, Yum! ");



                        }
                        else if (item.Type == "Drink")
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine($"Item: {item.Name} Price: ${item.Price} Balance: ${VendingMechBalance}: Glug Glug, Yum! ");
                        }
                        else if (item.Type == "Gum")
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine($"Item: {item.Name} Price: ${item.Price} Balance: ${VendingMechBalance}: Chew Chew, Yum! ");
                        }
                        Console.WriteLine();
                         Thread.Sleep(3000);
                        FinishTransactionMenu();
                       PuchaseMenu();


                    
                
            }
            catch (IOException e)
            {


                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            
            
            //Console.WriteLine("Would you like to make another selection? (y) (n)");
            //string andotherItem = Console.ReadLine();
            //if(andotherItem == "y")
            //{
            //    PuchaseMenu();
            //}
            //else
            //{
            //    FinishTransactionMenu();
            //}
        }
        public void ProductDisplay()
        {
            Console.Clear();
            const string relativeFileName = @"..\..\..\..\vendingmachine.csv";
            string directory = Environment.CurrentDirectory;
            string filename = Path.Combine(directory, relativeFileName);
            string fullPath = Path.GetFullPath(filename);

            List<string> allWords = new List<string>();

            try
            {
                string test = "";
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        foreach (KeyValuePair<string, int> product in ProductQuantityDictionary)
                        {
                            string line = "";
                            line = sr.ReadLine();
                            


                            Console.WriteLine($" {line}| Remaining:{product.Value} ");
                        }

                        
                      
                    }
                   
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }

        }






    }
}
