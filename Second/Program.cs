Console.Clear();
Console.WriteLine("Введите число N => ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
int temp = N;
while(temp!=0)
{
temp=temp/10;
i++;
}
if(i<=2) System.Console.WriteLine("Третьей цифры нет");
else
{ 
    for (int j=0;j<i-3;j++)
    {
        N=N/10;
    }
    N=N%10;
    Console.WriteLine($"Третья цифра {N}");
}

