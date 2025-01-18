/*
 * Lab 0 Activity 
 * Enzo campana Torres
 * Jan 17 2025
 */

// get low and high int numbers
// low must be positive
// high must be greater than low

using System.ComponentModel;
using System.Numerics;
using Lab0;
int total = 0;
int add; 
int low, high;
int diff; // the difference between low and high
low = Utilities.GetPositiveInt("low number");

Console.WriteLine($"the low number: {low}");

high = Utilities.GetIntInRange("high number", low + 1, Int32.MaxValue); // the largest int possible

//calculate the difference and print it aswell 

diff = high - low;

Console.WriteLine($"The difference between {low} and {high} is {diff}");
Console.WriteLine($"the low number: {low}");
Console.WriteLine($"the high number: {high}");

//create and array to hold numbers between low and high
int[] numbers = new int[diff + 1]; //size of the array +1 to include both low and high

for(int i = 0; i <= diff; i++)
{
    numbers[i] = low + i;
} // i is the index 

Console.WriteLine("Numbers in the array:");

for(int i = 0; i <= diff; i++)
{
    Console.WriteLine(numbers[i]);
} // i is the index 

//create a file named "number.txt" and write to it the numbers from the array in reverse order
//creating file using StreamWriter

StreamWriter streamWriter = File.CreateText("numbers.txt"); //located in the same folder as the .exe file

for(int i = numbers.Length - 1; i >= 0; i--)
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close(); // important to close the file to finalize writing
Console.WriteLine("file written");

string[] nums = File.ReadAllLines("numbers.txt");
foreach(string s in nums)
{
    add = Convert.ToInt32(s);
    total += add;
    Console.WriteLine(s);
} 
Console.WriteLine(total);

