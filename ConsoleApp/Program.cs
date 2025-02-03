// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ConsoleApp;
using ConsoleApp.Feb2;
using ConsoleApp.Jan29;
using ConsoleApp.Jan30;

/*Console.WriteLine("First Number = ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Second Number = ");
int secondNumber = int.Parse(Console.ReadLine());*/


/*Challenges.Sum(firstNumber, secondNumber);*/ // Sum of 1 and 2 is: 3

/*
Console.WriteLine(SumOfTwoNumber.Sum(12, 10));

int[] array = ArrayOfMultiples.ArrayOfMultiple(6, 5);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine(ReverseAndNot.Reverse(123));

Console.WriteLine(ATMpinCodeValidation.PinValidation("111111"));


 double[] largest =  LargestNumberInArrays.FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]);
for (int j = 0; j < largest.Length; j++)
{
    Console.WriteLine($"Largest: {largest[j]}");
}*/


/*ListExample.ListDemo();
ListExample.Insert();
ListExample.Remove();
ListExample.Clear();
ListExample.ListToArray();
ListExample.ArrayToList();
ListExample.LINQ();*/


/*Console.WriteLine(EqualityCheck.CheckEquality(1, 1));

int[] index= IndexOfCapitals.IndexOfCapitalsLetters("eDaBiT");
for(int p=0; p<index.Length; p++)
{
    Console.WriteLine(index[p]);
}

Console.WriteLine(FindTheBomb.Bomb("Hey, did you find the BoMb?"));

Console.WriteLine(AWeekAfter.WeekAfter("29/03/2020"));

Console.WriteLine(PhoneNumberValidator.PhoneNumberValidation("(123) 456-7890"));

Console.WriteLine($"Sum of two smallest number: {SumOfTwoSmallestNumber.SumSmallest([19, 5, 42, 2, 77])}");


*/

// jan29

/*BasicExceptionHandling.Exception();

ExceptionHandeling.ExceptionWithThrow();
*//*
Exercise1.MatrixAddition();
Exercise2.FrequencyELement();
Exercise3.Duplicate();
Exercise4.JaggedA();
Exercise5.Merge();
Exercise6.SecondLargestElement();
Exercise7.Reverse();
Console.WriteLine(Exercise8.Palindrome());
Exercise9.CommonElements();*/




/*ClassWork classWork = new ClassWork();
classWork.Call();*/


/*Student student = new Student("Pawan Kunwar", 23, "CSIT");
student.PrintDetails();*/

/*RotateAList.Rotate();*/


Car car = new Car();
car.Brand = "Lambo";
car.Start();
car.Drive();


Manager manager = new Manager();
manager.Name = "Viper";
manager.Salary = 25000;
manager.Department = "IT";
manager.ShowName();
manager.ShowSalary();
manager.ShowDepartment();


IVehicle vehicle = new MotorVehicle();
vehicle.Start();
vehicle.Stop();


Dog dog = new Dog();
dog.Name = "Jack";
dog.MakeSound();
dog.Eat();


//feb 2

MethodOverloading methodOverloading = new MethodOverloading();
Console.WriteLine(methodOverloading.Add(5,10));
Console.WriteLine(methodOverloading.Add(5,10,20));
Console.WriteLine(methodOverloading.Add(5.5,2.5));
Console.WriteLine(methodOverloading.Add("Hello","World"));



Animal1 animal1 = new Animal1();
Dog1 dog1 = new Dog1();
Animal1 cat1 = new Cat1();

animal1.MakeSound();
dog1.MakeSound();
cat1.MakeSound();



AsynchronousProgramming a = new AsynchronousProgramming();
await a.DoWorkAsync();

