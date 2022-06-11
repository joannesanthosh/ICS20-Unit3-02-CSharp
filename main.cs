// Created by: Joanne Santhosh
// Created on: Apr 2022
//
// This program provides your address

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the volume of a pyramid.
        int lengthOfPyramid;
        int widthOfPyramid;
        int heightOfPyramid;
        Console.WriteLine("This function calculates the volume of a pyramid.");
        Console.WriteLine("");

        Console.WriteLine("Enter the length of the pyramid.");
        lengthOfPyramid = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter the width of the pyramid. ");
        widthOfPyramid = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter the height of the pyramid.");
        heightOfPyramid = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("");
        Console.WriteLine("The volume of the pyramid is: " + 
        (lengthOfPyramid * widthOfPyramid * heightOfPyramid  /3) + " cm³ ");
        Console.WriteLine("\nDone.");
    }
}