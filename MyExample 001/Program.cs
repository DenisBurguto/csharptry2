
Console.WriteLine("Please input first number");
string firstNumber = Console.ReadLine();

    try
    {
        int test = Convert.ToInt32(firstNumber);
        Console.WriteLine("ok, ");
    }
    catch (FormatException)
    {
        Console.WriteLine("Input string is invalid.");
    }
    x = Convert.ToInt32(firstNumber);


//Console.WriteLine("Please input second number");
//string secondNumber = Console.ReadLine();
//       try {
//           int y = Convert.ToInt32(secondNumber);
//          Console.WriteLine("Private (/) is, ");
//          int numSecond = y;
//      }
//      catch (FormatException) {
//          Console.WriteLine("Input string is invalid.");
//      }
//Console.WriteLine(numFirst);        
//double result = (numFirst / numSecond);

//Console.WriteLine(result);