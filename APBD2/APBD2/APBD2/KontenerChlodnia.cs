namespace APBD2;

public class KontenerChlodnia : Kontener
{
    public string RodzajProduktu { get; }
    public double Temperatura { get; }

    public KontenerChlodnia(double wysokoscKontenera, double wagaWlasnaKontenera, double glebokoscKontenera, double maksymalnaLadownoscKontenera, string rodzajProduktu)
        : base(wysokoscKontenera, wagaWlasnaKontenera, glebokoscKontenera, maksymalnaLadownoscKontenera,"C")
    {
        RodzajProduktu = rodzajProduktu;
        switch (RodzajProduktu)
        {
            case "Bananas":
                Temperatura = 13.3;
                break;
            case "Chocolate":
                Temperatura = 18;
                break;
            case "Fish":
                Temperatura = 2;
                break;
            case "Meat":
                Temperatura = -15;
                break;
            case "Ice cream":
                Temperatura = -18;
                break;
            case "Frozen pizza":
                Temperatura = -30;
                break;
            case "Cheese":
                Temperatura = 7.2;
                break;
            case "Sausages":
                Temperatura = 5;
                break;
            case "Butter":
                Temperatura = 20.5;
                break;
            case "Eggs":
                Temperatura = 19;
                break;
        }
        
    }

    public void ZaladujKontener(double masaLadunkuArgument, string rodzajProduktuArgument)
    {
        if (rodzajProduktuArgument != RodzajProduktu)
        {
            WyslijInformacjeONiebezpiecznymLadunku("Nie mozna przechowywac dwoch roznych typow produktow w tym samym kontenerze");
        }
        else
        {
            if (masaLadunkuArgument > MaksymalnaLadownoscKontenera)
                throw new OverfillException("Za mala ladownosc kontenera");
            else
            {
                MasaLadunku = masaLadunkuArgument;
            }
        }
    }
    
    public void WyslijInformacjeONiebezpiecznymLadunku(string wiadomosc)
    {
        Console.WriteLine(wiadomosc + " "+IdKontenera);
    }
    
    public override string ToString()
    {
        return "KON-C-" + IdKontenera + "\n" +
               "Wysokosc kontenera " + WysokoscKontenera + "\n" +
               "Waga wlasna kontenera " + WagaWlasnaKontenera + "\n" +
               "Glebokosc kontenera " + GlebokoscKontenera + "\n" +
               "Maksymalna ladownosc kontenera " + MaksymalnaLadownoscKontenera + "\n" +
               "Rodzaj produktu " + RodzajProduktu+"\n"+
               "Aktualna masa ladunku "+ MasaLadunku+ "\n"+
               "Temperatura w kontenerze "+Temperatura;
    }
    
}