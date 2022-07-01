/*Написать программу, которая принимает номер четверти 
и выводит дипазон значений координат, возможных в этой 
четверти:

Метод "void"*/

/*void ShowArea(int quart)
{
if(quart >= 1 && quart <=4)
{
if(quart == 1) Console.WriteLine("In thie quart x > 0 and y > 0");
if(quart == 2) Console.WriteLine("In thie quart x < 0 and y > 0");
if(quart == 3) Console.WriteLine("In thie quart x < 0 and y < 0");
if(quart == 4) Console.WriteLine("In thie quart x > 0 and y > 0");
}
else
Console.WriteLine("This number uncorrect");
}

Console.WriteLine("Input number of quart:" );
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);*/


/*Необходимо написать программу,которая принимает на вход координаты
точки и в качестве результата выдает номер четверти, в которой
эта точка находится.*/

/*Метод "int Koord"

int Koord(int a, int b)
{
	int result = -1;
    	
		if(a > 0 && b > 0) result = 1; 
		if(a < 0 && b > 0) result = 2; 
		if(a < 0 && b < 0) result = 3; 
		if(a > 0 && b < 0) result = 4; 
        return result;
}

Console.WriteLine("Input number of x: " );
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of y: " );
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Koord(x, y));
*/