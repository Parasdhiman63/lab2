using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass8040
{
    public class Rect
    {

        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Please select an option, by entering a number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                   userInput != "2" &&
                   userInput != "3" &&
                   userInput != "4" &&
                   userInput != "5" &&
                   userInput != "6" &&
                   userInput != "7")
                {
                    Console.WriteLine("That's not valid menu option, please enter again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }

            }

            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectSide} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input, please enter again:\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("number cannot be less than 0 please enter the value again.\n");
                }
                else
                {
                    isValid = true;
                    //Console.WriteLine($"Please enter the {rectSide} has been changed to{number}:\n");
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            Rectangle m = new Rectangle();
            bool validRectSelect = false;
            string rectSelection;
            int selection;

            while (validRectSelect == false)
            {
                Console.WriteLine("1 = Choose default rectangle\n");
                Console.WriteLine("2 = Enter random rectangle value\n");
                Console.WriteLine("Choose option from menu item to begin:");
                rectSelection = Console.ReadLine();
                Console.WriteLine();

                if (rectSelection != "1" && rectSelection != "2")

                {
                    Console.WriteLine("That's not a valid input. please enter the value again.\n");
                }
                else if (int.Parse(rectSelection) == 1)
                {
                    validRectSelect = true;
                    int length = 10;
                    int width = 20;
                    Console.WriteLine($"Length and width entered are {length} and {width}.\n");
                    Rectangle changeRect = new Rectangle(length, width);
                    m = changeRect;
                }
                else if (int.Parse(rectSelection) == 2)
                {
                    validRectSelect = true;

                    int length;
                    int Width;

                    length = ValidateUserInput("length");
                    Width = ValidateUserInput("width");

                    Console.WriteLine($"Length and width entered are {length} and {Width}.\n");
                    Rectangle changeRect = new Rectangle(length, Width);
                    m = changeRect;
                }
            }

            selection = ValidateMenuSelection();

            while (selection != 7)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Length is: {m.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("Length");
                        m.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width is: {m.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("Width");
                        m.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"Perimeter {m.GetLength() * 2} + {m.GetWidth() * 2} is: {m.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"Area {m.GetLength()} * {m.GetWidth()} is:{m.GetArea()}\n");
                        break;
                    default:
                        break;
                }
                selection = ValidateMenuSelection();
            }
        }
    }

}
