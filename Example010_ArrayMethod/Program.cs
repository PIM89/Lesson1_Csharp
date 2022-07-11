int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };
int n = array.Length;
int find = 9;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"{index + 1} элемент массива равен find({find})");
        break;
    }
    index++;
}
if(index == n) Console.WriteLine("Такого элемента нет");