using System;
using System.Collections.Generic;
using System.Threading;

namespace OpenHouse
{
    class Program
    {
        public static List<Room> TheHouse = new List<Room>();

        static void SpeakingDelay()
        {
            Thread.Sleep(2000);
        }

        static void ListOfAllRooms()
        {
            for (int i = 0; i < TheHouse.Count; i++)
            {
                if (TheHouse[i].HasBeenChecked == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(i + 1 + ") " + TheHouse[i].Name);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            Room masterBedRm = new Room() { Name = "Master Bedroom", HasBeenChecked = false };
            TheHouse.Add(masterBedRm);
            //masterBedRm.HasBeenChecked = true; <= this sets the room to be checked.

            Room livingRoom = new Room() { Name = "Living Room", HasBeenChecked = false };
            TheHouse.Add(livingRoom);

            Room kitchen = new Room() { Name = "Kitchen", HasBeenChecked = false };
            TheHouse.Add(kitchen);

            Room diningRoom = new Room() { Name = "Dining Room", HasBeenChecked = false };
            TheHouse.Add(diningRoom);

            Room basement = new Room() { Name = "Basement", HasBeenChecked = false };
            TheHouse.Add(basement);

            Room upstairsBedrooms = new Room() { Name = "Upstairs Bedrooms", HasBeenChecked = false };
            TheHouse.Add(upstairsBedrooms);

            Room masterBthRm = new Room() { Name = "Master Bathroom", HasBeenChecked = false };
            TheHouse.Add(masterBthRm);

            Room hallwayGstBthRm = new Room() { Name = "Hallway Guest Bathroom", HasBeenChecked = false };
            TheHouse.Add(hallwayGstBthRm);

            Room upstairsBthRm = new Room() { Name = "Upstairs Bathroom", HasBeenChecked = false };
            TheHouse.Add(upstairsBthRm);




            Console.WriteLine("Open House! \n123 Main Street \nSaturday September 29, 2065 \n ");
            Console.WriteLine("Would you like to attend?");

            string userResponse = Console.ReadLine();

            if (userResponse.ToUpper() == "Y" || userResponse.ToUpper() == "YES" ||
                userResponse.ToUpper() == "SURE" || userResponse.ToUpper() == "YEAH")
            {
                Console.WriteLine("\nGreat! \nWe will see you on Saturday!");
            }
            else
            {
                Console.WriteLine("\nYour spouse really wants to go.");
                SpeakingDelay();
                Console.WriteLine("So, guess what?");
                SpeakingDelay();
                Console.WriteLine("You're going.");
            }
            //Introduction to the list of rooms
            SpeakingDelay();
            Console.Clear();
            Console.WriteLine("Saturday, September 29, 2065 \n ");
            SpeakingDelay();
            Console.WriteLine("Hi! Welcome to the Open House. What is your name?");
            userResponse = Console.ReadLine();
            Console.WriteLine();

            Console.Clear();
            Console.WriteLine("Saturday, September 29, 2065 \n ");
            Console.WriteLine($"{userResponse}, it's nice to meet you!");
            SpeakingDelay();
            Console.WriteLine("My name is Angela and I am the realtor for this house.\nWhich room would you like to visit first?");


            bool selectedRoom = false;
            foreach (Room room in TheHouse)
            {
                int roomCounter = 0; //remove this placeholder when a better understanding of how to get this to work is found
                SpeakingDelay();
                if (selectedRoom == true)
                {
                    Console.Clear();
                    Console.WriteLine("Which room shall we see next?");
                }
                Console.WriteLine("(Please type number of the room)");
                ListOfAllRooms();
                userResponse = Console.ReadLine();
                switch (userResponse)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("This is the Master Bedroom.");
                        Console.WriteLine("Here we have a king size bed with space for two small end tables to\neither side.");
                        Console.WriteLine("There is a door on the far side from where we went entered that leads\nto the Master Bathroom.");
                        Console.WriteLine("Currently, there are two medium sized dressers on either side of the\nroom for both partners.");
                        Console.WriteLine("There is a cable outlet to allow for a TV to be plugged and sit atop\na fixture or be mounted onto the wall.");
                        Console.ReadLine();
                        selectedRoom = true;
                        roomCounter++;
                        masterBedRm.HasBeenChecked = true;
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("This is the Living Room.");
                        Console.WriteLine("Here we have a large floor space with hardwood floors that were done as a recent remodel.");
                        Console.WriteLine("There is a marble exterior fireplace that you can use to help keep you warm during those cold winter nights.");
                        Console.WriteLine("We can see a large gateway opening that leads to the Dining Room.");
                        Console.WriteLine("The three windows face the front of the house and can allow for some decent natural lighting should you choose to use it.");
                        Console.ReadLine();
                        roomCounter++;
                        selectedRoom = true;
                        livingRoom.HasBeenChecked = true;
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("This is the Kitchen.");
                        Console.ReadLine();
                        roomCounter++;
                        selectedRoom = true;
                        kitchen.HasBeenChecked = true;
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("This is the Dining Room.");
                        Console.ReadLine();
                        roomCounter++;
                        selectedRoom = true;
                        diningRoom.HasBeenChecked = true;
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("This is the Basement.");
                        Console.ReadLine();
                        roomCounter++;
                        selectedRoom = true;
                        basement.HasBeenChecked = true;
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("This is the Upstairs Bedrooms.");
                        Console.ReadLine();
                        roomCounter++;
                        selectedRoom = true;
                        upstairsBedrooms.HasBeenChecked = true;
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("This is the Master Bathroom.");
                        Console.ReadLine();
                        roomCounter++;
                        selectedRoom = true;
                        masterBthRm.HasBeenChecked = true;
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("This is the Hallway Guest Bathroom.");
                        Console.ReadLine();
                        roomCounter++;
                        selectedRoom = true;
                        hallwayGstBthRm.HasBeenChecked = true;
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("This is the Upstairs Bathroom.");
                        Console.ReadLine();
                        roomCounter++;
                        selectedRoom = true;
                        upstairsBthRm.HasBeenChecked = true;
                        break;
                    default:
                        break;
                }
                if (roomCounter == 0)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
