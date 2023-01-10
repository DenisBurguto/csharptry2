int a1 =33, a2 =44, a3 =44333;
int b1 =353, b2 =414, b3 =444;
int c1 =3577753, c2 =424, c3 =445;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if( arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;

}

int max =  Max(Max(a1, a2, a3),Max(b1,b2,b3),Max(c1,c2,c3));

Console.WriteLine(max);