int broqch = 0;
int chislo = 2;
int delitel = 2;

while (broqch < 10001)
{
    if (chislo % delitel == 0)
    {
        if (delitel == chislo)
        {
            broqch++;
        }
        chislo++;
        delitel = 2;
    }
    else
    {
        delitel++;
    }
}
Console.WriteLine("10001-вото просто число е: " + (chislo - 1));