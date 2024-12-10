/* 
Challenge #1
Delegate Challenge: Create a delegate that takes two integers and performs basic arithmetic operations 
(add, subtract, multiply, divide) based on the user's choice.
 */
using System;
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
