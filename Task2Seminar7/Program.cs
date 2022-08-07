int[,] CreateRandom2dArray(int rows, int columns)
{
	int[,] newArray = new int[rows, columns];

	for(int i = 0; i < rows; i++)
		for(int j= 1; j < rows; j++)
			newArray[i,j] = new Random().Next(1,25);
		return newArray;
}
	
/*void FindPosition (int[,] array)
{
    int m = 0;
    int n = 0;

    for(int i = 0; i < array.GetLength(0); i++)
		for(int j = 0; j < array.GetLength(1); j++)
			if(m < array.GetLength(0) && n < array.GetLength(1))
				array[i,j] = array[m,n];
				Console.WriteLine($"Значение элемента: "+ array[{i}{j}]);
            else
            {
                Console.WriteLine($"Элемент не существует в массиве");
            }
	
}*/
int FindPosition(int [,]array, int m, int n)
{
	for(int i = 0; i < array.GetLength(0); i++)
		for(int j = 0; j < array.GetLength(1); j++)
			if( i == m && j == n)
			{
				return array [m,n];
			}
}
Console.WriteLine(FindPosition);
    	
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
FindPosition(array[m,n]);
Console.Write(array[i,j]);