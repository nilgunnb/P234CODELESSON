string Word = "Hello world";

CustomSubstring(Word, 1, 7);


Word = CustomSubstring(Word, 1, 7);


Console.WriteLine(Word);


string CustomSubstring(string data, int startIndex, int endIndex)
{
    string result = string.Empty;

    try
    {

        for (int i = startIndex; i <= endIndex; i++)
        {
            result += data[i];
        }

        return result;
    }
    catch (Exception)
    {
        Console.WriteLine("bu index yoxdur.");
    }

    return "";
}
