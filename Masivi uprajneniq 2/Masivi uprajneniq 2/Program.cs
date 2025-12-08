// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int  n = int.Parse(Console.ReadLine());
int[] array = new int [n];
int max = int.MinValue; 
int min = int.MaxValue;
for  (int i = 0; i < n; i++)
{
    array[i] = int.Parse (Console.ReadLine());
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] > max)
    {
        min = array[i];
    }
}
int maxPosition = -1;
int minPosition = -1;
int[] newArray = new int [n];
int p = 0;

for (int i = 0; i < n;  ++i)
{
    if (array[i] == max)
    {
        maxPosition = i;
    }
    else if (array[i] == min)
    {
        newArray[p] = array[i];
        p++;
    }
    if (array[i] == min)
    {
        minPosition = i;
    }
    else if (array[i] == max)
    {
        newArray[p] = array[i];
        p++;
    }
}
Console.WriteLine(max = " " + maxPosition);
Console.WriteLine(min = " " + minPosition);
for (int i = 0; i < n; i++)
{
    Console.WriteLine(newArray[i]);
}