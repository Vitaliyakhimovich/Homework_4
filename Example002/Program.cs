Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int d = 0;
int sum = 0;

while(num > 0)
{
d = num % 10;
num = num / 10;
sum = sum + d ;
}

Console.WriteLine($"Сумма чисел: {sum}");