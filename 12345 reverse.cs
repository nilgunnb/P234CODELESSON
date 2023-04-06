int number = 12345;
int reversenumber = 0;
while (number>0)
{
    int numlast = number % 10;
    reversenumber = reversenumber*10 + numlast;
    number/=10;

}
Console.WriteLine(reversenumber);
