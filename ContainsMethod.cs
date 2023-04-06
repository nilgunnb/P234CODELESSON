using System.Security;

string FullName = "Ahad Taghiyev";

Console.WriteLine(ContainsMethod(FullName, 'a')); 

bool ContainsMethod( string name, char letter)
{


    for (int i = 0; i < name.Length; i++)
    {
        if (name[i] == letter)
        {
            return true;
        }
    }
        
        return false;
    
}