// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 8. Вывод четных чисел в диапазоне от 1 до N");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int i = 1;
string temp = "";
while (i <= n)
{
    if (i % 2 == 0)
    {
        if (temp == "")
        {
            temp = temp + i;
        }
        else
        {
            temp = temp + ", " + i;
        }
    }
    i++;
}
Console.Write("Четные числа: {0}", temp);