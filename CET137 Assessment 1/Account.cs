using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CET137_Assessment_1
{
    internal class Account
    {

        private String susername;
        private String spassword;

        public void Registeration()  // Asks the user to enter username.
        {
            Console.WriteLine("********** Register your account *********");

            Console.WriteLine();

            Console.WriteLine("Enter your username and password");

            Console.WriteLine();

            Console.Write("Username: ");

            susername = Console.ReadLine(); 

        }

        public void UsernameValidation() // Validates the Username.
        {
            while (true) 

            {

                if (File.Exists(susername + ".TXT")) // Check if the file exists or not.

                {

                    Console.WriteLine("The username already exists. Enter a different username.");
                    Console.Write("Username: ");
                    susername = Console.ReadLine();

                }

                //else if (susername != susername + ".TXT")
                //{
                //    break;
                //}

                else

                {

                    break;

                }

            }

            using (StreamWriter sw = new StreamWriter(susername + ".TXT", true)) // Used to create a file with the name of the file being the username of account.

            {

                sw.WriteLine("username = " + susername);

            }
        }

        public void PasswordValidation() // Validates the password.
        {

            Console.WriteLine("Enter atleast 10-character password");

            Console.WriteLine();

            Console.Write("Password: ");
            spassword = Console.ReadLine();

            while (true) 

            {

                if (spassword.Length >= 10) // Verifies that the password is atleast 10 characters or more.

                {
                    break;
                }

                else

                {

                    Console.WriteLine("The password should be atleast 10-characters or more");

                    Console.WriteLine();

                    Console.Write("Password: ");
                    spassword = Console.ReadLine(); 

                }

            }

            String[] sostusedpass = File.ReadAllLines("Password.txt"); // Reads all of the lines in the password text file and stores that in amostusedpass array of datatype string.

            while (true) 

            {

                if (sostusedpass.Contains(spassword)) // Checks if the password file contains a similer password the the user entered or not.

                {

                    Console.WriteLine("The Password is too common use a different ones");

                    Console.WriteLine();

                    Console.Write("Password = ");
                    spassword = Console.ReadLine();
                }

                else

                {

                    break; 

                }
            }
            using (StreamWriter sw = new StreamWriter(susername + ".TXT", true)) // Writes the password in the file being the username of the account.

            {

                sw.WriteLine("Password = " + spassword);

            }

            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Account registered successfully!");

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");

            Console.ReadKey();

            Console.Clear();
        }

        public void Login() // User login to account.
        {
            Console.WriteLine("********** Login to your account *********");

            Console.WriteLine();

            Console.WriteLine("Enter your username and password to login");

            Console.WriteLine();

            Console.Write("Username: ");
            susername = Console.ReadLine();
            Console.Write("Password: ");
            spassword = Console.ReadLine();

            if (File.Exists(susername + ".TXT")) // Checks if the file being the username of the account exists or not.

            {

                String[] readpass = File.ReadAllLines(susername + ".TXT"); // Reads all of the lines in the text file being the username of the account and stores that in readpass array of datatype string.

                if (readpass[1].Contains(spassword)) // Check if the second line of the textfile contains the password or not.

                {



                    Console.Clear();

                    Console.WriteLine();

                    Console.WriteLine("You have successfully logged in!");

                    Console.WriteLine();

                    Console.WriteLine("Press any key to continue");

                    Console.ReadKey();

                    Console.Clear();

                }

                else

                {

                    Console.Clear();

                    Console.WriteLine();

                    Console.WriteLine("Incorrect Password");

                    Console.WriteLine();

                    Console.WriteLine("Press any key to continue");

                    Console.ReadKey();

                    Console.Clear();

                }


            }

            else

            {

                Console.Clear();

                Console.WriteLine();

                Console.WriteLine("Incorrect Username");

                Console.WriteLine();

                Console.WriteLine("Press any key to continue");

                Console.ReadKey();

                Console.Clear();
            }


        }
    }




}

