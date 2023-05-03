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

Console.Write("Введите количество строк в массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStartArray(sizeArray);
int counter = CheckSizeNewArray(array);