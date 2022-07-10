/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Решение:*/


void PrintArray(int[] array)
{
	int count = array.Length;
	
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}
Console.WriteLine("Inpute number number: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintArray(number);
