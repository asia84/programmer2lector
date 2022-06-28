int[] array = { 14, 21, 43, 41, 53, 60, 17, 21, 29 };

int n = array.Length;
int find = 21;


int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console. WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}