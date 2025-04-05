namespace SingletonApp.Paczka.Fabryka;

class FabrykaSrednichPaczek : IFabrykaPaczek
{
    public IPaczka UtworzPaczke()
    {
        return new PaczkaSrednia();
    }
}