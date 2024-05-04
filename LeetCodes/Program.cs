using System.Diagnostics;

Console.WriteLine("Hello, World!");

// Definicja metody jako lokalnej funkcji w top-level statement
int[] TwoSum(int[] nums, int target)
{
    Console.WriteLine("test");

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    return new int[0]; // Przykładowy zwrot, zastąp właściwą logiką
}

var result = TwoSum(new int[] { 2, 11, 15, 7 }, 9);

Console.WriteLine($"[{result[0]}, {result[1]}]");
