namespace APBD2;

public class Kontener
{
    // masa ładunku w kilogramach
    private int _masaLadunku;
    // wysokośc kontenera w centymetrach
    private int _wysokosc;
    // masa kontenera w kilogramach
    private int _masaSamegoKontenera;
    // głębokość kontenera w centymetrach
    private int _glebokoscKontenera;
    // maksymalna ładowność kontenera w kilogramach
    private int _maksymalnaLadownoscKontenera;
    // numer seryjny kontenera 
    private static int _numerSeryjnyKontenera = 0;
    // konstruktor kontenera 
    public Kontener(int wysokosc, int masaSamegoKontenera, int glebokoscKontenera, int maksymalnaLadownoscKontenera)
    {
        _wysokosc = wysokosc;
        _masaSamegoKontenera = masaSamegoKontenera;
        _glebokoscKontenera = glebokoscKontenera;
        _maksymalnaLadownoscKontenera = maksymalnaLadownoscKontenera;
        _numerSeryjnyKontenera++;
    }

    public int GetWysokosc()
    {
        return _wysokosc;
    }

    public int GetMasaSamegoKontenera()
    {
        return _masaSamegoKontenera;
    }

    public int GetGlebokoscKontenera()
    {
        return _glebokoscKontenera;
    }

    public int GetMaksymalnaLadownoscKontenera()
    {
        return _maksymalnaLadownoscKontenera;
    }

    public int GetNumerSeryjnyKontenera()
    {
        return _numerSeryjnyKontenera;
    }
}