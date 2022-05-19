using System;
using System.Text.RegularExpressions;

namespace cSharp_consoleApp_homeWork_1
{
    internal class Switch
    {
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                bool loggedIn = false;
                string userName = "0";
                string passWord = "0";
                string userEmail = null;
                string userFname = null;
                string userLname = null;
                int? userAge = null;

                // logged out
                while (loggedIn == false)
                {
                    Console.Clear();
                    Console.WriteLine("1. Sign in");
                    Console.WriteLine("2. Sign up");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine();
                    Console.Write("Select an option number:");
                    string select = Console.ReadLine();

                    switch (select)
                    {
                        // exit
                        case "0":
                            {
                                Environment.Exit(0);
                            }
                            break;
                        // sign in
                        case "1":
                            {
                                Console.WriteLine();
                                Console.Write("Type your username: ");
                                string checkingUserName = Console.ReadLine();
                                Console.Write("Type your password: ");
                                string checkingPassWord = Console.ReadLine();

                                // checking
                                if (checkingUserName == userName && checkingPassWord == passWord)
                                {
                                    loggedIn = true;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect username or password! Please, try again or sign up.");
                                    Console.ReadLine();
                                }
                            }
                            break;
                        // sign up
                        case "2":
                            {
                                Console.WriteLine();
                                Console.Write("Type new username: ");
                                string chekingUserName = Console.ReadLine();

                                // validation
                                if (!Regex.Match(chekingUserName, "^[a-zA-Z0-9]+$").Success)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid username format! Only letters and numbers are allowed.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    userName = chekingUserName;
                                    Console.Write("Type new password: ");
                                    passWord = Console.ReadLine();
                                }
                            }
                            break;
                        // other
                        default:
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid value! The only existing option number are allowed.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
                // logged in
                while (loggedIn == true)
                {
                    var validEmail = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

                    Console.Clear();
                    Console.WriteLine($"Hello, {userName}!");
                    Console.WriteLine();
                    Console.WriteLine("Your current profile is:");
                    Console.WriteLine($"Email: {userEmail}");
                    Console.WriteLine($"First name: {userFname}");
                    Console.WriteLine($"Last name: {userLname}");
                    Console.WriteLine($"Age: {userAge}");
                    Console.WriteLine();
                    Console.WriteLine("1. Edit profile");
                    Console.WriteLine("0. Delete profile");
                    Console.WriteLine();
                    Console.Write("Select an option number:");
                    string select = Console.ReadLine();

                    switch (select)
                    {
                        // delete
                        case "0":
                            {
                                userName = "0";
                                passWord = "0";
                                userEmail = null;
                                userFname = null;
                                userLname = null;
                                userAge = null;
                                loggedIn = false;
                            }
                            break;
                        // edit
                        case "1":
                            {
                                Console.Clear();
                                Console.WriteLine("1. Edit username");
                                Console.WriteLine("2. Edit password");
                                Console.WriteLine("3. Edit email");
                                Console.WriteLine("4. Edit first name");
                                Console.WriteLine("5. Edit last name");
                                Console.WriteLine("6. Edit age");
                                Console.WriteLine("0. Back");
                                Console.WriteLine();
                                Console.Write("Select an option number:");
                                string selectEdit = Console.ReadLine();

                                switch (selectEdit)
                                {
                                    // back
                                    case "0":
                                        {
                                            break;
                                        };
                                    // username
                                    case "1":
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Your current username is: {userName}");
                                            Console.Write("Type your new username: ");
                                            string chekingUserName = Console.ReadLine();

                                            // validation
                                            if (!Regex.Match(chekingUserName, "^[a-zA-Z0-9]+$").Success)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid username format! Only letters and numbers are allowed.");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                userName = chekingUserName;
                                                Console.WriteLine();
                                                Console.WriteLine($"Your current username was set to: {userName}");
                                                Console.ReadLine();
                                            }
                                        }
                                        break;
                                    // password
                                    case "2":
                                        {
                                            Console.WriteLine();
                                            Console.Write("Type your current password: ");
                                            string checkingPassWord = Console.ReadLine();

                                            // checking
                                            if (checkingPassWord == passWord)
                                            {
                                                Console.WriteLine();
                                                Console.Write("Type your new password: ");
                                                passWord = Console.ReadLine();
                                                ClearLine();
                                                Console.WriteLine("Your current password successfully updated.");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Incorrect password! Please, try again.");
                                                Console.ReadLine();
                                            }
                                        }
                                        break;
                                    // email
                                    case "3":
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Your current email is: {userEmail}");
                                            Console.Write("Type your new email: ");
                                            string chekingEmail = Console.ReadLine();

                                            // validation
                                            if (Regex.IsMatch(chekingEmail, validEmail, RegexOptions.IgnoreCase))
                                            {
                                                userEmail = chekingEmail;
                                                Console.WriteLine();
                                                Console.WriteLine($"Your current email was set to: {userEmail}");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid email format! Please, try again. For example: 'username@gmail.com'");
                                                Console.ReadLine();
                                            }
                                        }
                                        break;
                                    // first name
                                    case "4":
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Your current first name is: {userFname}");
                                            Console.Write("Type your new first name: ");
                                            string chekingFirstName = Console.ReadLine();

                                            // validation
                                            if (!Regex.Match(chekingFirstName, "^[A-Z][a-z]*$").Success)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid first name format! Only letters are allowed. The first letter must be in uppercase.");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                userFname = chekingFirstName;
                                                Console.WriteLine();
                                                Console.WriteLine($"Your current first name was set to: {userFname}");
                                                Console.ReadLine();
                                            }
                                        }
                                        break;
                                    // last name
                                    case "5":
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Your current last name is: {userLname}");
                                            Console.Write("Type your new last name: ");
                                            string chekingLastName = Console.ReadLine();

                                            // validation
                                            if (!Regex.Match(chekingLastName, "^[A-Z][a-z]*$").Success)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid last name format! Only letters are allowed. The first letter must be in uppercase.");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                userLname = chekingLastName;
                                                Console.WriteLine();
                                                Console.WriteLine($"Your current last name was set to: {userLname}");
                                                Console.ReadLine();
                                            }
                                        }
                                        break;
                                    // user age
                                    case "6":
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Your current age is: {userAge}");
                                            Console.Write("Type your date of birth in the 'yyyy,mm,dd' format: ");
                                            string strUserBdate = Console.ReadLine();

                                            //validation
                                            try
                                            {
                                                DateTime userBdate = DateTime.Parse(strUserBdate);
                                                TimeSpan tmp = DateTime.Today - userBdate;
                                                userAge = (int)tmp.TotalDays / 366;
                                                ClearLine();
                                                Console.WriteLine("Your current age successfully updated.");
                                                Console.ReadLine();
                                            }
                                            catch
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid date format! The only 'yyyy,mm,dd' format is allowed.");
                                                Console.ReadLine();
                                            }
                                        }
                                        break;
                                    default:
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Invalid value! The only existing option number are allowed.");
                                            Console.ReadLine();
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
        }
    }
}
