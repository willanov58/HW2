Console.Clear();
Console.WriteLine("Введите трёхзначное число N => ");
int N= Convert.ToInt32(Console.ReadLine());
int temp = N;
int fin = 0;
for(int i=1; i<3;i++) temp = temp/10;
if (temp<10 && temp!=0) 
{
    fin = (N/10)%10;
    Console.WriteLine($"Второй цифрой числа {N}, является {fin}");
}
else Console.WriteLine("Введено не трёхзначное число");
