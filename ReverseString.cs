string Word = "Hello, World";
 
Word= CustomReverse(Word);
Console.WriteLine(Word);
string CustomReverse( string data)
{
    string Result = string.Empty;

    for (int i = data.Length - 1; i >= 0; i--)
    {
        Result+= Word[i];
    }
    return Result;
}