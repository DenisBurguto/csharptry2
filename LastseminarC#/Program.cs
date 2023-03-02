// string 
/*
string[,] table = new string[7, 9];// 2 - string(row) 3-column
table[0, 2] = "word";
void PrintStringArray(string[,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write($"|{table[i, j]}| ");
    }
Console.WriteLine();
}
}
PrintStringArray(table);
*/
/*
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         if(matrix[i,j]==0)   Console.Write($" ");
         else Console.Write($"*");
        }
        Console.WriteLine();
    }
}
int[,] pic = new int[,] {
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
      {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
       {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
       {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
         {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
          {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
           {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
           {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
             {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
              {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};
int[,] matrix = new int[2, 3];
//PrintArray(pic);
void FillImage(int idot, int jdot)
{
    if (pic[idot, jdot] == 0)
    {
        pic[idot, jdot] = 1;
        FillImage(idot - 1, jdot);
        FillImage(idot, jdot - 1);
        FillImage(idot + 1, jdot);
        FillImage(idot, jdot + 1);
    }
}
FillImage(13, 13);
PrintArray(pic);
*/

// Factorial. Recursion.
// 0!=1
//1!=1
//5! =5*4*3*2*1
/*
double Factorial(int n)
{
    if (n == 0 || n == 1) return 1;
    else return n * Factorial(n-1) ;
}
 
for(int i =0; i<17; i++) Console.WriteLine(Factorial(i));
// Fibonacci 1, 1, 2, 3, 5, 8 ...
*/
/*
int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 10; i++)
{ Console.WriteLine(Fibonacci(i)); }
void ShowNum(int num){
    
if(num >1) ShowNum(num-1);
 Console.Write( num + " ");
               
}
ShowNum(5);
*/
/*
int SumOfDigits(int num){
    if(num !=0) return SumOfDigits(num/10)+ num%10;
    else return 0;
}

Console.Write(SumOfDigits(123));
*/
/*
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNum(int m, int n). // в таком виде выводит от m  до n либо по вострастанию либо по убыванию 
{
    if (m > n)
    {
      
        ShowNum(m - 1, n);
        Console.Write(m + " ");
    }
    else if (n > m)
    {
        
        ShowNum(m, n - 1);
        Console.Write(n + " ");
    }
    else Console.Write(n + " ");
}
Console.WriteLine();
<<<<<<< HEAD
ShowNum(10, 15);
*/
/*
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNum(int m, int n). // а в таком виде выводит от m  до n либо всегда!!! по восрастанию не зависимо что больше на входе
    if (m > n)
    {
        ShowNum(m - 1, n);
        Console.Write(m + " ");
    }
    else if (n > m)
    {
        ShowNum(m, n - 1);
        Console.Write(n + " ");
    }
    else Console.Write(n + " ");
}
Console.WriteLine();
ShowNum(10, 15);
*/


=======
ShowNum(44, 15);
>>>>>>> 64ed13b (bootcamp)


//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B( положительное и отрицательное).

double AtoBdegree(double a, int b)
{
    if (b > 0) return AtoBdegree(a, b - 1) * a;
    else if (b < 0) return AtoBdegree(a, b + 1) * (1 / a);
    else return 1;
}

Console.WriteLine(AtoBdegree(2, -3));
<<<<<<< HEAD
=======

void ShowNumbers(int m, int n)
{
    Console.Write(m + " ");
    if (m < n) ShowNumbers(m + 1, n); 
    if (m > n) ShowNumbers(m - 1, n);
}
ShowNumbers(44, 10);
*/
/*

string[] start = {"hello", "2", "world", ":-)"};

Console.WriteLine( start[1].Length); 
Array.Resize(ref start, 3);
Console.WriteLine( "[" + String.Join(", ", start) + "]" ); 

int[] test = new int[0];
Console.WriteLine( "[" + String.Join(", ", test) + "]" ); 
*/



string AddBinary(string a, string b)
{
    string result = String.Empty;
    int registry = 0;
    if (b.Length >= a.Length)
    {
        for (int i = a.Length - 1, j = b.Length - 1; i >= 0; i--, j--)
        {
            if (registry == 0)
            {
                if (a[i] == b[j] && b[j] == '0')
                {
                    result = result.Insert(0, "0");
                    registry = 0;
                }
                else if (a[i] == b[j] && b[j] == '1')
                {
                    result = result.Insert(0, "0");
                    registry = 1;
                }
                else
                {
                    result = result.Insert(0, "1");
                    registry = 0;

                }
            }
            else if (registry == 1)
            {
                if (a[i] == b[j] && b[j] == '0')
                {
                    result = result.Insert(0, "1");
                    registry = 0;
                }
                else if (a[i] == b[j] && b[j] == '1')
                {
                    result = result.Insert(0, "1");
                    registry = 1;
                }
                else
                {
                    result = result.Insert(0, "0");
                    registry = 1;

                }
            }
        }
        

        for (int j = b.Length - a.Length-1; j >= 0; j--)
        {
            if (registry == 0)
            {
                result = result.Insert(0, b[j].ToString());
                registry = 0;
            }
            if (registry == 1)
            {

                if (b[j] == '0')
                {
                    result = result.Insert(0, "1");
                    registry = 0;
                }
                else
                {
                    result = result.Insert(0, "0");
                    registry = 1;
                }
            }

        }



    }
    else{
          for (int i = a.Length - 1, j = b.Length - 1; j >= 0; i--, j--)
        {
            if (registry == 0)
            {
                if (a[i] == b[j] && b[j] == '0')
                {
                    result = result.Insert(0, "0");
                    registry = 0;
                }
                else if (a[i] == b[j] && b[j] == '1')
                {
                    result = result.Insert(0, "0");
                    registry = 1;
                }
                else
                {
                    result = result.Insert(0, "1");
                    registry = 0;

                }
            }
            else if (registry == 1)
            {
                if (a[i] == b[j] && b[j] == '0')
                {
                    result = result.Insert(0, "1");
                    registry = 0;
                }
                else if (a[i] == b[j] && b[j] == '1')
                {
                    result = result.Insert(0, "1");
                    registry = 1;
                }
                else
                {
                    result = result.Insert(0, "0");
                    registry = 1;

                }
            }
        }
        

        for (int i = a.Length - b.Length-1; i >= 0; i--)
        {
            if (registry == 0)
            {
                result = result.Insert(0, a[i].ToString());
                registry = 0;
            }
            if (registry == 1)
            {

                if (a[i] == '0')
                {
                    result = result.Insert(0, "1");
                    registry = 0;
                    Console.WriteLine(a[i]);
                }
                else
                {
                    result = result.Insert(0, "0");
                    registry = 1;
                }
            }

        }



    }



if (registry == 1) result= result.Insert(0, "1");
Console.WriteLine(result);


return result;
}
string a = "101111";
string b = "10";
//string a = "1111111110100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
//string b = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";
AddBinary(a, b);
>>>>>>> 64ed13b (bootcamp)
