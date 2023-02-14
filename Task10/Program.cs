int Check (int number)
{
while (number < 100 || number > 999)
{
    Console.WriteLine ("Число не является трехзначным, повторите ввод");
    number = Convert.ToInt32 (Console.ReadLine());
}
return number;
}

int Second (int digit)
{
    return (digit / 10 % 10);
}

Console.WriteLine ("Введите трехзначное число");
int count = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Вторая цифра числа = "+Second (Check (count)));