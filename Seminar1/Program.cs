// double bigNum = 12.13;
// bool isEven = true;
// string word = "flower";
// char symbol = '$';

// int num1 = -12;
// int num2 = 6;

// Console.WriteLine ("My numbers are " + num1 + " and " + num2 + " and it is good!");
// Console.WriteLine ($"My numbers are {num1} and {num2} and it is good!");

// Console.Write("Input an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your number is " + num);

// Seminar1

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;
 
if(num1 == quad2)
    Console.Write("YES!");
else
    Console.Write("NO!");
*/

// Task 2. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// 31542 / 10 = 3154
// 31542 / 100 = 315
// 31542 / 1000 = 31
// 31542 / 10000 = 3

// 31542 % 10 = 2
// 31542 % 100 = 42
// 31542 % 1000 = 542
// 31542 % 10000 = 1542

// 453216 -> 32

// HOMEWORK

// Task 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max, min;

if (a > b)
{   max = a;
    min = b;;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine("Higher number: {0}", max);
Console.WriteLine("Lower number: {0}", min);
*/

// Task 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
 if (c > max)
{
    max = c;
}

Console.WriteLine("Max number: {0}", max);
*/

// Task 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("number {0} even", num);
}
else
{
    Console.WriteLine("number {0} odd", num);
}
*/

// Task 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Even numbers from 1 to {0}: ", n);

for (int i = 2; i <= n; i += 2)
{
    Console.Write("{0} ", i);
}
*/