
using System; //Includes the classes for reading & writing to the console

namespace ZooLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to enter the number of animals and read in the number of animals
            Console.Write("Enter the number of animals in the zoo: ");
            int animalCount = int.Parse(Console.ReadLine());

            // Declare and initialize the array
            string[] animals = new string[animalCount];

            // Populate the array with user-defined animal names
            for (int i = 0; i < animalCount; i++)
            {
                //Prompt the user to enter the animal name and read the name
                Console.Write($"Enter animal name {i + 1}: ");
                animals[i] = Console.ReadLine();
            }//end loop

            //Display the list of animals using a for each loop
            Console.WriteLine("List of Zoo Animals: ");
            foreach(string animal in animals){
                Console.WriteLine(animal);
            }//end loop
        }//end main method
    }//end program class
}//end namespace
