//selection sort max to min 
/*
int[] arr = { 7, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void SelectionSortMaxMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPos])
            {
                maxPos = j;
            }
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;


    }
}

PrintArray(arr);
SelectionSortMaxMin(arr);
PrintArray(arr);
*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы ваС послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приСтупом согласие прусского короля.Вы так красноречивы. Вы дадите мне чаю?";
Console.Write(text);

string Replace(string initial, char oldSymbol, char newSymbol)
{
    string result = string.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (initial[i] == oldSymbol) result = result + $"{newSymbol}";
        else result = result + $"{initial[i]}";
    }
    return result;
}


string newText=Replace(text,' ','-');
string newText2=Replace(newText,'к','К');
string newText3=Replace(newText2,'С','с');
Console.Write(newText3);
