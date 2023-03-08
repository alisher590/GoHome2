// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
int num = new Random().Next(100, 1000);
int NumA = num/100;
int NumB =(num/10)%10;
int NumC = num%10;
int result = NumA * 10 + NumC;
Console.Write($"Исключили из числа {num} -> число {NumB} -> {result}");


