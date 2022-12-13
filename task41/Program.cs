// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PackArray(int[] array)
{
    Console.WriteLine("Введите числа ");
    for (int i = 0; i < array.Length; i++) {array[i] = Convert.ToInt32(Console.ReadLine());}
}

void PrintArray(int[] array)
{
    Console.Write("Введённые числа ");
    for (int i = 0; i < array.Length; i++) {Console.Write(array[i] + " ");}
    Console.WriteLine();
}

int Most0Array(int[] array)
{
    int most0 = 0;
    for (int i = 0; i < array.Length; i++) {if (array[i] > 0) most0++;}
    return most0;
}

void PrintMost0Array(int printMost0)
{
    Console.WriteLine("Количество введённых чисел больше ноля равно " + printMost0);
}
 
Console.WriteLine("Программа показывает количество чисел больше ноля равно ");
Console.Write("Сколько чисел будете вводить ");
int lengthMass = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lengthMass];
PackArray(array);
PrintArray(array);
PrintMost0Array(Most0Array(array));