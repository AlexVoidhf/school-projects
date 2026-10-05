
long chislo = 600851475143L;
int delitel = 2;

while (chislo > 1)
{
    if (chislo % delitel == 0)
    {
        chislo = chislo / delitel;
    }
    else
    {
        delitel++;
    }
    Console.WriteLine("числото е: " + chislo);
    Console.WriteLine("делител е: " + delitel);
}
Console.WriteLine("най-големият прост множител е: " + delitel);