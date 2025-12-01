// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random rnd  = new Random();
int fieldSize = rnd.Next(10, 21);
char [] field = new char[fieldSize];
int ships = 0;
for  (int i = 0; i < fieldSize; i++)
{
    int chance = rnd.Next(0, 101);
    if ((chance <30) && (ships < 3))
    {
        field[i] = 'I';
        ships++;
    }
    else
    {
        field[i] = '~';
    }
}
while (ships > 0)
{
    int position = int.Parse(Console.ReadLine());
    if (field[position] == 'I')
    {
        field[position] = '~';
        ships--;
    }
    for (int i = 0; i < fieldSize; i++)
        if (field[i] == 'I')
        {
            Console.Write(field[i]);
        }
        else
        {
            Console.Write(field[i]);
        }
    Console.WriteLine();
}

