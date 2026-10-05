using System.Linq;

long naigolqmoto = 0;

for (int i = 100; i <= 999; i++)
{
    for (int j = 100; j <= 999; j++)
    {
        long proizvedenie = i * j;
        string tekst = proizvedenie.ToString();
        string obratno = new string(tekst.Reverse().ToArray());
            
        if (tekst == obratno && proizvedenie > naigolqmoto)
        {
            naigolqmoto = proizvedenie;
            Console.WriteLine("otgovarqshti na usloviqta: "+naigolqmoto);
        }
    }
}
Console.WriteLine("nai golqmoto proizvedenie koeto otgovarq na iziskvaniqta e: " + naigolqmoto);
