int[] array = { 1, 2, 3, 4, 5, 6, 7 };

void ReversArray(int i)
{
    Console.Write($"{array[i]} ");

    if (i > 0)
    {
        ReversArray(--i);
    }
}
ReversArray(array.Length - 1);
