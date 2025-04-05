namespace Logistics.Kurier;

public class UPSKurier : IKurier
{
    public void Dostarcz()
    {
        Console.WriteLine("Dostarczono przez kuriera UPS.");
    }
}