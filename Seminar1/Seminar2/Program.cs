int CutNumber()
{
    int num = new Random().Next(100,1000);
Console.WriteLine("Current random number is " + num);

        int des1 = num / 10;
        num = num /10;
        int des = num % 10;
        
        
    int result = des;
return result;
}

int number = CutNumber();
Console.WriteLine("Result number is " + number);
