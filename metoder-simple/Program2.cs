int res = LægSammen(5, 2);
Console.WriteLine(res); // 7
double res2 = BeregnAreal(5);
Console.WriteLine(res2); // 78.5398
double res3 = BeregnBeløbEfterMoms(100, .25);
Console.WriteLine(res3); // 125
Udskriv("Dette er en test"); // Dette er en test

double BeregnBeløbEfterMoms(double tal, double momsPct)
{
    return tal * (1 + momsPct);
}

int LægSammen(int a, int b)
{
    return a + b;
}

double BeregnAreal(double radius)
{
    return (radius * radius) * 3.1415;
}

void Udskriv(string text)
{
    Console.WriteLine(text);
}
