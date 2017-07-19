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
            Console.WriteLine ("1. Add a child");
            Console.WriteLine ("2. Assign toy to a child");
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
        }
    }
}


// else if (choice == 2) {
//                 Console.WriteLine($"Enter toy to add to Jamal's Bag o' Loot");
//                 Console.WriteLine($">");
//                 string childToy = Console.ReadLine();
//                 ChildToyAdd addToChildList = new ChildToyAdd();
//                 bool toyAddedId = addToChildList.AddToy(childToy);
//                 Console.WriteLine($"This toy was added: {childToy} and it is {toyAddedId}");

//             }