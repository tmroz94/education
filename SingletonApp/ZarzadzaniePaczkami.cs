namespace SingletonApp;

using SingletonApp.Paczka.Fabryka;

class ZarzadzaniePaczkami
{
    private static ZarzadzaniePaczkami? _instancja;
    private static readonly object _lock = new object();

    private readonly Dictionary<RozmiarPaczki, IFabrykaPaczek> _fabryki = new Dictionary<RozmiarPaczki, IFabrykaPaczek>
    {
        { RozmiarPaczki.Mala, new FabrykaMalychPaczek() },
        { RozmiarPaczki.Srednia, new FabrykaSrednichPaczek() },
        { RozmiarPaczki.Duza, new FabrykaDuzychPaczek() }
    };

    private ZarzadzaniePaczkami() { }

    public static ZarzadzaniePaczkami Instancja
    {
        get
        {
            lock (_lock)
            {
                if (_instancja == null)
                {
                    _instancja = new ZarzadzaniePaczkami();
                }

                return _instancja;
            }
        }
    }

    public void PrzygotujPaczke(RozmiarPaczki rozmiarPaczki)
    {
        var fabryka = _fabryki.GetValueOrDefault(rozmiarPaczki);

        if (fabryka == null)
        {
            throw new ArgumentException("Nieobslugiwana wielkosc paczki.");
        }

        var paczka = fabryka.UtworzPaczke();

        paczka.Przygotuj();
    }
}