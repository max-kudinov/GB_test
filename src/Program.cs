string[] inputStringArr = {"hi", "hey", "hello", "sup", "greetings", "howdy", "yo"};
int maxLength = 3;

string[] result = CreateArrMaxStrLen(inputStringArr, maxLength);
PrintStrArr(result);

int CalcResultArrLen(string[] strArr, int maxLen)
{
    int resultArrLen = 0;
    for(int i = 0; i < strArr.Length; i++)
    {
        if(strArr[i].Length <= maxLen)
            resultArrLen++;
    }
    return resultArrLen;
}

string[] CreateArrMaxStrLen(string[] strArr, int maxLen)
{
    int resultArrLen = CalcResultArrLen(inputStringArr, maxLength);
    string[] resultArr = new string[resultArrLen];
    int resultArrIndex = 0;

    for(int i = 0; i < strArr.Length; i++)
    {
        if(strArr[i].Length <= maxLen)
        {
            resultArr[resultArrIndex] = strArr[i];
            resultArrIndex++;
        }
    }
    return resultArr;
}

void PrintStrArr(string[] strArr)
{
    Console.Write("[");
    for(int i = 0; i < strArr.Length; i++)
    {
        Console.Write(strArr[i]);
        if(i < strArr.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}
