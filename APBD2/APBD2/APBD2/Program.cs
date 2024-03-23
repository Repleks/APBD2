namespace APBD2;

public class Program
{
    public static void Main(String[] args)
    {
        try
        {
            var liquidContainer = new KontenerPlyn(100, 50, 200, 1000, false); 
            var gasContainer = new KontenerGaz(150, 60, 250, 800, 1.2); 
            var refrigeratedContainer = new KontenerChlodnia(120, 55, 220, 900, "Bananas"); 
            try
            {
                liquidContainer.ZaladujKontener(2000);
            }
            catch (OverfillException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            var ship = new Kontenerowiec(20, 10, 20000); 
            ship.ZaladujKontenerNaStatek(liquidContainer);
            var refrigeratedContainer2 = new KontenerChlodnia(130, 60, 240, 1500, "Fish");
            var gasContainer2 = new KontenerGaz(140, 70, 260, 1100, 0.8);
            var liquidContainer2 = new KontenerPlyn(110, 45, 210, 950, true); 
            var containersToLoad = new List<Kontener> { refrigeratedContainer2, gasContainer2 };
            ship.ZaladujListeKontenerowNaStatek(containersToLoad);
            try
            {
                ship.ZaladujKontenerNaStatek(liquidContainer2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            ship.UsunKontenerZeStatku(liquidContainer.IdKontenera);
            ship.ZamienienInnymKontenerem(gasContainer.IdKontenera, liquidContainer2);
            var ship2 = new Kontenerowiec(15, 5, 10000);
            ship.TenKontenerNaInnyStatek(ship2, refrigeratedContainer.IdKontenera);
            Console.WriteLine(liquidContainer2.ToString());
            Console.WriteLine(ship.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        
    }
}