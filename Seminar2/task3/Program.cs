Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberB % numberA == 0)
{
Console.WriteLine("число 2 кратно числу 1");
}
else
{
Console.Write("число 2 не кратно числу 1, остаток = ");
Console.WriteLine(numberB % numberA);  
}