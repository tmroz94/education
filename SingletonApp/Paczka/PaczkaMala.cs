namespace SingletonApp.Paczka;

class PaczkaMala : IPaczka
{
    public void Przygotuj()
    {
        Console.WriteLine("Przygotowano mala paczke.");
    }
}