namespace Logistics;

using System.Collections.Generic;
using Logistics.Kurier;
using Logistics.Paczka;
using Logistics.Fabryka;

class ZarzadzaniePaczkami
{
    private static ZarzadzaniePaczkami? _instancja;

    private static readonly object _lock = new object();

    private readonly Dictionary<Lokalizacja, IFabrykaLogistyki> _fabrykiLogistyki = new Dictionary<Lokalizacja, IFabrykaLogistyki>
    {
        { Lokalizacja.Polska, new FabrykaLogistykiPolska() },
        { Lokalizacja.USA, new FabrykaLogistykiUSA() },
        { Lokalizacja.Niemcy, new FabrykaLogistykiNiemcy() },
        { Lokalizacja.Anglia, new FabrykaLogistykiAnglia() }

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

    public void PrzyjmijZamowienie(Lokalizacja lokalizacja)
    {
        var fabryka = _fabrykiLogistyki.GetValueOrDefault(lokalizacja);

        if (fabryka == null)
        {
            throw new ArgumentException("Nieobslugiwana lokalizacja.");
        }

        var paczka = fabryka.UtworzPaczke();
        var kurier = fabryka.UtworzKuriera();

        paczka.Spakuj();
        kurier.Dostarcz();
    }
}