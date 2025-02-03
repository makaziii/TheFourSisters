class Program
{
    static void Main()
    {
        //entering the total number of eggs gathered that day
        Console.Write("Enter the total number of chocolate eggs gathered today: ");
        int totalEggs = Convert.ToInt32(Console.ReadLine());

        //calculating how many eggs each sister should get and how many are left for the duckbear
        int eggsPerSister = totalEggs / 4;
        int eggsForDuckbear = totalEggs % 4;

        //outputing the result
        Console.WriteLine("Each sister gets: " + eggsPerSister + " eggs.");
        Console.WriteLine("The duckbear gets: " + eggsForDuckbear + " eggs.");

        Console.WriteLine("\nThree total egg counts where the duckbear gets more eggs than each sister:");
        

        for (int count = 1; count <= 3; count++)
        {
            int newTotal = eggsPerSister * 4 + count;
            int newEggsForDuckbear = newTotal % 4;

            if (newEggsForDuckbear > eggsPerSister)
            {
                Console.WriteLine(newTotal);
            }
        }
    }
}


