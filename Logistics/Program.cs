namespace Logistics;

class Program
{
    static void Main(string[] args)
    {
        var zarzadzanie = ZarzadzaniePaczkami.Instancja;

        zarzadzanie.PrzyjmijZamowienie(Lokalizacja.Polska);
        zarzadzanie.PrzyjmijZamowienie(Lokalizacja.Niemcy);
        zarzadzanie.PrzyjmijZamowienie(Lokalizacja.USA);
        zarzadzanie.PrzyjmijZamowienie(Lokalizacja.Anglia);

        // Testowanie nieobslugiwanej lokalizacji
        try
        {
            zarzadzanie.PrzyjmijZamowienie(Lokalizacja.Undefined);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        // Udowodnienie, że singleton działa
        var instancja1 = ZarzadzaniePaczkami.Instancja;
        var instancja2 = ZarzadzaniePaczkami.Instancja;

        Console.WriteLine($"Instancje są takie same: {ReferenceEquals(instancja1, instancja2)}");
    }
}