int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int i = array.Length;

void ReversArray(int[] arr, int i)
{
    i--;
    Console.Write($"{arr[i]} ");
    
    if (i > 0)
    {
        ReversArray(arr, i);
    }

}
ReversArray(array, i);
