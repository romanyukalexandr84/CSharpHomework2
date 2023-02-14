int Check (int number)
{
if (number < 100)
{
    Console.WriteLine ("У этого числа третьей цифры нет");
    return -1;
}
else
{
return number;
}
}

int Third (int digit)
{
    int len = Convert.ToString(digit).Length;
    int step = 1;
    int index = 0;
    while (index < (len-3))
    {
        step = step*10;
        index++;
    }
    return digit / step % 10;
}

Console.WriteLine ("Введите число");
int count = Convert.ToInt32 (Console.ReadLine());

if (Check(count) == -1)
{
    Console.WriteLine();
}
else
{
    Console.WriteLine ("Третья цифра числа = "+Third (Check (count)));
}
