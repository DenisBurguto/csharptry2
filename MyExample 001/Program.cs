// user should input two numbers to get their private
Console.WriteLine("Please input first number");
string firstNumber = Console.ReadLine();
Console.WriteLine("Please input second number");
string secondNumber = Console.ReadLine();
if (double.TryParse(firstNumber, out var x)) //check if can convert input into number
{

}
else
{
    Console.WriteLine("Wrong input, program is finished");
}
if (double.TryParse(secondNumber, out var y)) //check if can convert second input into number
{

}
else
{
    Console.WriteLine("Wrong input, program is finished");

}
if (y == 0)
{
    Console.WriteLine("It's forbidden to divide with zero!!!");
}
else
{
    if (x != 0)
    {
        double result = x / y;
        Console.WriteLine("the private is");
        Console.WriteLine(result);
    }
    else { Console.WriteLine("0"); }
}

