int sbor = 0;
int sborKvadradi = 0;
long sbornakvadratiiiiii = 0L;

for (int i = 1; i <= 100; i++)
{
    sbor += i;
    int kvadrat = i * i;
    sborKvadradi += i * i;
    sbornakvadratiiiiii = sbor * sbor;
    Console.WriteLine("сбор: "+sbor +" и "+" квадрата e :"+kvadrat+ " сборат на квадратите: "+sborKvadradi+" квадрат на сбора: "+sbornakvadratiiiiii);
}
Console.WriteLine("============================");
Console.WriteLine("kraen otgovor:  " + (sbornakvadratiiiiii - sborKvadradi));