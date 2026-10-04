
int chislo1 = 1;
int chislo2 = 2;
int sledvashto = 0;
int sum = 0;

while (chislo1 < 4000000)
{
    if (chislo1 % 2 == 0)
    {
        sum += chislo1;
    }
    sledvashto = chislo1 + chislo2;
    chislo1 = chislo2;
    chislo2 = sledvashto;
    Console.WriteLine(sledvashto);
}
Console.WriteLine(sum);