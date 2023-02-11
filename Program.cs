// Задача 1
/*
int DigitCount(int number)
{
 int count = 0;
 while(number != 0)
    {
 count++;
 number /= 10;
    }
 return count;
}
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits is: " + DigitCount(num));
*/
// Задача 2
// int Factorial(int number)
// {
//     int result = 1;
//     /* for(int i = 1; i <= number; i++)
//      result *= i; */

//     while (number >  1)
//       result *= number--;
//       //  -- *= *=--;

//     return result;
// }

// Console.Write ("Enter number N:  ");
// //int numN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Factorial is:  " + Factorial(Convert.ToInt32(Console.ReadLine())));




// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int SqNumber (int n, int m)
// {
//    int nik = 1;
//    for (int i=1; i <= m; i++)
//       nik *= n;
//    return nik;
// }
// Console.WriteLine("Input number n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int nik = SqNumber(n, m);
// Console.WriteLine("Result : " + nik);

//----------------------------------------------------------------------

/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumber (int num)
{
   int sum = 0;
   while (num!=0)
    {
      sum+= num%10;
      num/=10;
    }
   return sum;

}

Console.Write("Please, enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumNumber (num);
Console.WriteLine("summa:" + sum);

--------------------------------------------------
*/

// Задача 3: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] NewColl(int size, int MinValue, int MaxValue)
{   int[] collection = new int[size];
    for (int i = 0; i<size; i++)
    {
        collection[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return collection;
}
void ShowArray(int[] collection)
{
    for(int index = 0; index<collection.Length; index++)
    {
        Console.Write(collection[index]+ "  ");
    }
}
Console.WriteLine("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input possible min value = ");
int minval = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input possible max value = ");
int maxval = Convert.ToInt32(Console.ReadLine());
int[] array = NewColl(size, minval, maxval);
ShowArray(array);  



