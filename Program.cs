

void PrintArray(string[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void NewArray(string[] array)
{
    string[] newArray = new string[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (IsLessThree(array[i]))
        newArray[i] = array[i];
    }
    PrintArray(newArray);

}

bool IsLessThree (string str)
{
    int n = 0;
    for (int i = 0; i < str.Length; i++)
    {
        n++;
    }
    if (n <=3 )
    {
        return true;
    }
    else return false;
}

string[] startArray = {"hello", "2",":-P"};

Console.WriteLine("Исходный массив: ");
PrintArray(startArray);
Console.WriteLine("Новый массив: ");
NewArray(startArray);