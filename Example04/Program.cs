/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int eventNumber = 2 ; //Типо меньше 2 нельзя ставить 

// Решение с циклом for 
// for (eventNumber = 2; eventNumber <=100; eventNumber += 2)
// Console.Write(eventNumber + " ");

if(number > 1 && number < 100)// Здесь предел числа , либо от 1 и до 100 
{
    while(eventNumber <= number)
    {
        Console.Write(eventNumber + " ");
        eventNumber = eventNumber + 2;
    }
}