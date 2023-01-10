﻿/*int[] array = { 1, 2, 33, 444, 23, 6, 444, 11, 455, 446 };

int n = array.Length;
int find = 444;
int index = 0;

while(index <n )
{
    if(array[index]==find) {
        Console.WriteLine(index);
        break;
        }
    
    index++;
}
*/

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
     Console.WriteLine(col[position]);
     position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index =0;
    int position =-1;
    while(index < count) 
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
