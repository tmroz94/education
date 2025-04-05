namespace Logistics.Kurier;

public class DHLKurier : IKurier
{
    public void Dostarcz()
    {
        Console.WriteLine("Dostarczono przez kuriera DHL.");
    }
}