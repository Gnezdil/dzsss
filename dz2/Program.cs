
// напишите команду которая на вход пинимает два числа 
// и показывает какое из них большее а какое меньшее .
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("nunber 1 max");
    Console.WriteLine("number 2 min");
}
if (a < b)
{
    Console.WriteLine("number 1 min");
    Console.WriteLine("number 2 max");
}
