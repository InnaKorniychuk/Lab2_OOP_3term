using DAL;
using System;

namespace BLL
{
    internal static class Functions
    {
        public static void Add(out double xa, out double ya, out double xb, out double yb, out string colour)
        {
            Console.WriteLine("----Adding----");
            Console.Write("Point a.x: ");
            xa = double.Parse(Console.ReadLine());
            Console.Write("Point a.y: ");
            ya = double.Parse(Console.ReadLine());
            Console.Write("Point b.x: ");
            xb = double.Parse(Console.ReadLine());
            Console.Write("Point b.y: ");
            yb = double.Parse(Console.ReadLine());
            Console.Write("Colour: ");
            colour = Console.ReadLine();
        }
        public static void Remove(out int index)
        {
            Console.WriteLine("----Removing----");
            Console.Write($"Number of item to delete: ");
            index = int.Parse(Console.ReadLine());
        }
        public static void Find(out double x, out double y, out string colour)
        {
            Console.WriteLine("----Finding----");
            Console.WriteLine("Enter information to find element");
            Console.Write("X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Colour: ");
            colour = Console.ReadLine();

        }
        public static void Update(out int index, out double xa, out double ya, out double xb, out double yb,
            out string colour)
        {
            Console.WriteLine("----Updating----");
            Console.Write($"Number of item to update: ");
            index = int.Parse(Console.ReadLine());
            Console.Write("New a.x: ");
            xa = double.Parse(Console.ReadLine());
            Console.Write("New a.y: ");
            ya = double.Parse(Console.ReadLine());
            Console.Write("New b.x: ");
            xb = double.Parse(Console.ReadLine());
            Console.Write("New b.y: ");
            yb = double.Parse(Console.ReadLine());
            Console.Write("New colour: ");
            colour = Console.ReadLine();
        }
        public static void BinaryTreeOperations()
        {
            BinaryTree<Vector> tree = new BinaryTree<Vector>(new Vector(0, 0, 25, 25, "blue"));
            tree.Insert(new Vector(0, 2, 16, 18, "pink"));
            tree.Insert(new Vector(2, 1, 12, 65, "green"));
          
            tree.Print();
        }
    }
}
