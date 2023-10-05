Console.WriteLine("Введите длину последовательности");

int n = Convert.ToInt32(Console.ReadLine());
int k = 0;

int pr = 0;

Console.WriteLine("Введите элементы последовательности");
for (int i = 0; i < n; i++)


{
    k = Convert.ToInt32(Console.ReadLine());
    pr = pr * k;

}
Console.WriteLine($"Произведение элементов последовательности = {pr}");
