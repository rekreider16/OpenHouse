using System;
using System.Collections.Generic;
using System.Threading;

namespace OpenHouse
{
    class Program
    {
        public static List<string> houseRooms = new List<string>();

        static void SpeakingDelay()
        {
            Thread.Sleep(2000);
        }

        static void HouseRooms()
        {
            houseRooms.Add("Master Bedroom");
            houseRooms.Add("Living Room");
            houseRooms.Add("Kitchen");
            houseRooms.Add("Dining Room");
            houseRooms.Add("Basement");
            houseRooms.Add("Upstairs Bedrooms");
            houseRooms.Add("Master Bathroom");
            houseRooms.Add("Hallway Guest Bathroom");
            houseRooms.Add("Upstairs Bathroom");
            Console.WriteLine("1) "+houseRooms[0]);
            Console.WriteLine("2) "+houseRooms[1]);
            Console.WriteLine("3) "+houseRooms[2]);
            Console.WriteLine("4) "+houseRooms[3]);
            Console.WriteLine("5) "+houseRooms[4]);
            Console.WriteLine("6) "+houseRooms[5]);
            Console.WriteLine("7) "+houseRooms[6]);
            Console.WriteLine("8) "+houseRooms[7]);
            Console.WriteLine("9) "+houseRooms[8]);
        }
        static void Main(string[] args)
        {
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
            SpeakingDelay();
            Console.WriteLine("\nSaturday, September 29, 2065 \n ");
            SpeakingDelay();            
            Console.WriteLine("Hi! Welcome to the Open House. What is your name?");
            
            userResponse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{userResponse}, it's nice to meet you!");
            Console.WriteLine("My name is Angela and I am the realtor for this house.\nWhich room would you like to visit first?");
            Console.WriteLine();
            Console.WriteLine("(Please type out the name of the room)");
            HouseRooms();
            Console.WriteLine();
            userResponse = Console.ReadLine();
            /*switch (userResponse)
            {
                case 1:

                default:
                    break;
            }



            //if (userResponse.T)


            //Console.ReadLine();
       */ }
    }
}
