using System;
using System.Text.RegularExpressions;

namespace MyLibs
{
    public class UserInputLibrary
    {
        public static string GetUserResponse(string prompt)
        {
            string userResponse;

            Console.WriteLine(prompt);
            userResponse = Console.ReadLine().Trim();

            while (String.IsNullOrEmpty(userResponse))
            {
                Console.WriteLine("I need you to enter something. Silence isn't a virtue here!");
                userResponse = GetUserResponse(prompt);
            }

            return userResponse;
        }

        public static bool UserWantsToContinue(string originalQuery, string failResponse)
        {
            string userResponse = GetUserResponse($"{originalQuery}? (y/n)").ToLower(); ;

            while (userResponse != "n" && userResponse != "y")
            {
                userResponse = GetUserResponse($"{failResponse} {originalQuery} (y/n)").ToLower();
            }

            if (userResponse == "n")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class ConsoleLibrary
    {
        public static void DrawProgramTitle(string title)
        {
            Console.WriteLine(title);
            DrawSeparator();
        }
        public static void DrawSeparator()
        {
            Console.WriteLine("=========================================================================");
        }
    }

    public class GTKYC
    {
        public static void PrintAllStudents(string[,] students)
        {
            foreach (string student in students)
            {
                Console.WriteLine(student);
                ConsoleLibrary.DrawSeparator();
            }
        }

        public static string GetAllStudentProperties(string[] student)
        {
            string studentInfo = "";

            for (int i = 0; i < student.Length; i++)
            {
                if (i == 0)
                {
                    studentInfo += $"Name: {student[0]}";
                }
                else if (i == 1)
                {
                    studentInfo += $"Favorite food: {student[1]}";
                }
                else {
                    studentInfo += $"Hometown: {student[2]}";
                }
            }

            return studentInfo;
        }
    }
}
