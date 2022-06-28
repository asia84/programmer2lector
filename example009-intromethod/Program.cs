int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;               //тело метода              
    if(arg3> result) result = arg3; 
    return result;

}


int a1 = 15;//переменные и их значения
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23; //для теста можно ввести новое максимальное число, например 231
int c3 = 33;


int max1 = Max( a1, b1, c1 );//определим переменную максимальную, в которую положим значение первых трех аргументов
Console.WriteLine(max1);// выводим на экран значение переменной max

//алгоритм реализован правильно.

