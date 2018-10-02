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

            Room hallway = new Room() { Name = "Hallway", HasBeenChecked = false };
            TheHouse.Add(hallway);

            Room upstairsBedrooms = new Room() { Name = "Upstairs Bedrooms", HasBeenChecked = false };
            TheHouse.Add(upstairsBedrooms);

            Room masterBthRm = new Room() { Name = "Master Bathroom", HasBeenChecked = false };
            TheHouse.Add(masterBthRm);

            Room hallwayGstBthRm = new Room() { Name = "Hallway Guest Bathroom", HasBeenChecked = false };
            TheHouse.Add(hallwayGstBthRm);

            Room upstairsBthRm = new Room() { Name = "Upstairs Bathroom", HasBeenChecked = false };
            TheHouse.Add(upstairsBthRm);

            //Beginning of Open House
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


            bool selectedRoom = true;
            while (selectedRoom == true)//foreach loop only gave number of choices = TheHouse list so it ran counter to your decision to let user revisit rooms. While loop with bool breaks out of switch on default case only.
            {
                bool roomCounter = false;//changed to bool. Same functionality. I'm not sure why a bool over an int counter. Let's just say it's optimization
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
                        //added background color change so white text becomes visible
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("This is the " + masterBedRm.Name);
                        Console.WriteLine("Here we have a king size bed with space for two small end tables to\neither side.");
                        Console.WriteLine("There is a door on the far side from where we went entered that leads\nto the Master Bathroom.");
                        Console.WriteLine("Currently, there are two medium sized dressers on either side of the\nroom for both partners.");
                        Console.WriteLine("There is a cable outlet to allow for a TV to be plugged and sit atop\na fixture or be mounted onto the wall.");
                        Console.ReadLine();
                        roomCounter = true;
                        masterBedRm.HasBeenChecked = true;
                        break;
                    case "2":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("This is the " + livingRoom.Name);
                        Console.WriteLine("Here we have a large floor space with hardwood floors that were done as a recent remodel.");
                        Console.WriteLine("There is a marble exterior fireplace that you can use to help keep you warm during those cold winter nights.");
                        Console.WriteLine("We can see a large gateway opening that leads to the Dining Room.");
                        Console.WriteLine("The three windows face the front of the house and can allow for some decent natural lighting should you choose to use it.");
                        Console.ReadLine();
                        roomCounter = true;
                        livingRoom.HasBeenChecked = true;
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("This is the " + kitchen.Name);
                        Console.ReadLine();
                        roomCounter = true;
                        kitchen.HasBeenChecked = true;
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("This is the " + diningRoom.Name);
                        Console.ReadLine();
                        roomCounter = true;
                        diningRoom.HasBeenChecked = true;
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("This is the " + hallway.Name);
                        Console.ReadLine();
                        roomCounter = true;
                        hallway.HasBeenChecked = true;
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("This is the " + upstairsBedrooms.Name);
                        Console.ReadLine();
                        roomCounter = true;
                        upstairsBedrooms.HasBeenChecked = true;
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("This is the " + masterBthRm.Name);
                        Console.ReadLine();
                        roomCounter = true;
                        masterBthRm.HasBeenChecked = true;
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("This is the " + hallwayGstBthRm.Name);
                        Console.ReadLine();
                        roomCounter = true;
                        hallwayGstBthRm.HasBeenChecked = true;
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("This is the " + upstairsBthRm.Name);
                        Console.ReadLine();
                        roomCounter = true;
                        upstairsBthRm.HasBeenChecked = true;
                        break;
                    default: selectedRoom = false;
                        break;
                }
                if (roomCounter == false)
                {
                    break;
                }
            }
            Console.Clear();
            //Start of new Adventure

            Console.WriteLine("Narrator: As the Open House winds down you wander around as your spouse talks to the realtor.");
            Console.WriteLine("You remember seeing an unmentioned storm shelter doors outside in the backyard.");
            Console.WriteLine("You venture out into the backyard and investigate the storm shelter.");
            Console.WriteLine("When you get to the bottom you see variouis cardboard makings of castles and Medieval looking villages.");
            Console.WriteLine("Tons of nerdy looking posters litter the walls with a peculiar looking door at the opposite end from where you climbed down.");
            Console.WriteLine("As you make your way to the door you notice that just to the right is a crudely painted Santa Claus made to look like an old wizard.");
            Console.WriteLine("There is one poster somewhat falling off the wall behind Wizard Claus that reads \"It's dangerous to go alone. Take this.\"");
            Console.WriteLine("At the feet of Wizard Claus are two chests labeled \"Melee\" and \"Magic\".");
            Console.WriteLine("Which do you choose?");
            userResponse = Console.ReadLine();
            if (userResponse.ToUpper() == "MELEE")
            {
                Console.Clear();
                Console.WriteLine("You open the chest and find a Longsword and Shield.");
                Console.WriteLine("The door then slides open in front of you.");
                Console.WriteLine("You are compelled to walk in where the door closes behind you.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ominous Voice: \"Welcome to the Labyrinth! In order to leave, you must defeat the Minotaur at the end.");
                Console.WriteLine("Good luck!");     
            }
            else if (userResponse.ToUpper() == "MAGIC")
            {
                Console.Clear();
                Console.WriteLine("You open the chest and find a wooden staff that gleams with bright colors.");
                Console.WriteLine("You feel a warm energy fill you as you seem to suddenly know what true magic is.");
                Console.WriteLine("The door then slides open in front of you.");
                Console.WriteLine("You are compelled to walk in where the door closes behind you.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ominous Voice: \"Welcome to the Labyrinth! In order to leave, you must defeat the Minotaur at the end.");
                Console.WriteLine("Good luck!");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n<LabyrinthGameStart.exe>");
            Console.ReadLine();
        }
    }
}
