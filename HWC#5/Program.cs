
/*
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

 int [] CreateRandomArray(int size, int minVal, int maxVal)
 {
    int [] arr= new int[size];
    for(int i=0; i<size; i++)
    {
        arr[i]=new Random().Next(minVal,maxVal+1);
    }
 return arr;
 }

void PrintArray (int[] array)
{
    
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
        }
 Console.WriteLine();   
}

 void CounterEvenNumbers (int []array)
 { int count=0;
    for (int i=0; i<array.Length; i++)
    {if  (array[i]%2==0)
        count++;
        }
Console.WriteLine($"Количество четных элементов в массиве равно {count}");
 }


Console.WriteLine("Введите количество элементов массива");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива");
int minVal=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива");
int maxVal=Convert.ToInt32(Console.ReadLine());
int [] NewArr=CreateRandomArray(size,minVal,maxVal);
PrintArray(NewArr);
CounterEvenNumbers(NewArr);
*/

/*
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArray(int size, int minVal, int maxVal )
 {
    int [] arr= new int[size];
    for(int i=0; i<size; i++)
    {
        arr[i]=new Random().Next(minVal, maxVal);
    }
 return arr;
 }

void PrintArray (int[] array)
{
    
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
        }
 Console.WriteLine();   
}

 void SummOddNum (int []array)
 { int sum=0;
    for (int i=0; i<array.Length; i++)
    {if  (i%2!=0)
        sum+=array[i] ;
        }
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна {sum}");
 }


Console.WriteLine("Введите количество элементов массива");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива");
int minVal=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива");
int maxVal=Convert.ToInt32(Console.ReadLine());

int [] NewArr=CreateRandomArray(size, minVal, maxVal);
PrintArray(NewArr);
SummOddNum(NewArr);

*/

/*
 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateRandomArray(int size, int minVal, int maxVal)
 {
    int [] arr= new int[size];
    for(int i=0; i<size; i++)
    {
        arr[i]=new Random().Next(minVal, maxVal);
    }
    double [] array=new double[size];
    for(int i=0; i<size; i++)
    {
            array[i]=new Random().NextDouble();
    }
    double [] SumArr= new double[size];
    for(int i=0; i<size; i++)
    {
        SumArr[i]=Math.Round (arr[i]+array[i], 2);
    }
 return SumArr;
 }

void PrintArray (double [] SumArr)
{
    
    for (int i=0; i<SumArr.Length; i++)
    {
        Console.Write (SumArr[i]+" ");
        }
 Console.WriteLine();   
}
void MaxMin(double [] SumArr)
{
    double min=SumArr[0];
    double max=SumArr[0];
     for (int i=0; i<SumArr.Length; i++)
     {
        if (SumArr[i]>max)
        max=SumArr[i];
        if (SumArr[i]<min)
        min=SumArr[i];
     }
double result=Math.Round(max-min,2);
Console.WriteLine($"Максимальный элемент массива равен {max}");
Console.WriteLine($"Минимальный элемент массива равен {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}");   
}


Console.WriteLine("Введите количество элементов массива");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива");
int minVal=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива");
int maxVal=Convert.ToInt32(Console.ReadLine());



double [] NewArr=CreateRandomArray(size,minVal,maxVal);
PrintArray(NewArr);
MaxMin(NewArr);

*/