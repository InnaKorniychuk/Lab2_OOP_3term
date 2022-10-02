using BLL;
using System;
public static class Menu
{
    public static void Start()
    {
        while (true)
        {
            Console.WriteLine("Select:\n 1. Non-generic collection (ArrayList)\n 2. Generic collection\n " +
                "3. Array\n 4. Binary tree\n 5. Exit");
            string command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    VectorArrayList.Operations();
                    break;
                case "2":
                    VectorCollection.Operations();
                    break;
                case "3":
                   VectorArray.Operations();
                    break;
                case "4":
                    Functions.BinaryTreeOperations();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Incorrect data");
                    break;
            }
        }
    }
}