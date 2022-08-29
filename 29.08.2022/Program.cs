// День недели по номеру
//Console.WriteLine("Введите номер дня недели");
//        int x=int.Parse(Console.ReadLine());
//        switch (x)
//            {
//            case 1:
//               Console.WriteLine("это понедельник");
//               break;
//            case 2:
//               Console.WriteLine("это вторник");
//               break;
//            case 3:
//               Console.WriteLine("это среда");
//               break;       
//            default:
//                Console.WriteLine("номер дня недели некорректный");
//                break;
//            }

// Пример №2
//int[] array={5,6,8,11,77,55,22};       
//        for (int i=0;i<array.Length;i++)
//        {
//            if (i!=array.Length-1) Console.Write($"{array[i]}, ");
//            else Console.WriteLine($"{array[i]}");
//        }

// Задача 30: Напишите программу, которая выводит массив из N элементов, заполненный случайными целыми числами.
//  N - целое число и задается с клавиатуры.

//Console.WriteLine("Введите количество элементов массива: ");
//int N = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[N];
//FillArray();
//PrintArray();

//void FillArray()
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = new Random().Next(0, 100);
//    }
//}
//void PrintArray()
//{
//    foreach(int x in array)
//    {
//        Console.Write(x + " ");
//    }
//}
 // решение №2 
 //Console.WriteLine("Введите число элементов массива");
 //       int N=int.Parse(Console.ReadLine());
 //       int[] array = new int [N];
 //       for (int i=0; i<N; i++)
 //           {
 //               Console.Write($"{array [i] = new Random().Next(0,100)}, ");  
 //           }

// Задача_ написать программу, где уже реализовано заполнение массива случайными числами. 
// И в этом массиве надо найти максимум и его индекс, минимум и его индекс, среднее арифметическое 
// всех элементов массива. Всё это обернуть в функции.
Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray();
PrintArray();

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArray()
{
    foreach(int x in array)
    {
        Console.Write(x + " ");
    }
}

void minMaxAvgArray(int[] array)
{
    int max = array[0];
    int indexMax = 0;
    int min = array[0];
    int indexMin = 0;
    double summElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max<array[i])
        {
            max = array[i];
            indexMax = i;
        }
        if (min>array[i])
        {
            min = array[i];
            indexMin = i;
        }
        summElem += array[i]; // summElem = summElem + array[i]
    }
    double avgArray = summElem / array.Length;
    Console.WriteLine($"\nМаксимальный элемент списка = {max}, его идекс = {indexMax}.\nМинимальный элемент = {min}, его идекс = {indexMin}.\nСреднее арифмитическое = {avgArray}");
}
minMaxAvgArray(array);
