void Triangle (int a, int b, int c)
{
	if (a < b +c && b < a + c && c < a + b) Console.WriteLine(" ok ");
    else  Console.WriteLine( "No");
}
Console.WriteLine("Input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Triangle(num1, num2, num3);