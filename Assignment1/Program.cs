using System;
using System.Collections.Generic;
using System.Text;
/**
 * DIFFERENCES BETWEEN C# AND JAVA
 * 1. Inheritance uses a semicolon between the sub class and super class instead of a keyword
 * 2. Overriding methods uses the "override" keyword instead of an override annotation
 * 3. C# has built in set and get keywords, Java does not
 * 4. Methods in C# use PascalCase, whereas Java uses camelCase as their conventions
 * 5. String is capital (an object) in Java, in C# it's lowercase (primitive).
**/

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            SuperDog superDog = new SuperDog();
            Chicken chicken = new Chicken();
            int input;
            string direction;

            while (true)
            {
                Console.WriteLine("What animal would you like?\n1. Dog\n2. SuperDog\n3. Chicken\n4. Quit");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("What would you like to do?\n1. Hear voice\n2. Move\n3. Quit");
                    input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.WriteLine(dog.GetVoice());
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Please pick a direction (up or down)");
                        direction = Console.ReadLine();
                        Console.WriteLine(dog.Move(direction));
                    }
                    else if (input == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option!");
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("What would you like to do?\n1. Hear voice\n2. Move\n3. Quit");
                    input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.WriteLine(superDog.GetVoice());
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Please pick a direction (up or down)");
                        direction = Console.ReadLine();
                        Console.WriteLine(superDog.Move(direction));
                    }
                    else if (input == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option!");
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("What would you like to do?\n1. Hear voice\n2. Move\n3. Quit");
                    input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.WriteLine(chicken.GetVoice());
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Please pick a direction (up or down)");
                        direction = Console.ReadLine();
                        Console.WriteLine(chicken.Move(direction));
                    }
                    else if (input == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option!");
                    }
                }
                else if (input == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid option!");
                }
            }
            Console.WriteLine("Thank you for using this program.");

        }
    }
}
