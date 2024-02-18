int M = 0;
int N = 10;

void ShowNumbers(int M)
{
    Console.Write($"{M} ");
    M++;
    if (M <= N)
    {
        ShowNumbers(M);
    }
}

ShowNumbers(M);