// Tenth project on lection #№2
int[] array = { 11, 2, 13, 41, 15, 61, 71, 15, 8 };

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}