int[] numbers = { 1, 2, -20, 34, -42, -5, 20, 53, 11, -2, 345, 223 };
int[] positiveNumbers = numbers.Where(n => n > 0).Reverse().ToArray();
foreach (int number in positiveNumbers)
{
    Console.WriteLine(number);
}