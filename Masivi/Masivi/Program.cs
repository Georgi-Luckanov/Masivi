// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[]ivo = new int[7];
int max = int.MinValue;
int min = int.MaxValue;
int a;
ivo[0] = int.Parse(Console.ReadLine());
int sum = 0;
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
}
Console.WriteLine(sum);
Console.WriteLine(max + " " + min);
