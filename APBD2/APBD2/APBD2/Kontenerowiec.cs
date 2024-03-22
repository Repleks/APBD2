namespace APBD2;

public class Kontenerowiec
{
    private static int _idKontenerowca = 0;
    private double _predkoscWezlach;
    private List<Kontener> _listaKontenerow;
    private int _maksymalnaLiczbaPrzewozonychKontenerow;
    private double _maksymalnaWagaPrzewozonychKontenerow;
    private double _aktualnaMasaKontenerowca;

    public Kontenerowiec(double predkoscWezlach, int maksymalnaLiczbaPrzewozonychKontenerow,
        double maksymalnaWagaPrzewozonychKontenerow)
    {
        _predkoscWezlach = predkoscWezlach;
        _maksymalnaLiczbaPrzewozonychKontenerow = maksymalnaLiczbaPrzewozonychKontenerow;
        _maksymalnaWagaPrzewozonychKontenerow = maksymalnaWagaPrzewozonychKontenerow;
        _listaKontenerow = new List<Kontener>();
        _idKontenerowca++;
        _aktualnaMasaKontenerowca = 0;
    }

    public void ZaladujKontenerNaStatek(Kontener kontener)
    {
        _aktualnaMasaKontenerowca += kontener.GetMasaKontenera();
        if (_listaKontenerow.Count+1 < _maksymalnaLiczbaPrzewozonychKontenerow && _aktualnaMasaKontenerowca<_maksymalnaWagaPrzewozonychKontenerow)
        {
            _listaKontenerow.Add(kontener);
            Console.WriteLine("Dodano kontener");
        }
        else
        {
            _aktualnaMasaKontenerowca -= kontener.GetMasaKontenera();
            Console.WriteLine("Nie mozna dodac, za duzo kontenerow");
        }
    }


    public void ZaladujListeKontenerowNaStatek(List<Kontener> listaKontenerow)
    {
        double sumaWag = 0;
        for (int a = 0; a < listaKontenerow.Count; a++)
        {
            sumaWag += listaKontenerow[a].GetMasaKontenera();
        }
        _aktualnaMasaKontenerowca += sumaWag;
        if (_aktualnaMasaKontenerowca < _maksymalnaWagaPrzewozonychKontenerow &&
            _listaKontenerow.Count + listaKontenerow.Count < _maksymalnaLiczbaPrzewozonychKontenerow)
        {
            List<Kontener> tmp = _listaKontenerow.Union(listaKontenerow).ToList();
            _listaKontenerow = tmp;
        }
        else
        {
            _aktualnaMasaKontenerowca -= sumaWag;
            Console.WriteLine("Nie mozna dodac, za duzo kontenerow");
        }
    }

    public void UsunKontenerZeStatku(string identyfikatorKontenera)
    {
        for (int a = 0; a < _listaKontenerow.Count; a++)
        {
            if (_listaKontenerow[a].IdKontenera.Equals(identyfikatorKontenera))
            {
                _aktualnaMasaKontenerowca -= _listaKontenerow[a].GetMasaKontenera();
                _listaKontenerow.Remove(_listaKontenerow[a]);
            }
        }
    }
    public void ZamienienInnymKontenerem(string identyfikatorKontenera, Kontener kontener)
    {
        for (int a = 0; a < _listaKontenerow.Count; a++)
        {
            if (_listaKontenerow[a].IdKontenera.Equals(identyfikatorKontenera))
            {
                _aktualnaMasaKontenerowca -= _listaKontenerow[a].GetMasaKontenera();
                _aktualnaMasaKontenerowca += kontener.GetMasaKontenera();
                if (_aktualnaMasaKontenerowca < _maksymalnaWagaPrzewozonychKontenerow)
                {
                    _listaKontenerow[a] = kontener;
                }
                else
                {
                    Console.WriteLine("Nie mozna dodac, za duzo masa kontenera");
                }
            }
        }
    }

    public void TenKontenerNaInnyStatek(Kontenerowiec kontenerowiec, string identyfikatorKontenera)
    {
        for (int a = 0; a < _listaKontenerow.Count; a++)
        {
            if (_listaKontenerow[a].IdKontenera.Equals(identyfikatorKontenera))
            {
                kontenerowiec.ZaladujKontenerNaStatek(_listaKontenerow[a]);
                _listaKontenerow.Remove(_listaKontenerow[a]);
            }
        }
    }

    public override string ToString()
    {
        return "Id kontenerowca to " + _idKontenerowca + "\n" +
               "Maksymalna predkosc kontenerowca to " + _predkoscWezlach + "\n" +
               "Maksymalna ilosc kontenerow na statku to " + _maksymalnaLiczbaPrzewozonychKontenerow + "\n" +
               "Maksymalna waga kontenerow na statku to " + _maksymalnaWagaPrzewozonychKontenerow + "\n" +
               _listaKontenerow.ToString();
    }
}