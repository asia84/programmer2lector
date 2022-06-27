int Max(int arg1, int arg2, int arg3)//тройки чисел из списка, сравниваемых между собой(первая тройка и тд, в первой тройке - 3 числа, один из них наибольший будет аргументом и будет дальше сравниваться с другим аргументом из сл.тройки
{
    int result = arg1;
    if(arg2> result) result = arg2;               //тело метода              
    if(arg3> result) result = arg3; 
    return result;  

}

//              0   1   2   3   4   5   6   7   8
int [] array = {11, 5, 31, 41, 15, 61, 17, 18, 19};

int result = Max(
    Max(array[0], array[1],array[2]),
    Max(array[3], array[4],array[5]),
    Max(array[6], array[7],array[8])
    );


Console.WriteLine(result);

