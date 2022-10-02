using System;
using System.Collections.Generic;
using System.Collections;

namespace DAL
{
    public class Vector : IComparable
    {
        double Xa { get; set; }
        double Ya { get; set; }
        double Xb { get; set; }
        double Yb { get; set; }
        double X { get; set; }
        double Y { get; set; }
        string Colour { get; set; }

        public Vector(double xa, double ya, double xb, double yb, string colour)
        {
           Xa = xa; Ya = ya; Xb = xb; Yb = yb; X = xb - xa; Y = yb - ya; Colour = colour;
                
        }

        public Vector(double x, double y, string colour)
        { X = x; Y = y; Colour = colour; }

        public double Lenght() => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));

        public void ChangeVector(double x, double y)
        {
            X = x; Y = y;
            Xb = x; Yb = y;
        }

        public override string ToString() =>
            $"{Colour} vector ({X}, {Y}) has {Lenght()} lenght.";

        int IComparable.CompareTo(object obj)
        {
            Vector temp = obj as Vector;
            if (temp != null)
            {
                if (this.Lenght() > temp.Lenght())
                    return 1;
                if (this.Lenght() < temp.Lenght())
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Parametr is not a vector");
        }
    }
}
