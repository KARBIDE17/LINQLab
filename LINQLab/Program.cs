using System.Linq;

int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 }; // array for all the numbers we will be working with

int minResult = nums.Min(); //find the smallest number in the sequence

Console.WriteLine("Smallest number in sequence:  " + minResult);

int maxResult = nums.Max(); // find the largest number in the sequence

Console.WriteLine("Largest number in sequence:  " + maxResult);

var maxResult2 = nums.Where(x => x < 10000).Max(); // find the largest number lthat is less than 10,000

Console.WriteLine("Largest number less than 10,000:  " + maxResult2);

var altResult = nums.Where(x => x >= 10 && x <= 100); // find each number in array between 10 and 100

Console.WriteLine("All numbers in nums between 10 and 100:  ");

foreach (int item in altResult)
{
    Console.WriteLine(item);
}

var altResult2 = nums.Where(x => x >= 100000 && x <= 999999); // find each number in array that is between 100,000 and 999,999

Console.WriteLine("All numbers in nums between 100,000 and 999,999:  ");

foreach (int item in altResult2)
{
    Console.WriteLine(item);
}

var evenNumbers = nums.Where(x => x % 2 == 0); // find each number in the array that is even

Console.WriteLine("All even numbers in \"nums\": ");
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}