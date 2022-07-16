/*Задайте двумерный массив размером m×n, заполненный случайными целыми числами.*/


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] newArray = new int[rows, columns];

	for(int i = 0; i < rows; i++)
		for(int j= 1; j < rows; j++)
			newArray[i,j] = new Random().Next(minValue, maxValue +1);

	return newArray;
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

/*Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxpossible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);

int FindDiagSum(int[,]array)
{
	int sum = 0;

	if(array.GetLength(0) == array.GetLength(1))

	for(int i =0; i < array.GetLength(0); i++)
		sum += array[i,i];	
     	return sum;
}	

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxpossible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine(" Sum of main diagonal is " +FindDiagSum(myArray));*/

/*Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] Quat (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
		for(int j= 1; j < array.GetLength(1); j++)
          if(i % 2 == 0 && j % 2 == 0) array[i,j] = array[i,j] * array[i,j];

    return array;
}
*/
/*Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxpossible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine();
myArray = Quat(myArray);
Show2dArray(myArray);*/


/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.*/

int[,] Create2dArray(int rows, int columns)
{
	int[,] newArray = new int[rows, columns];

	for(int i = 0; i < rows; i++)
		for(int j= 0; j < columns; j++)
			newArray[i,j] = i + j;

	return newArray;
}

/*Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(m,n);
Show2dArray(myArray);*/

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
	double[,] newArray = new double[rows, columns];

	for(int i = 0; i < rows; i++)
		for(int j= 1; j < rows; j++)
			newArray[i,j] = new Random().Next(minValue, maxValue +1);

	return newArray;
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
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxpossible value: ");
int max = Convert.ToInt32(Console.ReadLine()); */

/*double[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/