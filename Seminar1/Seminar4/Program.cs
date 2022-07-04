/*Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.*/


/*int FindSum(int a)
{
	int sum = 0;

	for(int current = 1; current <= a; current++)
		sum += current;
	return sum;
}

Console.WriteLine("Input positive int number ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");*/



/*Задача 2*Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N

int FindProizv(int a)
{
	int proizv = 1;

	for(int current = 1; current <= a; current++)
		proizv *= current;
	return proizv;
}

Console.WriteLine("Input positive int number ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Proizv of numbers from 1 to {num} is {FindProizv(num)}");
*/

/*Задача:Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.*/

/*Задача3 Напишите программу, которая принимает
на вход два числа (A и B) и возводит число A в натуральную степень B.*/

/*int Step(int a, int b)
{
	int current = 1;

	for(int i = 1; i <= b; i++)
		current = current * a ;
        
	return current;
}

Console.WriteLine("Input first number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num} в степени {num1} равно: {Step(num, num1)} ");
*/

/*
int Digits(int num) 
{
    int result = 1;
    int i = 1;
    while(num / i > 10)
    {
       i = i * 10;
       result++;
    }
    return result;
}
Console.WriteLine("Input your number ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Digits(number));
*/
