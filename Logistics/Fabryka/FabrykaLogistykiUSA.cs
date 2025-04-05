namespace Logistics.Fabryka;

using Logistics.Kurier;
using Logistics.Paczka;

public class FabrykaLogistykiUSA : IFabrykaLogistyki
{
    public IPaczka UtworzPaczke()
    {
        return new DuzaPaczka();
    }

    public IKurier UtworzKuriera()
    {
        return new UPSKurier();
    }
}