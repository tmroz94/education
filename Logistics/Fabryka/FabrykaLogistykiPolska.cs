namespace Logistics.Fabryka;

using Logistics.Kurier;
using Logistics.Paczka;

public class FabrykaLogistykiPolska : IFabrykaLogistyki
{
    public IPaczka UtworzPaczke()
    {
        return new MalaPaczka();
    }

    public IKurier UtworzKuriera()
    {
        return new DHLKurier();
    }
}