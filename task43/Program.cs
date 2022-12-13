// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void InputLine(double[] array)
{
    Console.WriteLine("Введите параметры первой приямой ");
    Console.Write("b1 = ");
    array[0] = Convert.ToDouble(Console.ReadLine());

    Console.Write("k1 = ");
    array[1] = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Введите параметры второй приямой ");
    Console.Write("b2 = ");
    array[2] = Convert.ToDouble(Console.ReadLine());

    Console.Write("k2 = ");
    array[3] = Convert.ToDouble(Console.ReadLine());
}

double Search_X(double[] array)
{
    double nx = (array[2] - array[0]) / (array[1] - array[3]);
    return nx;    
}

double Search_Y(double[] array, double x)
{
    double ny = (array[1] * x) + array[0];
    return ny;    
}

void PrintArray(double x, double y)
{
    Console.WriteLine($"Точка пересечения двух прямых ({x};{y})");
}

Console.WriteLine("Программа находит точку пересечения двух прямых ");
double[] array = new double[4];
InputLine(array);
PrintArray(Search_X(array), Search_Y(array, Search_X(array)));