int a = 1;
int b = 2;


while (a < 1000)
{
    int c = 1000 - (a + b);

    if (a*a+b*b==c*c)
    {
        Console.WriteLine("Трите числа са: " + a + " " + b + " " +" " + c );
        Console.WriteLine("Произведението a * b * c е: " + (a * b * c));
        break;
    }
    else
    {
        b++;
        if (b >= 1000 - a)
        {
            a++;
            b = a + 1;
        }
    }
}