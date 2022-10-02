using DAL;
using System.Collections.Generic;
using System;

namespace BLL
{
    internal static class VectorArray
    {
        static Vector[] vectors = new Vector[3];
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

            for (int i = 0; i < 3; i++)
            {
                double xa, ya, xb, yb;
                string colour;
                Functions.Add(out xa, out ya, out xb, out yb, out colour);
                try
                {
                    for (int j= 0; j < colour.Length; j++)
                    {
                        if ((colour[j] <= 65 || colour[j] >= 122) || (colour[j] >= 91 && colour[j] <= 96))
                        {
                            throw new Exception("Wrong answer. Try again");
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Functions.Add(out xa, out ya, out xb, out yb, out colour);

                }

                vectors[i] = new Vector(xa, ya, xb, yb, colour);
            }
        }
        static void Remove()
        {
            int index;
            Functions.Remove(out index);
            if (index < 4)
            {
                List<Vector> vectorsList = new List<Vector>(vectors);
                vectorsList.RemoveAt(--index);
                vectors = vectorsList.ToArray();
            }
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
            }
        }
        static void Update()
        {
            int index;
            double xa, ya, xb, yb;
            string colour;
            Functions.Update(out index, out xa, out ya, out xb, out yb, out colour);
            List<Vector> vectorsList = new List<Vector>(vectors);
            if (index < 3)
            {
                vectorsList.RemoveAt(--index);
                vectorsList.Insert(index, new Vector(xa, ya, xb, yb, colour));
            }
            vectors = vectorsList.ToArray();
        }
        static void Show()
        {
            Console.WriteLine("----Showing----");
            foreach (Vector vector in vectors)
                Console.WriteLine($"{vector.ToString()}");
        }
    }
}
