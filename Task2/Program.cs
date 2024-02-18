int AckermannFun(int m, int n)
{
    int A = 0;
    if (m == 0)
    {
        A = n + 1;
    }
    else if (m > 0 && n == 0)
    {
        A = AckermannFun(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        A = AckermannFun(m - 1, AckermannFun(m, n - 1));
    }
    return A;
}
int M = 3;
int N = 4;
Console.Write(AckermannFun(M, N));