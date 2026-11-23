film wypozyczanyFilm = new();

Console.WriteLine("Stan początkowy obiektu:");
Console.WriteLine($"Tytuł: '{wypozyczanyFilm.PobierzTytul()}'");
Console.WriteLine($"Liczba wypożyczeń: {wypozyczanyFilm.PobierzLiczbeWypozyczen()}");

Console.WriteLine("\nTest metody ustawiającej tytuł:");
wypozyczanyFilm.UstawTytul("Matrix");
Console.WriteLine($"Ustawiony tytuł: {wypozyczanyFilm.PobierzTytul()}");

Console.WriteLine("\nTest inkrementacji liczby wypożyczeń:");
Console.WriteLine($"Przed inkrementacją: {wypozyczanyFilm.PobierzLiczbeWypozyczen()}");
wypozyczanyFilm.Inkrementuj();
Console.WriteLine($"Po inkrementacji: {wypozyczanyFilm.PobierzLiczbeWypozyczen()}");

/*
nazwa klasy: film
pola: tytul - przechowuje tytuł filmu
liczbaWypozyczen - przechowuje liczbę wypożyczeń filmu
metody: UstawTytul, nic nie zwraca – ustawia tytuł filmu
PobierzTytul, zwraca tekst – pobiera tytuł filmu
PobierzLiczbeWypozyczen, zwraca liczbę całkowitą – pobiera liczbę wypożyczeń filmu
Inkrementuj, nic nie zwraca – zwiększa liczbę wypożyczeń filmu o jeden
informacje: Klasa reprezentuje film przeznaczony do wypożyczania.
autor: Jakub Kryszewwski
*/
class film
{
    protected string tytul;
    protected int liczbaWypozyczen;

    public film()
    {
        tytul = string.Empty;
        liczbaWypozyczen = 0;
    }

    public void UstawTytul(string nowyTytul)
    {
        tytul = nowyTytul.Length > 20 ? nowyTytul[..20] : nowyTytul;
    }

    public string PobierzTytul()
    {
        return tytul;
    }

    public int PobierzLiczbeWypozyczen()
    {
        return liczbaWypozyczen;
    }

    public void Inkrementuj()
    {
        liczbaWypozyczen++;
    }
}
