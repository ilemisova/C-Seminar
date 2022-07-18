/*int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] newArray = new int[rows, columns];

	for(int i = 0; i < rows; i++)
		for(int j= 1; j < rows; j++)
			newArray[i,j] = new Random().Next(minValue, maxValue +1);

	return newArray;
}*/

/*void Show2dArray(int[,] array)
{
 	for(int i =0; i < array.GetLength(0); i++)
	{
	
 	for(int j=0; j< array.GetLength(1); j++)
		Console.Write(array[i,j] + " ");

	Console.WriteLine();
	}

}

int[,] Reverse2dArray(int[,] array)
{
	for(int i = 0; i < array.GetLength(0) - 1; i++)
		for(int j = i + 1; jarray.GetLength(1); j++)
        {
			int temp = array [ij];
			array[ij] = array[ji];
			array[ji] = temp;
		}
	return array;
    
}

int[,] myArray = CreateRandom2dArray(m,n,min,max);

Show2dArray(myArray);
Show2dArrayReverse2dArray(m,n,min,max);

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxpossible value: ");
int max = Convert.ToInt32(Console.ReadLine());



int[,] Cut2dArray(int[,] array)
{
	int iMin = 0, jMin = 0;
	for(int i = 0; i < array.GetLength(0); i++)
		for(int j = 1; j <array.GetLength(j); j++ )
		{		
			if(array[i,j] < array[iMin,jMin])
			{
				iMin = i;
				jMin = j;
			}
		}
	for(int j = 1; j < array.GetLength(1); j++)
		array[iMin, j] = 0;
	for(int i = 0; i < array.GetLength(0); i++)
		array[i,jMin] = 0;
	return array;
}*/
/*Задайте двумерный массив. Напишите программу, которая поменяет местами 
первую и последнюю строку массива*/

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] newArray = new int[rows, columns];

	for(int i = 0; i < rows; i++)
		for(int j= 1; j < columns; j++)
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
int[,] ChangeArray(int[,] array)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
            int temp = array [0,j];
			array[0,j] = array[array.GetLength(0) - 1,j];
			array[array.GetLength(0) - 1,j] = temp;    
    }
    return array;
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
Show2dArray(ChangeArray(myArray));


