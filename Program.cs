//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int QuantityNumber(int num)
{
 int count = 0;
 while(num != 0)
    {
 num = num/10;
 count++; 
    }
return count;
}
Console.WriteLine("Input your number = ");
int num = Convert.ToInt32(Console.ReadLine());
int result = QuantityNumber(num);
Console.WriteLine($"Количество чисел в {num} = {result}");
*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int ProisvNumber(int num)
{
 int proisv = 1;
 for (int count = 1; count<=num; count++)
    {
        
        proisv = proisv*count;
      
    }
return proisv;
}
Console.WriteLine("Input your number = ");
int num = Convert.ToInt32(Console.ReadLine());
int Factorial = ProisvNumber(num);
Console.WriteLine("Факториал =" +Factorial);*/
/*
int[] CreateRandomArray(int size, int MinValue, int MaxValue)
{
 int[] array = new int[size];
 for (int i = 0; i<size; i++)
    {
 array[i] = new Random(). Next(MinValue, MaxValue+1);
    }
 return array;
}
void ShowArray(int[] array)
{
for (int index = 0; index<array.Length; index++)
Console.Write(array[index] + " ");
Console.WriteLine();
}
Console.Write("Input a length a new array = ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value = ");
int max= Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);*/
//----------------------------------------------------------
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
 /*
int[] NewColl (int size, int MinValue, int MaxValue)
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
*/

// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] Array (int size, int MinValue, int MaxValue)
// {
//     int[] curentArray = new 
// }
// void Array(int[] collection)
// {
//     for(int index = 0; index<collection.Length; index++)
//     {
//         Console.WriteLine("Input element number  "+ index + " = ");
//         collection [index] = Convert.ToInt32(Console.ReadLine()); 
//     }
// }
// void PrintArray(int [] collection)
// {
//     for (int current = 0; current<collection.Length; current++)
//     {
//         if (current)
//         Console.Write("   "+ collection [current] +"   ");
//     }
// }

//--------------------------------


// int[] NewColl(int size, int MinValue, int MaxValue)
// {  
//     int[] collection = new int[size];
//  for (int i = 0; i<size; i++)
//     {
//  collection[i] = new Random().Next(MinValue, MaxValue);
//     }
//  return collection;
// }
//  void PrintArray(int [] collection)
// {
//     for (int current = 0; current<collection.Length; current++)
//     {
//         Console.Write("   "+ collection [current] +"   ");
//     }
// }
// int MaxElement(int [] collection)
// {
//     int max = collection [0];
//     for(int count = 1; count<collection.Length; count++)
//     {
//         if (collection[count]>max) max = collection[count];   
//     }
//     return max;
// }
// Console.Write("Input array size = ");
// int size = Convert.ToInt32(Console.ReadLine());
// int MinValue = 100;
// int MaxValue = 1000;
// int [] collection = NewColl(size, MinValue, MaxValue);

// PrintArray (collection);
// Console.Write("           ");
// int max = MaxElement(collection);
// Console.Write("Your max number is = " + max);


//-------------------------------------------------------

// =================sanny ==========================
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for   (int i=0;   i<array.Length; i++)  
        array [i] = new Random ().Next(+  1);
    return array;
}
double[] CreateArrayDouble(int size, int minValue, int maxValue)
{
    double [] array  = new double [size];
    for   (int i=0;   i<array.Length; i++)
    {
        array [i] = new Random ().Next(+  1);
        array [i] += new Random().NextDouble();
    }
    return array;
}

void PrintArray(int[] array)
{
    for   (int i=0;   i<array.Length; i++)
        Console.Write (array [i] + " ");
    Console.Write("\n");
}
int NumberOfEvenElements(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            result++;
    return result;
}
Console.Write("Enter the array size: ");
int arraySize34 = Convert.ToInt32(Console.ReadLine()); //34 - это номер задачи, если что
int[] myArray34 = CreateArray(arraySize34, 100, 999);
PrintArray(myArray34);
int num34 = NumberOfEvenElements(myArray34);
Console.WriteLine("Number of even elements in array: " + num34);
*/