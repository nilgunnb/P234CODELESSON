using System.Linq.Expressions;

int[] Numbers = { 1, 2, 3 };

CustomResize( ref Numbers, 10);

Console.WriteLine(Numbers.Length);

void CustomResize ( ref int[] Array, int NewLength )
{
    int [] NewArray = new int[ NewLength ];

    for ( int i = 0; i < NewArray.Length; i++)
    {
        if (i==NewArray.Length)
        {
            break;
        }

        NewArray[i] = Array[i];
        
        Array = NewArray;
    }
}