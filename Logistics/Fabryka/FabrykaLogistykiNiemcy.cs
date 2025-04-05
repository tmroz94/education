namespace Logistics.Fabryka;

using Logistics.Kurier;
using Logistics.Paczka;

class FabrykaLogistykiNiemcy : IFabrykaLogistyki
{
    public IPaczka UtworzPaczke()
    {
        return new DuzaPaczka();
    }

    public IKurier UtworzKuriera()
    {
        return new DHLKurier();
    }
}