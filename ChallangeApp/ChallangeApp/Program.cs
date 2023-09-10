var imie = "Ewa";
char plec = 'k';
var wiek = 33;

if (imie == "Ewa" && wiek == 33 && plec == 'k')
{
    Console.WriteLine("Ewa, lat 33");
}
else if (plec == 'k' && wiek < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (plec != 'k' && wiek < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}