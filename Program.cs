/* 
Challenge #1
Delegate Challenge: Create a delegate that takes two integers and performs basic arithmetic operations 
(add, subtract, multiply, divide) based on the user's choice.
 */
using System;
using System.Collections.Generic;
using System.Linq;
public delegate double Calculator(int a, int b);

public class Program
{
    public static double Add(int a, int b)
    {
        return a + b;
    }
    public static double Subtract(int a, int b)
    {
        return a - b;
    }
    public static double Multiply(int a, int b)
    {
        return a * b;
    }
    public static double Divide(int a, int b)
    {
        return b != 0 ? (double)a / b : double.NaN;
    }

    static void Main()
    {
        Console.WriteLine("Enter a first number: ");
        int num1 = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter a second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose an operation: 1) Add 2) Subtract 3) Multiply 4) Divide");
        int choice = int.Parse(Console.ReadLine());

        Calculator calculate;

        switch (choice)
        {
            case 1:
                calculate = Add;
                break;
            
            case 2:
                calculate = Subtract;
                break;
            
            case 3:
                calculate = Multiply;
                break;
            
            case 4:
                calculate = Divide;
                break;
            
            default:
                Console.WriteLine("Invalid Choice");
                return;
        }

        double result = calculate(num1, num2);
        Console.WriteLine($"Result {result}");
    }
}



/* 
Challenge #2
Event Challenge: Create an event system where a class notifies subscribers 
when a specific threshold is reached in a counter.
*/

public delegate void NotifyUser(string message);

public class Threshold
{
    public event NotifyUser Notify;

    private int _counter = 0;
    private int _threshold;

    public Threshold(int threshold)
    {
        _threshold = threshold;
    }

    public void IncrementCounter()
    {
        _counter++;
        Console.WriteLine($"Counter {_counter}");

        if (_counter >= _threshold)
        {
            TriggerEvent();
        }
    }


    public void TriggerEvent()
    {
        Notify?.Invoke($"Threshold of {_threshold} Reached!!!");
    }
}

public class Subscriber
{
    public void NotifyUser(string message)
    {
        Console.WriteLine($"Subscriber received notification: {message}");
    }

}

public class Program2
{
    static void Main()
    {

        Console.WriteLine("Enter a threshold value:");
        int threshold = int.Parse(Console.ReadLine());

        // Creating objects
        Threshold thresholdTracker = new Threshold(threshold);
        Subscriber subscriber = new Subscriber();

        thresholdTracker.Notify += subscriber.NotifyUser;

        // Simulate counter increments
        Console.WriteLine("Incrementing counter...");
        for (int i = 0; i < threshold + 2; i++)
        {
            thresholdTracker.IncrementCounter();
        }
    }
}


/* 
Challenge #3
Lambda Challenge: Write a lambda expression that filters a list of integers to display 
only even numbers and calculate their sum. 
*/


public delegate int EvenNumberCalculate();

class Program3
{  
    static void Main()
    {
        // Make a list of numbers first 
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Making a list of even numbers from original numbers list
        List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Even Numbers:");
        evenNumbers.ForEach(n => Console.WriteLine(n));

        // Making a variable of the number's sum
        Console.WriteLine("Number Total");
        int sumNumbers = numbers.Sum();
        Console.WriteLine($"{sumNumbers}");

    }
}