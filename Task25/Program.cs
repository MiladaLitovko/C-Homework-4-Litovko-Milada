/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите первое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int count = numberA;

for(int i = 1; i < numberB; i++)
{
    count = count * numberA;
}
Console.WriteLine($"Число {numberA}, возведенное в натуральную степень {numberB}, равно {count}");