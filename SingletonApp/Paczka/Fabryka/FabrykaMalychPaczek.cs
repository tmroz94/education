namespace SingletonApp.Paczka.Fabryka;

class FabrykaMalychPaczek : IFabrykaPaczek
{
    public IPaczka UtworzPaczke()
    {
        return new PaczkaMala();
    }
}