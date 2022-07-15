Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int [] {x1, y1, z1};
int[] array2 = new int [] {x2, y2, z2};


double distance = Math.Sqrt(Math.Pow(array2[0] - array1[0], 2) + Math.Pow(array2[1] - array1[1], 2) + Math.Pow(array2[2] - array1[2], 2));

Console.WriteLine(distance);

//double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) ); решение без массива
