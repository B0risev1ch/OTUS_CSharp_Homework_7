using System.Diagnostics;

int fibonacciRecursive(int n)
{
    if (n == 1 || n == 0)
        return n;

    return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);

}

int fibonacciForLoop(int n)
{
    int result = 0;
    int b = 1;
    int tmp;

    for (int i = 0; i < n; i++)
    {
        tmp = result;
        result = b;
        b += tmp;
    }
    return result;
}
Stopwatch sw = Stopwatch.StartNew();
sw.Start();
Console.WriteLine("Recursive Fibonacci 5\t" + fibonacciRecursive(5));
Console.WriteLine("Recursive Fibonacci 10\t" + fibonacciRecursive(10));
Console.WriteLine("Recursive Fibonacci 20\t" + fibonacciRecursive(20));
Console.WriteLine("Elapsed via Recursion: " + sw.Elapsed);
sw.Restart();
Console.WriteLine("For-Loop Fibonacci 5\t" + fibonacciForLoop(5));
Console.WriteLine("For-Loop Fibonacci 10\t" + fibonacciForLoop(10));
Console.WriteLine("For-Loop Fibonacci 20\t" + fibonacciForLoop(20));
Console.WriteLine("Elapsed via For-Loop: " + sw.Elapsed); // For-Loop wins! :)
sw.Stop();
