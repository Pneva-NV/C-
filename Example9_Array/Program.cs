int Max(int max1, int max2, int max3)
{
    int result = max1;
    if (max2 > result) result = max2;
    if (max3 > result) result = max3;
    return result;
}
//             0  1   2   3   4  5  6   7   8
int[] array = {9, 0, 65, 98, 12, 7, 5, 43, 18};
// array[0] = 45;
// Console.WriteLine(array[8]);

int resolt= Max( 
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));


Console.WriteLine(resolt);
