using static System.Console;
Clear();


WriteLine(factorial(3));


double factorial(int n)
{
    // 1! = 0
    // 0! = 0
    if (n == 1) return 1;
    else return n * factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    WriteLine($"{i}! = {factorial(i)}");
}