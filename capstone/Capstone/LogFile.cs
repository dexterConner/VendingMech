using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class LogFile 
    {

        //Feed money
        public void FeedMoneyLog(decimal startingBalance, decimal endingBalance )
        {
            //const string relativeFileName = @"......\words.csv";
            //const string relativeFileName = @"..\..\..\words.csv";

            // string directory = @"C:\Users\Student\workspace\mod-1-capstone-orange-team-8\capstone\Capstone\LogFile\LogFile.txt";
            const string relativeFileName = @"..\..\..\..\Logfile.txt";
            string directory = Environment.CurrentDirectory;
            string filename = Path.Combine(directory, relativeFileName);
            string fullPath = Path.GetFullPath(filename);

            // After the using statement ends, file has now been written
            // and closed for further writing
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine($"{DateTime.Now} FEED MONEY: ${startingBalance} : ${endingBalance}");
                //UtcNow - Use for timezone and programming language compatability. 


                //Print Hello World!
               
            }

        }



        //Product Selection
        public void ProductSelctionLog(string productSelction, string slotNumber, decimal startingBalance, decimal endingBalance)
        {
            //const string relativeFileName = @"......\words.csv";
            //const string relativeFileName = @"..\..\..\words.csv";

            // string directory = @"C:\Users\Student\workspace\mod-1-capstone-orange-team-8\capstone\Capstone\LogFile\LogFile.txt";
            const string relativeFileName = @"..\..\..\..\Logfile.txt";
            string directory = Environment.CurrentDirectory;
            string filename = Path.Combine(directory, relativeFileName);
            string fullPath = Path.GetFullPath(filename);


            // After the using statement ends, file has now been written
            // and closed for further writing
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine($"{DateTime.Now} {productSelction} {slotNumber} ${startingBalance}  ${endingBalance}");
                //UtcNow - Use for timezone and programming language compatability. 


                //Print Hello World!

            }

        }


        //Give Change
        public void GiveChangeLog(decimal startingBalance, string endingBalance)
        {
            //const string relativeFileName = @"......\words.csv";
            //const string relativeFileName = @"..\..\..\words.csv";

            // string directory = @"C:\Users\Student\workspace\mod-1-capstone-orange-team-8\capstone\Capstone\LogFile\LogFile.txt";
            const string relativeFileName = @"..\..\..\..\Logfile.txt";
            string directory = Environment.CurrentDirectory;
            string filename = Path.Combine(directory, relativeFileName);
            string fullPath = Path.GetFullPath(filename);


            // After the using statement ends, file has now been written
            // and closed for further writing
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine($"{DateTime.Now} GIVE CHANGE: ${startingBalance} : ${endingBalance}");
                //UtcNow - Use for timezone and programming language compatability. 


                //Print Hello World!

            }

        }



    }
}
