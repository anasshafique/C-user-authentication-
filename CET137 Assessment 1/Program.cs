using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CET137_Assessment_1
{
    internal class Program
    {
        static void MenuOptions() // Shows menu options to the user.
        {
            Console.WriteLine();

            Console.WriteLine("                                            Welcome to the the Application");

            Console.WriteLine();

            Console.WriteLine("Given below are some menu choices you would want to select from:");

            Console.WriteLine();

            Console.WriteLine("To Register your account press '1'");
            Console.WriteLine("To Login press                 '2'");
            Console.WriteLine("To quit program press          '0'");

            Console.WriteLine();
        }

        static int MenuVerification() // Validates the menu choice.
        {
            int ichoice;

            while (true) // To keep the program running.

            {
                Console.Write("Choice: "); if (!int.TryParse(Console.ReadLine(), out ichoice)) // To avoid errors and make sure the user input an integer.

                {

                    Console.WriteLine("Invalid input. Please enter a valid input");

                }

                else if (ichoice < 0 || ichoice > 2) // Verifies the range to avoid errors.

                {

                    Console.WriteLine("Please enter a valid choice");

                }

                else

                {

                    break; // Breaks the loop if nothing above is true.

                }

            }

            Console.Clear();

            return ichoice; // The value stored in ichoice will be sent to main function.
        }

            static void Main(string[] args)

            {

            int ichoice;

            Account account = new Account(); // Created the instance account

            while (true)
            {
                MenuOptions();

                ichoice = MenuVerification();

                if (ichoice == 0)
                {
                    Console.WriteLine("Program Existed");

                    Console.WriteLine();

                    Console.WriteLine("Thank you for using the Application, Goodbye!");
                    break;

                }

                switch (ichoice)
                {
                    case 1: //Classes are being called.

                        account.Registeration();
                        account.UsernameValidation();
                        account.PasswordValidation();

                        break;

                    case 2:

                        account.Login();

                        break;

                }
            }

            Console.ReadKey();
        } 
    }  
}














































//if (susername != susername + ".TXT")
//{
//    break;
//}
//using (StreamReader sr = new StreamReader("DONATIONS.TXT"))
//{

//    while (sr.Peek() != -1) // while more data to read
//    {
//        amostusedpass = sr.ToStri
//        Console.WriteLine(sName);
//        dmoney = Convert.ToDouble(sr.ReadLine());
//        Console.WriteLine(dmoney);

//        //string donationLine = sr.ReadLine(); // Read donation line
//        //Console.WriteLine(donationLine); // Display donation line as-is


//    }












//if(spassword == amostusedpass)
//{

//}
//readpass.Length > 1

