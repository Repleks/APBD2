namespace APBD2;

public class KontenerPlyn : Kontener, IHazardNotifier
{
    private readonly bool _czyNiebezpiecznyMaterial;

    public KontenerPlyn(double wysokoscKontenera, double wagaWlasnaKontenera, double glebokoscKontenera,
        double maksymalnaLadownoscKontenera, bool czyNiebezpieczny)
        : base(wysokoscKontenera, wagaWlasnaKontenera, glebokoscKontenera, maksymalnaLadownoscKontenera,"L")
    {
        Console.WriteLine("Stworzono poprawnie kontener na plyn");
        _czyNiebezpiecznyMaterial = czyNiebezpieczny;
    }
    
    public void WyslijInformacjeONiebezpiecznymLadunku(string wiadomosc)
    {
        Console.WriteLine(wiadomosc + " "+IdKontenera);
    }

    public override void ZaladujKontener(double masaLadunkuArgument)
    {
        
        if (_czyNiebezpiecznyMaterial)
        {
            if (masaLadunkuArgument < 0.5 * MaksymalnaLadownoscKontenera)
            {
                MasaLadunku = masaLadunkuArgument;
                Console.WriteLine("Zaladowano kontener "+MasaLadunku);
                
            }
            else
            {
                WyslijInformacjeONiebezpiecznymLadunku("Proba wykonania niebezpiecznej operacji");
            }
        }
        else
        {
            if (masaLadunkuArgument < 0.9 * MaksymalnaLadownoscKontenera)
            {
                MasaLadunku = masaLadunkuArgument;
                Console.WriteLine("Zaladowano kontener "+MasaLadunku);
            }
            else
            {
                WyslijInformacjeONiebezpiecznymLadunku("Proba wykonania niebezpiecznej operacji");
            }
        }
    }

    public override string ToString()
    {
        return "KON-L-" + IdKontenera + "\n" +
               "Wysokosc kontenera " + WysokoscKontenera + "\n" +
               "Waga wlasna kontenera " + WagaWlasnaKontenera + "\n" +
               "Glebokosc kontenera " + GlebokoscKontenera + "\n" +
               "Maksymalna ladownosc kontenera " + MaksymalnaLadownoscKontenera + "\n" +
               "Aktualna masa ladunku " + MasaLadunku;
    }
}