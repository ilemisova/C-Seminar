/*void ShowNums(int n)
{
	if(n > 1)
		ShowNums(n - 1);
	Console.Write(n + " ");
}

int SumOfDigits(int n)
{
	if(n >= 10)
	{
		return n % 10 + SumOfDigits(n / 10);
	}
	else return n;
}

ShowNums(5);
Console.WriteLine();
Console.WriteLine(SumOfDigits(12345));*/

/*Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
внутри рекурсии отправлять 2 аргумента*/

/*void ShowNums(int n, int m)
{
	if(n > m)
		ShowNums(n -1, m);
	Console.Write(n + " ");
}
ShowNums(10, 5);
Console.WriteLine();*/

/*Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе
рекурсивным методом.N = 4532 -> 4*/
/*
int CountOf(int n)
{
	if(n > 9)
	{
		return 1 + CountOf(n =n / 10);
	}
	else return n;
}

Console.WriteLine(CountOf(123456));
*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNums(int m, int n)
{
	if(n > m)
	{
	   return n + SumNums(m, n-1);
	}
    else return n;
}

Console.WriteLine(SumNums(1,15)); 


/*Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.*/
/*
int SumOfDigits(int a, int b)
{
    if(b > 1)
	{
	    return a * SumOfDigits(a, b -1);
	}
	else return a;
}
Console.WriteLine(SumOfDigits(2,3));*/
