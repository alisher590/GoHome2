Console.Clear();
void PrintDay(int num)
{
    if(num > 0 && num < 8)
    {
        if (num == 6 || num == 7) 
        Console.WriteLine("Выходной");
        else 
        Console.WriteLine("Это рабочий день");
    }
    else Console.WriteLine("Такого дня несуществует!");
}
Console.Write("Введите число дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());

PrintDay(numberOfDay);
