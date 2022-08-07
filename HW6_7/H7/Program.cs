/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9d*/
/*double[,] CreateRandom2dArray(int rows, int columns)
{
	double[,] newArray = new double[rows, columns];
       	for(int i = 0; i < rows; i++)
	    	for(int j = 0; j < columns; j++)
           	 newArray[i, j] = new Random().NextDouble() * 100;
	return newArray;
}

void Show2dArray(double[,] array)
{
 	for(int i = 0; i < array.GetLength(0); i++)
	{
	 	for(int j = 0; j < array.GetLength(1); j++)
	Console.Write(array[i,j] + " ");

	Console.WriteLine();
	}
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray(m,n);
Show2dArray(array); */


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] CreateRandom2dArray(int rows, int columns)
{
	int[,] newArray = new int[rows, columns];

	for(int i = 0; i < rows; i++)
		for(int j= 1; j < rows; j++)
			newArray[i,j] = new Random().Next(1,25);
		return newArray;
}
	
void FindPosition (int[,] array)
{
int m = 0, n = 0;

for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
			if(m > array.GetLength(0) && n > array.GetLength(1))
				Console.WriteLine($"Элемент не существует в массиве");
			if(m < array.GetLength(0) && n < array.GetLength(1));
				array[i,j] = array[m,n];
				Console.WriteLine($"Значение элемента: "+ array[i,j] );
	}
}
    	
	void Show2dArray(int[,] array)
{
 	for(int i =0; i < array.GetLength(0); i++)
	{
	
 	for(int j=0; j< array.GetLength(1); j++)
		Console.Write(array[i,j] + " ");

	Console.WriteLine();
	}
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input pos1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input pos2: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
