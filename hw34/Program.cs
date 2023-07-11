// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[8];
FillArray(arr,1,999);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(GetCount(arr));

void FillArray(int[] coll, int min_i, int max_i)
{
    for (int i = 0; i < coll.Length; i++)
    {
        coll[i] = new Random().Next(min_i, max_i+1);
    }
}

int GetCount(int[] arr)
{
    int count = 0; 
   foreach (var item in arr)
   {
    if (item%2 == 0)
    {
       count++; 
    }
   }
     return  count;
}