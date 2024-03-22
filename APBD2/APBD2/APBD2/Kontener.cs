namespace APBD2;

public abstract class Kontener : IKontenerInterface
{
    private static int _idKontenera = 0;
    public string IdKontenera { get; }
    protected double WysokoscKontenera { get; }
    protected double WagaWlasnaKontenera { get; }
    protected double GlebokoscKontenera { get; }
    protected double MaksymalnaLadownoscKontenera { get; }
    protected double MasaLadunku { get; set; }

    public Kontener(double wysokoscKontenera, double wagaWlasnaKontenera, double glebokoscKontenera, double maksymalnaLadownoscKontenera, string typKontenera)
    {
        WysokoscKontenera = wysokoscKontenera;
        WagaWlasnaKontenera = wagaWlasnaKontenera;
        GlebokoscKontenera = glebokoscKontenera;
        MaksymalnaLadownoscKontenera = maksymalnaLadownoscKontenera;
        IdKontenera = $"KON-{typKontenera}-{++_idKontenera}";
    }
    public virtual void OproznijKontener()
    {
        MasaLadunku = 0;
        Console.WriteLine("Kontener oprozniony");
    }

    public virtual void ZaladujKontener(double masaLadunkuArgument)
    {
        if (masaLadunkuArgument > MaksymalnaLadownoscKontenera)
        {
            throw new OverfillException("Niewystarczajaca ladownosc kontenera");
        }
        MasaLadunku = masaLadunkuArgument;
    }
}
