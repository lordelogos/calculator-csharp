// Making a calculator
// fn: add, sub, mul, div
// input: 2 numbers and operation
namespace Calculator
{
    public class App
    {
        public static void Main()
        {
            double input1, input2, result;
            string operand;

            Console.WriteLine("Welcome to my calculator v0.0.1");
            Console.Write("Enter first number: ");
            input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            input2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform?");
            Console.Write("a for Addition, m for Multiplication, d for Division, s for Subtraction: ");
            operand = Console.ReadLine();

            if (operand == "a")
            {
                result = Functions.Add(input1, input2);
                Console.WriteLine("The answer is " + result);
            }
            else if (operand == "m")
            {
                result = Functions.Multiply(input1, input2);
                Console.WriteLine("The answer is " + result);
            }
            else if (operand == "d")
            {
                result = Functions.Divide(input1, input2);
                Console.WriteLine("The answer is " + result);
            }
            else if (operand == "s")
            {
                result = Functions.Subtract(input1, input2);
                Console.WriteLine("The answer is " + result);
            }
            else
            {
                Console.WriteLine("You have selected an invalid operation.");
            }

            Console.ReadLine();
        }
    };
}