Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int number = -1 * N;

while (count  < 2 * N + 1)
{
Console.WriteLine(number );
number = number + 1;
count = count + 1;
}