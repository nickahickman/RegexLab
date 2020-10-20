using System;

namespace RegexRedux
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userEmail;
            string userPhoneNumber;
            string userDate;

            Console.WriteLine("Gimme all your info for very legal and legitimate purposes");
            MyLibs.ConsoleLibrary.DrawSeparator();

            while (true)
            {
                userName = MyLibs.UserInputLibrary.GetUserResponse("What's your name? Must begin with a capital letter and be fewer than 30 characters");
                while (!MyLibs.InputValidationLibrary.IsValidName(userName))
                {
                    userName = MyLibs.UserInputLibrary.GetUserResponse("That's an invalid name, try again.");
                }

                userEmail = MyLibs.UserInputLibrary.GetUserResponse("What's your email address? ex: name@mail.co");
                while (!MyLibs.InputValidationLibrary.IsValidEmail(userEmail))
                {
                    userEmail = MyLibs.UserInputLibrary.GetUserResponse("That's an invalid email, try again. ex: name@mail.co");
                }

                userPhoneNumber = MyLibs.UserInputLibrary.GetUserResponse("What's your phone number? xxx-xxx-xxxx");
                while (!MyLibs.InputValidationLibrary.IsValidPhoneNumber(userPhoneNumber))
                {
                    userPhoneNumber = MyLibs.UserInputLibrary.GetUserResponse("That's an invalid phone number, try again.");
                }

                userDate = MyLibs.UserInputLibrary.GetUserResponse("What's your birthdate? dd/mm/yyyy");
                while (!MyLibs.InputValidationLibrary.IsValidDate(userDate))
                {
                    userDate = MyLibs.UserInputLibrary.GetUserResponse("That's an invalid date, try again. dd/mm/yyyy");
                }

                if (!MyLibs.UserInputLibrary.UserWantsToContinue("Thanks! Want to give me someone else's information?", "I didn't understand that."))
                {
                    Console.WriteLine("Thanks for the info, I'll put it to very good use ;)");
                    break;
                }
            }
        }
    }
}
