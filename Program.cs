// See https://aka.ms/new-console-template for more information

// Elora Smith, 3/25/25, Lab 8 Project Euler

// MULTIPLES OF 3 AND 5

using System.Runtime.InteropServices;

/*
int sum = SumOfMultiples(3,5);
Console.WriteLine(sum);
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

double difference = SumSquareDifference(100);
Console.WriteLine(difference);
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
*/
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


int count = 10;
double[] fibonacciNumbers = new double[count];
for (int i = 1; i < count; i++)
{
    fibonacciNumbers[i] = Fibonacci(i);
}

foreach (double number in fibonacciNumbers)
    Console.Write($"{number}, ");

 static double Fibonacci(double n)
 {
   if (n==0) return 0;
   else if (n==1) return 1;
   return Fibonacci(n-1) + Fibonacci(n-2);
 }

