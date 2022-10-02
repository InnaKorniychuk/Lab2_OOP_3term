using DAL;
using System.Collections.Generic;
using System;

namespace BLL
{
    internal static class VectorCollection
    {
        static List<Vector> vectors = new List<Vector>(3);
        public static void Operations()
        {
            Console.WriteLine("Select:\n 1. Add\n 2. Show\n " +
              "3. Remove\n 4. Find\n 5. Update\n");
            string command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Show();
                    break;
                case "3":
                    Remove();
                    break;
                case "4":
                    Find();
                    break;
                case "5":
                    Update();
                    return;
                default:
                    Console.WriteLine("Incorrect data");
                    break;
            };
        }
        static void Add()
        {
            double xa, ya, xb, yb;
            string colour;
            Functions.Add(out xa, out ya, out xb, out yb, out colour);
            vectors.Add(new Vector(xa, ya, xb, yb, colour));
        }
        static void Remove()
        {
            int index;
            Functions.Remove(out index);
            if (index < 4)
                vectors.RemoveAt(--index);
        }
        static void Find()
        {
            double x, y;
            string colour;
            Functions.Find(out x, out y, out colour);
            Vector found = new Vector(x, y, colour);
            foreach (Vector vector in vectors)
            {
                if (vector.ToString().Equals(found.ToString()))
                {
                    Console.WriteLine($"Found element: {vector.ToString()}");
                }
                else
                {
                    Console.WriteLine("There is no such element.");
                }
            }
        }
        static void Update()
        {
            int index;
            double xa, ya, xb, yb;
            string colour;
            Functions.Update(out index, out xa, out ya, out xb, out yb, out colour);
            if (index < 3)
            {
                vectors.RemoveAt(--index);
                vectors.Insert(index, new Vector(xa, ya, xb, yb, colour));
            }
        }
        static void Show()
        {
            Console.WriteLine("----Showing----");
            foreach (Vector vector in vectors)
                Console.WriteLine($"{vector.ToString()}");
        }
    }
}