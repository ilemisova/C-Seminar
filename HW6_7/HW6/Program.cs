/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[]CreateArray(int size)
{
	int[] newArray = new int[size];

	Console.WriteLine("Creating array here: ");
	for(int i = 0; i < size; i++)
	{
		Console.Write($"Input {i + 1} element: ");
		newArray[i] = Convert.ToInt32(Console.ReadLine());
	}
	Console.WriteLine();
	return newArray;
}


void ShowArray(int[] array)
{
	for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
	Console.WriteLine();
}
void findSumPositiv(int[] array)
{
int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum++;
Console.WriteLine($"Result is {sum}" );
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[]array2 = CreateArray(size);
ShowArray(array2);
findSumPositiv(array2);

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

int Koord (int k1, int k2, int b1, int b2)
{
    int x = (b2 -b1) / (k1 - k2);
return x;
}

Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

    if(k1 == k2) Console.WriteLine(" Will not intersect: ");

Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int x = Koord(k1, k2, b1, b2);
int y = k1*x+b1;
Console.WriteLine(x);
Console.WriteLine(y);
