namespace APBD2;

public class OverfillException : System.Exception
{
    public OverfillException(string wiadomosc) : base(wiadomosc)
    {
    }
}