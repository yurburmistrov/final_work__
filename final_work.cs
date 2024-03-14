int CountStringSymbols(string[] Array)
{
    int k = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            k++;
        }
    }
    return k;
}

string[] Gen_NewArray(string[] Array)
{
    int newArraySize = CountStringSymbols(Array);
    string[] newArray = new string[newArraySize];
    int i = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            newArray[i] = item;
            i++;
        }
    }
    return newArray;
}

System.Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write($"Введите массив строк через пробел:");
string[] Array = Console.ReadLine().Split(' ');
string[] newArray = Gen_NewArray(Array);
string firstArray = "'" + String.Join("','", Array) + "'";
string secondArray = "'" + String.Join("','", newArray) + "'";
Console.Write($"[ {firstArray} ] => [ {secondArray}]");
