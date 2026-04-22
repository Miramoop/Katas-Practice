// Write a program that prints one line for each number from 1 to 100
// Usually just print the number itself.
// For multiples of three print Fizz instead of the number
// For the multiples of five print Buzz instead of the number
// For numbers which are multiples of both three and five print FizzBuzz instead of the number

using csharp.xUnit___FizzBuzzExample;

var fizzBuzz = new FizzBuzz();

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine($"{i} : {FizzBuzz.Stringify(i)}");
}