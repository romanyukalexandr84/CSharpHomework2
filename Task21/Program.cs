int Check (int number)
{
while (number < 10000 || number > 99999)
{
    Console.WriteLine ("Число не является пятизначным, повторите ввод");
    number = Convert.ToInt32 (Console.ReadLine());
}
return number;
}

string Pal (int digit)
{
    if ((digit / 10000 == digit % 10) && (digit / 1000 % 10 == digit / 10 % 10))
    {
        return "Это палиндром";
    }
    else
    {
        return "Это не палиндром";
    }
}

Console.WriteLine ("Введите пятизначное число");
int count = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine (Pal (Check (count)));