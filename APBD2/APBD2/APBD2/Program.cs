namespace APBD2;

public class Program
{
    public static void Main(String[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Kontener kontener = new Kontener(10, 10, 10, 10);
            Console.WriteLine(kontener.GetNumerSeryjnyKontenera());
        }
    }
}