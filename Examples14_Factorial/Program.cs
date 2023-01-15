// Принимает метод и возвращает факториал числа
// int заменила на doudle потому, что инт воспринимает ограниченное колч-во чисел

// double Factorial (int n)
// {
//         if (n == 1) return 1;
//         else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");

// }

//Фебоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)


//Int - целые числа
// int Fibonacci (int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 10; i++)
// {
// Console.WriteLine(Fibonacci(i));
// }

//новый - double 

// double Fibonacci (int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine(Fibonacci(i));
// }

// показывает все числа. Хотим узнать когда начинает тормозить
// добавили $"{}" - показывает номер строки

double Fibonacci (int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
