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