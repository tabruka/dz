// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int start = 1;
Console.WriteLine("Введите число и мы найдем все четные от 1 до Вашего введенного числа");
int N = int.Parse(Console.ReadLine());

while (start <= N)
{
    if(start % 2 == 0)
    {
        Console.WriteLine($"Число, {start} четное");
        start ++;
    }
    else
    {
        start ++;
    }
}