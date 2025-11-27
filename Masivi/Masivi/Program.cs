// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int size = int.Parse(Console.ReadLine());
int[] array = new int [size];
int[]ivo = new int[7];
int max = int.MinValue;
int min = int.MaxValue;
int a;
ivo[0] = int.Parse(Console.ReadLine());
int sum = 0;
int search = int.Parse(Console.ReadLine());
bool isFound = false;
for (int i = 0; i < ivo.Length; i++)
{
    ivo[i] = int.Parse(Console.ReadLine());
    sum += ivo[i];
    if (ivo[i] > max)
    {
        max = ivo[i];
    }
    if (ivo[i] < min)
    {
        min = ivo[i];
    }
    if (search ==  ivo[i])
    {
        isFound = true;
    }
}
if (!isFound)
{
    Console.WriteLine("Number found");
}
Console.WriteLine(sum / ivo.Length);
Console.WriteLine(sum);
Console.WriteLine(max + " " + min);
for (int i = 1; i < ivo.Length; i++)
{
    ivo[i - 1] = ivo[i];
}
ivo[ivo.Length - 1] = ivo[0];
Console.WriteLine("Rotated array;");
for (int i = 0; i < ivo.Length;i++)
{
    Console.WriteLine(ivo[i] + ", ");
}
