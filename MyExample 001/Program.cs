// user should input two numbers to get division result
Console.WriteLine("Please input first number");
string firstNumber = Console.ReadLine();
Console.WriteLine("Please input second number");
string secondNumber = Console.ReadLine();
if (double.TryParse(firstNumber, out var x) & (double.TryParse(secondNumber, out var y))) //check if can convert input into number
{
    if (y == 0)
    {
        Console.WriteLine("It's forbidden to divide with zero!!!");
    }
    else
    {
        double result = x / y;
        Console.WriteLine("the division result is");
        Console.WriteLine(result);
    }
}
else
{
    Console.WriteLine("Wrong input, program is finished");
}