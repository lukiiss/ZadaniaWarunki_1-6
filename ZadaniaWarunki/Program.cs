using System;
                                                                       //zadanie 1 
int a = 5;
int b = 5;
string AB = a == b ? $"{a} i {b} są równe" : $"{a} i {b} nie są równe";
Console.WriteLine(AB);

                                                                       //zadanie 2

int c = 15;

int wynik = (c % 2);
string mod = wynik == 0 ? $"{c} jest liczbą parzystą" : $"{c} jest liczbą nieparzystą";
Console.WriteLine(mod);

                                                                       //zadanie 3

int d = 14;

if (d > 0)
{
    Console.WriteLine($"Liczba {d} jest dodatnia");
}

else if (d < 0)
{
    Console.WriteLine($"Liczba {d} jest ujemna");
}

else 
{
    Console.WriteLine($"Liczba 0 jest neutralna");
}

//zadanie 4

int year = 2016;
int CzyPrzestepny = (year % 4);

if (CzyPrzestepny == 0 && year % 100 != 0)
{
    Console.WriteLine($"Rok {year} jest przestępny");
}

else
{
    Console.WriteLine($"Rok {year} nie jest przestępny");
}

                                                                       //zadanie 5

int age = 21;

string posel = age >= 21 ? $"Mając {age} możesz zostać posłem" : $"Mając {age} nie możesz zostać posłem";
Console.WriteLine(posel);
string premier = age >= 21 ? $"Mając {age} możesz zostać premierem" : $"Mając {age} nie możesz zostać premierem";
Console.WriteLine(premier);
string senator = age >= 30 ? $"Mając {age} możesz zostać senatorem" : $"Mając {age} nie możesz zostać senatorem";
Console.WriteLine(senator);
string prezydent = age >= 35 ? $"Mając {age} możesz zostać prezydentem" : $"Mając {age} nie możesz zostać prezydentem";
Console.WriteLine(prezydent);

                                                                       //zadanie 6

int wzrost = 140;

if (wzrost <= 150)
{
    string OpisWzrost = "Jesteś krasnoludem";
    Console.WriteLine(OpisWzrost);
}

else if (wzrost > 150 && wzrost <= 160)
{
    string OpisWzrost = "Jesteś niski";
    Console.WriteLine(OpisWzrost);
}

else if (wzrost > 160 && wzrost <= 185)
{
    string OpisWzrost = "Jesteś normalnego wzrostu";
    Console.WriteLine(OpisWzrost);
}

else
{
    string OpisWzrost = "Jesteś gigantem";
    Console.WriteLine(OpisWzrost);
}