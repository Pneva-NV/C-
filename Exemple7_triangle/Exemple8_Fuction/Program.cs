int Max(int max1, int max2, int max3)
{
    int result = max1;
    if (max2 > result) result = max2;
    if (max3 > result) result = max3;
    return result;
}

int a1 = 12;
int b1 = 87;
int c1 = 300;
int a2 = 25;
int b2 = 7;
int c2 = 13;
int a3 = 92;
int b3 = 8;
int c3 = 31;

int max = Max( 
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));


Console.WriteLine(max);