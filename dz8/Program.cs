// напишите программу которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N.
// 8 -> 2,4,6,8.

Console.WriteLine("Введите длинну: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        System.Console.Write("Результат: ");
        Console.WriteLine(i);
    }
}
