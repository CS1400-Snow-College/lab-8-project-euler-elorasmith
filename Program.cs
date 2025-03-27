// See https://aka.ms/new-console-template for more information

// Elora Smith, 3/25/25, Lab 8 Project Euler

using System.Runtime.InteropServices;
Console.Clear();
Console.WriteLine("This is a program that will solve four Euler Project problems. Press the number of the problem you want to see.");
Console.WriteLine();

string one = @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.

Answer: ";
string two = @"The sum of the squares of the first ten natural numbers is, 1^2 + 2^2... + 10^2 = 385.
The square of the sum of the first ten natural numbers is, (1 + 2... + 10)^2 = 55^2 = 3025.

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is, 3015 - 385 = 2640.
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

Answer: ";

Console.WriteLine("1- Multiples of 3 and 5 \n\n2- Sum Square Difference ");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
    {
        Console.Clear();
        Console.WriteLine(one);
        int sum = SumOfMultiples(3,5);
        Console.WriteLine(sum);
        break;
    }
    case 2:
    {
        Console.Clear();
        Console.WriteLine(two);
        double difference = SumSquareDifference(100);
        Console.WriteLine(difference);
        break;
    }
}




// MULTIPLES OF 3 OR 5

static int SumOfMultiples(int x, int y)
{
    int sum = 0;
    for (int i = 0; i < 1000; i++)
    {
        if (i%3 == 0) sum = sum + i;
        else if (i%5 == 0) sum = sum + i;
    }
    return sum;
}

// SUM SQUARE DIFFERENCE

static double SumSquareDifference(double n)
{
    double sumSquare = 0;
    double sum = 0;
    for (double i = 0; i <= n; i++)
    {
        sumSquare += Math.Pow(i,2);
        sum += i;
    }
    double squareSum = Math.Pow(sum,2);
    double difference = squareSum - sumSquare;
    return difference;
} 

// SUMMATION OF PRIMES
/*
double sum = SumOfPrimes(10);
Console.WriteLine(sum);
static double SumOfPrimes(double n)
{
    bool isPrime = false;
    double sum = 0;
    for (double i = 2; i < n; i++)
    {
        for (double j = 1; j <= i; j++)
        {
            if (i % j == 0 && j != i)
            {
                    isPrime = false;
               // Console.Write($"{i}%{j}, ");
            }
            else
            Console.Write($"{i}%{j}, ");
            isPrime = true;
        }
        if (isPrime == true)
            sum += i;
    }
    return sum;
}
*/


// EVEN FIBONACCI NUMBERS
/*
double sum = EvenFibonacciSum(400002);
Console.WriteLine(sum);
static double EvenFibonacciSum(double n)
{
    int count = 400002;
    double sum = 0;
    double[] fibonacciNumbers = new double[count];
    for (int i = 0; i < count; i++)
    {
        fibonacciNumbers[i] = Fibonacci(i);
    }   

    foreach (double number in fibonacciNumbers)
    {   
        if (number%2 != 0)
            sum = sum + number;
    }
        

    static double Fibonacci(double n)
    {
        if (n==0) return 0;
        else if (n==1) return 1;
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
    return sum-1;
}
*/

