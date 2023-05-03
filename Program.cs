string[] CreateStartArray(int sizeArray)
{
    string[] startArray = new string[sizeArray];

    for (int i = 0; i < sizeArray; i++)
    {
        startArray[i] = Console.ReadLine();
    }
    Console.WriteLine("");
    return startArray;
}

int CheckSizeNewArray(string[] startArray)
{
    int counter = 0;
    for (int i = 0; i < startArray.Length; i ++)
    {
        if (startArray[i].Length <= 3)
        {
            counter++;
        }
    }

    return counter;
}

bool CheckSizeWordInLine(string lineArray)
{
    if (lineArray.Length <= 3)
    {
        return true;
    }

    return false;
}

string[] CreateNewArray(string[] startArray, int counter)
{
    string[] newArray = new string[counter];
    int indexArray = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (CheckSizeWordInLine(startArray[i]))
        {
            newArray[indexArray] = startArray[i];
            indexArray++;
        }
    }
    return newArray;
}

void PrintArray(string[] newArray)
{
   for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine(newArray[i]);
    } 
Console.WriteLine("");
}

Console.Write("Введите количество строк в массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStartArray(sizeArray);
int counter = CheckSizeNewArray(array);
string[] newArray = CreateNewArray(array, counter);
PrintArray(newArray);