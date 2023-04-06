string Sentence = "I study at code academy";

string[] result = CustomSplit(Sentence, ' ');

 for (int i=0; i<result.Length; i++)
{
    Console.WriteLine(result[i]);
}

string[] CustomSplit (string data, char character)
{
    string[] arr = { };

    string value = string.Empty;

    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] == character)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
            value = string.Empty;
        }
        else
        {
            value += data[i];
        }
        if (i == data.Length - 1)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
        }

    }

    return arr;

}      
