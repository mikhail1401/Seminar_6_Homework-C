Console.WriteLine("Task 41");
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввель пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

System.Console.WriteLine("Enter the size of the array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySize];

int positiveCount = 0;

for (int i=0; i<arraySize; i++)
{
    Console.Write($"Enter element [{i}]: ");
    array[i] = Convert.ToInt32(Console.ReadLine());

    if (array[i]>0) positiveCount++; 
}

Console.WriteLine($" There are {positiveCount} positive numbers among provided");


Console.WriteLine("\nTask 41. Option2");
// When we don't know how many numbers the user will provide.

// bool stop = false;

// int[] array2;
// int j = 0;

// while (stop==false)
// {
//     Console.Write($"Enter element [{j}]: ");
//     array[j] = Convert.ToInt32(Console.ReadLine());
//     j++;

// }


Console.WriteLine("\nTask 43");
// Напишите программу, которая найдет точку пересечения двух прямых,
// заданные уравнениями y=k1*x+b1, y=k2*x+b2;
// значения b1, k1, b2, и k2 задаются пользователем.
// b1=2, k1=5, b2=4, k2=9 -> (-0,5; -0,5)

Console.Write("Enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;

Console.WriteLine($"Point A ({x}; {y}) is the intersection point of the 2 lanes");

// k1*x+b1 = k2*x +b2
// k1*x - k2*x = b2-b1
// x = (b2-b1)/(k1-k2)
// y=k1*x+b1

