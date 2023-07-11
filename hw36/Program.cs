// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[8];
FillArray(arr,-10,10);
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
    int sum = 0; 
   for (int i=0; i<arr.Length; i++ )
   {
     
    if (i%2 == 1)
    {
       sum+=arr[i];
    }
   }
     return  sum;
}