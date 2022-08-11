//Напишите программу, которая на вход принимает два числа и выдаёт максимальное.
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int max = num1;
if(num2>max)
{
    max = num2;
}
Console.Write(max);
Console.Write(" - максимальное число.");

