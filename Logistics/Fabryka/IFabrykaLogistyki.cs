namespace Logistics.Fabryka;

using Logistics.Kurier;
using Logistics.Paczka;

interface IFabrykaLogistyki
{
    IPaczka UtworzPaczke();
    IKurier UtworzKuriera();
}