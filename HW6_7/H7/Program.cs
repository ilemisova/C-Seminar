double[,] CreateRandom2dArray(double rows, double columns)
{
	double[,] newArray = new double[rows, columns];
       	for(double i = 0; i < rows; i++)
	    for(double j = 1; j < columns; j++);
            
	    newArray[i,j] = new Random().NextDouble();
	return newArray;
}

void Show2dArray(double[,] array)
{
 	for(double i = 0; i < array.GetLength(0); i++)
	{
	 	for(double j = 0; j < array.GetLength(1); j++)
	Console.Write(array[i,j]);

	Console.WriteLine();
	}
}

Console.WriteLine("Input number of rows: ");
double m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
double n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);


