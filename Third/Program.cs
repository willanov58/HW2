Console.Clear();
Console.WriteLine("Введите день недели =>");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day<6 && Day>0)
{
    Console.WriteLine("Это не выходной");
}
else if (Day>7 || Day<=0)
{
    System.Console.WriteLine("Такого дня не существует");
}
else
{
    System.Console.WriteLine("Это выходной");
}