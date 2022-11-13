Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;
if (b == 0)
{
    Console.Write("Число является четным");
}
else
{
    Console.Write("Число не является четным");
}