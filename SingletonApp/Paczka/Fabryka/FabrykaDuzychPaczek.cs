namespace SingletonApp.Paczka.Fabryka;

class FabrykaDuzychPaczek : IFabrykaPaczek
{
    public IPaczka UtworzPaczke()
    {
        return new PaczkaDuza();
    }
}