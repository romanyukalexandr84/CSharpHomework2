int Check (int number)
{
while (number < 1 || number > 7)
{
    Console.WriteLine ("Необходимо ввести от 1 до 7, повторите ввод");
    number = Convert.ToInt32 (Console.ReadLine());
}
return number;
}

Console.WriteLine ("Введите цифру, обозначающую день недели");
int count = Convert.ToInt32 (Console.ReadLine());

if ((Check (count))<6)
{
    Console.WriteLine ("Это будний день");
}
else
{
    Console.WriteLine ("Это выходной");
}
