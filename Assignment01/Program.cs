using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using System.Xml.Linq;
using System.Security;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this Enum.

            //Console.WriteLine("Days of the week:");

            //// Loop through the WeekDays Enum values using Enum.GetValues()
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Q2.Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. 
            ///Note
            ///range for seasons
            ///(spring march to may, summer june to august, autumn September to November, winter December to February)

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //// Using the generic TryParse<T>() method
            //Season selectedSeason;
            //bool isparsed = Enum.TryParse<Season>(input, true, out selectedSeason);
            //if (isparsed)
            //{
            //    switch (selectedSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}

            #endregion

            #region Q3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            #region Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable

            //Permissions userPermissions = new Permissions() ;

            //// Add permissions
            //userPermissions |= Permissions.Read;
            //Console.WriteLine($"Permissions after adding Read: {userPermissions}");

            //userPermissions |= Permissions.Write;
            //Console.WriteLine($"Permissions after adding Write: {userPermissions}");

            //// Check if a specific permission exists
            //if ((userPermissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("User has Write permission.");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have Write permission.");
            //}

            //// Remove a permission using XOR
            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    userPermissions ^= Permissions.Read;
            //    Console.WriteLine($"Permissions after removing Read: {userPermissions}");
            //}

            //// Check if a permission exists after removal
            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("User still has Read permission.");
            //}
            //else
            //{
            //    Console.WriteLine("User no longer has Read permission.");
            //}

            #endregion
            #endregion

            #region Q4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color :");
            //string input = Console.ReadLine();
            //Colors color;
            //bool isparsed = Enum.TryParse<Colors>(input , out color);

            //// Check if the input is a valid primary color
            //if (isparsed)
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}

            #endregion
        }
    }
}
