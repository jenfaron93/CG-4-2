using System;

namespace NewArray
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] num = new int[] { 1, 1, 2, 3, 5, 8 }; //declares and intializes an int array called 'num'
			foreach (int x in num){ //runs a loop for each time their is an element (x) in the array
				Console.WriteLine(x); //writes the element (x) out to the console
			}
			Console.ReadLine();
        }
    }
}
