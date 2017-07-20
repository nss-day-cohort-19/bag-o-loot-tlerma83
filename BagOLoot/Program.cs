using System;
using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new DatabaseInterface();
            db.Check();

            Console.WriteLine ("WELCOME TO THE BAG O' LOOT SYSTEM");
            Console.WriteLine ("*********************************");
            Console.WriteLine ("1. Add a Child");
            Console.WriteLine ("2. Assign toy to a Child");
            Console.WriteLine ("3. Revoke Toy from Child");
            Console.WriteLine ("4. Review Child's toy list");
            Console.WriteLine ("5. Child Toy Delivery");
			Console.Write ("> ");

			// Read in the user's choice
			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);

            if (choice == 1)
            {
                Console.WriteLine ("Enter child name");
                Console.Write ("> ");
                string childName = Console.ReadLine();
                ChildRegister registry = new ChildRegister();
                bool childId = registry.AddChild(childName);
                Console.WriteLine(childId);
            }
            else if (choice == 2) {
                Console.WriteLine($"Enter the Id for the Child you wish to add a toy for");
                ChildRegister kidList = new ChildRegister();
                BagofLoot newBag = new BagofLoot();
                List<Child> kids = kidList.GetChildren();

                foreach (var item in kids)
                {
                    Console.WriteLine($"I am a motherfucking kid {item.name} here is my ID {item.childId}");
                }
                Console.Write($">");
                Console.WriteLine($"Choose child's ID to add toy");
                int childIDSlected = int.Parse(Console.ReadLine());

                Console.WriteLine($"Type the toy name for the child");
                Console.Write($">");

                string toyName = Console.ReadLine();
                Console.WriteLine($"This is what you typed {toyName}");
                newBag.AddToyToBag(toyName, childIDSlected);
            }else if (choice == 3) {
                ChildRegister kidList = new ChildRegister();
                BagofLoot newBag = new BagofLoot();
                List<Child> kids = kidList.GetChildren();
                foreach (var item in kids)
                {
                    Console.WriteLine($"{item.name} my ID is {item.childId}");
                }
                Console.WriteLine($"Enter ID for child you want to Revoke toy from");
                Console.Write($">");
                int childIDSelected = int.Parse(Console.ReadLine());
                List<Toy> toys = newBag.AllChildrenWithAToy(childIDSelected);
                foreach (var item in toys)
                {
                    Console.WriteLine($"Toy: {item.toyName}  ID: {item.toyId}");
                }
                Console.WriteLine($"Enter the toy ID to remove");
                int toyID = int.Parse(Console.ReadLine());
            }
        }
    }
}