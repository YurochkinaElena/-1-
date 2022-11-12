Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int kvadrat = number2 * number2;
if (kvadrat == number1)
{
    Console.WriteLine("Второе число является корнем первого");
} 
else
{
    Console.WriteLine("Второе число не является корнем первого");
}
