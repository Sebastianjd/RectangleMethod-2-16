//Sebastian Diaz
//GAME-1343 
//Feb 16
//Description: A program that generates a Rectangle with randomized measurements.

using System;

namespace RectangleMethod
{
    class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            //Create objects
            random = new Random();
            Rectangle rect1 = new Rectangle();

            //Variables
            int min = 0;
            int max = 0;
            int length = 0;
            int width = 0;

            //Ask for min and max ranges and store them
            Console.Write("Please enter a minimun range for measurements: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter a maximum range for measurements: ");
            max = Convert.ToInt32(Console.ReadLine());

            //Call the MakeRectangle() function to get length and width
            MakeRectangle(min, max, out length, out width);

            //Store length and width
            rect1.Length = length;
            rect1.Width = width;

            //Get the area calling the fucntion getArea()
            rect1.Area = Utility.getArea(rect1.Length, rect1.Width);

            //Get the perimeter calling the fucntion getPerimeter()
            rect1.Perimeter = Utility.getPerimeter(rect1.Length, rect1.Width);

            //Display the length, width, area, and perimeter of object rect1
            displayRectangle(rect1.Length, rect1.Width, rect1.Area, rect1.Perimeter);
        }

        //Function for getting a random length and width using the given range (min and max)
        static void MakeRectangle(int min, int max, out int l, out int w) //min = minimum, max = maximum, l = length, w = width
        {
            l = random.Next(min, max);
            w = random.Next(min, max);
        }

        //Function for displaying the length, width, area, and perimeter of a rectangle
        static void displayRectangle(int l, int w, int a, int p) //l = length, w = width, a = area, p = perimeter
        {
            Console.WriteLine("\nLength: " + l);
            Console.WriteLine("Width: " + w);
            Console.WriteLine("Area: " + a);
            Console.WriteLine("perimeter: " + p);
        }
    }
    
    public class Rectangle
    {
        //Variables
        int width;
        int length;
        int area;
        int perimeter;

        //Constructor
        public Rectangle()
        {
            width = 0;
            length = 0;
            area = 0;
            perimeter = 0;
        }

        //Getters and Setters
        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Length
        {
            get => length;
            set => length = value;
        }
        public int Area
        {
            get => area;
            set => area = value;
        }
        public int Perimeter
        {
            get => perimeter;
            set => perimeter = value;
        }
    }

    public class Utility
    {
        //Function for getting the area of a rectangle
        public static int getArea(int l, int w) //l = length, w = width
        {
            int area = 0;
            area = l * w;
            return area;
        }

        //Fucntion for getting the perimeter of a rectangle
        public static int getPerimeter(int l, int w) //l = length, w = width
        {
            int perimeter = 0;
            perimeter = 2 * (l + w);
            return perimeter;
        }
    }
}
