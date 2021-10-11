﻿using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoş geldiniz.";
            string degisken2 = "dersimiz CSharp, Hoş geldiniz.";
            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//0, 1, -1
            Console.WriteLine(String.Compare(degisken, degisken2, true));//0, 1, -1
            Console.WriteLine(String.Compare(degisken, degisken2, false));//0, 1, -1

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoş geldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Melek"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert 
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken + degisken2.PadRight(30));
            Console.WriteLine(degisken + degisken2.PadRight(50, '*'));

            //Remove
            Console.WriteLine(degisken.Remove(20));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken.Replace("Csharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
