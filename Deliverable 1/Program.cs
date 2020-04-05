using System;

namespace Deliverable_1
{
    class Program
    {

        private static void Main(string[] args)
        {
            string vacationType;
            int groupSize;
            string result;
            string destination = ""; // equals a "blank word"
            string tType = ""; // equals a "blank word"


            Console.WriteLine("What type of vacation would you like to go on? Musical, Adventurous, or Tropical?");

            vacationType = Console.ReadLine();
            

            if (vacationType == "Musical")
            {
                destination = "New Orleans";
                
            }

            else if (vacationType == "Adventurous")
            {
                destination = "Whitewater Rafting the Grand Canyon";
            }

            else if (vacationType == "Tropical")
            {
                destination = "Beach Vacation in Mexico";
            }

            else
            {
                Console.WriteLine("That is not a valid vacation type.");
            }

            Console.WriteLine("How many people are coming with you? 1-2, 3-5, or 6+");

            groupSize = int.Parse(Console.ReadLine());

            if (groupSize > 0 && groupSize <= 2)
            {
                tType = "First Class";
            }

            else if (groupSize > 2 && groupSize <= 5)
            {
                tType = "Helicopter";
            }

            else if (groupSize >= 6)
            {
                tType = "Charter Flight";
            }

            else
            {
                Console.WriteLine("That is not a valid travel type.");
            }

            result = "since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + tType + " to " + destination;
            Console.WriteLine(result);


      
        }        
        
    
        
    }

           
          
}
