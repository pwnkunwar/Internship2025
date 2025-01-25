// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ConsoleApp;

/*Console.WriteLine("First Number = ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Second Number = ");
int secondNumber = int.Parse(Console.ReadLine());*/


/*Challenges.Sum(firstNumber, secondNumber);*/ // Sum of 1 and 2 is: 3


Console.WriteLine(SumOfTwoNumber.Sum(12, 10));

int[] array = ArrayOfMultiples.ArrayOfMultiple(6, 5);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine(ReverseAndNot.Reverse(123));

Console.WriteLine(ATMpinCodeValidation.PinValidation("111111"));