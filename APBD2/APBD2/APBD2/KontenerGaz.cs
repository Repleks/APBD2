namespace APBD2;

public class KontenerGaz : Kontener, IHazardNotifier
{
    public double Cisnienie { get; }

    public KontenerGaz(double wysokoscKontenera, double wagaWlasnaKontenera, double glebokoscKontenera, double maksymalnaLadownoscKontenera, double cisnienie)
        : base(wysokoscKontenera, wagaWlasnaKontenera, glebokoscKontenera, maksymalnaLadownoscKontenera,"G")
    {
        Console.WriteLine("Stworzono poprawnie kontener na gaz");
        Cisnienie = cisnienie;
    }
    public void WyslijInformacjeONiebezpiecznymLadunku(string wiadomosc)
    {
        Console.WriteLine(wiadomosc + " "+IdKontenera);
    }

    public override void OproznijKontener()
    {
        MasaLadunku  *= 0.05;
        Console.WriteLine("Kontener oprozniony");
    }
    
    public override string ToString()
    {
        return "KON-G-" + IdKontenera + "\n" +
               "Wysokosc kontenera " + WysokoscKontenera + "\n" +
               "Waga wlasna kontenera " + WagaWlasnaKontenera + "\n" +
               "Glebokosc kontenera " + GlebokoscKontenera + "\n" +
               "Maksymalna ladownosc kontenera " + MaksymalnaLadownoscKontenera + "\n" +
               "Aktualna masa ladunku "+ MasaLadunku+ "\n"+
               "Cisnienie kontenera " + Cisnienie;
    }
}