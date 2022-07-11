/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Решение:*/


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

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[]array2 = CreateArray(size);

ShowArray(array2);
