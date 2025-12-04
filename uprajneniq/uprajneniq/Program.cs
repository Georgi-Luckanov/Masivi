// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int n = int.Parse (Console.ReadLine());
int[] array = new int[n];
int Max = int.MinValue;
int sum = 0;
int negative = 0;
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0)
    {
        sum = sum + array[i];
    }
    else
    {
        negative = negative + array[i];
    }
}
Console.WriteLine(sum);
Console.WriteLine(negative);
Console.WriteLine(sum + negative / n);