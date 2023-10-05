Console.WriteLine("Введите элементы последовательности");

int n = Convert.ToInt32(Console.ReadLine());
int k = 0;

int summa = 0;

Console.WriteLine("Введите числа последовательности");
for (int i = 0; i < n; i++)

{
   
    k = Convert.ToInt32(Console.ReadLine());
    summa = summa + k;

}

Console.WriteLine($"Сумма элементов последовательности = {summa}");