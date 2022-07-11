/*Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - 
на последнем и т.д.)*/

/*int[] ReverveArray(int[] array)
{
	for(int i = 0; i< array.Length/2; i++)
	{
	int temp = arra[i];
	array[i] = array[array.Lehgth - 1 - i];
	array[array.Lehgth - 1 - i] = temp;
	}
	return array;
}*/
/*
int[] myArray = {3, 5, 1, 8, 2, 9, 4};
myArray = ReserveArray(myArray);

for(int i = 0; i < myArray.Length; i++)
Console.Write(myArray[i] + " ");
*/

string ChangeDigitSystem(int num)
{
	string resultNumber = string.Empty;

	while(num > 0)
	{
		resultNumber = num % 2 + resultNumber;
	}
    return resultNumber;
}
Console.WriteLine(ChangeDigitSystem(18));