//TODO 📝 Ordene um array.
Console.WriteLine("Array sem modificações:");
int[] arr = { 2, 8, 5, 20, 10 };
foreach (int number0 in arr)
{
    Console.WriteLine(number0);
}
Console.WriteLine("Array ordenado:");
Array.Sort(arr);
foreach (int number in arr)
{
    Console.WriteLine(number);
}

// TODO 📝 Inverta um array.
Console.WriteLine("Array invertido:");
Array.Reverse(arr);

foreach (int number2 in arr)
{
    Console.WriteLine(number2);

}

Console.WriteLine(Array.IndexOf(arr, 20 ));

Console.ReadLine();
