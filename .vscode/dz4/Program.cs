// напишите программу которя на вход принемает три числа 
// и выдает максимальное из этих трех чисел .

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}

if (d > max)
{
    max = d;
}
Console.WriteLine(max);
