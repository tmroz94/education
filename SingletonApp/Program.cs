namespace SingletonApp;

using SingletonApp.Paczka;
using SingletonApp.Paczka.Fabryka;

class Program
{
    static void Main(string[] args)
    {
        var zarzadzaniePaczkami = ZarzadzaniePaczkami.Instancja;

        zarzadzaniePaczkami.PrzygotujPaczke(RozmiarPaczki.Mala);
        zarzadzaniePaczkami.PrzygotujPaczke(RozmiarPaczki.Srednia);
        zarzadzaniePaczkami.PrzygotujPaczke(RozmiarPaczki.Duza);

        // Testowanie nieobslugiwanej wielkosci paczki
        try
        {
            zarzadzaniePaczkami.PrzygotujPaczke(RozmiarPaczki.Undefined);
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