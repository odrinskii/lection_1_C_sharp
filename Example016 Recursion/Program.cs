// double Factorial(int n) // метод поиска факториала
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1); // использование рекурсии
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! - {Factorial(i)}");
// }

//Фибоначчи

// f(1) = 1
// f(2) = 2
// f(n) = f(n-1) + f(n-2)


double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}