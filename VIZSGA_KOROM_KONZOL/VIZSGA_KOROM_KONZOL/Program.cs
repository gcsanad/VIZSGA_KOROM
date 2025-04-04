namespace VIZSGA_KOROM_KONZOL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Auto> autok = Auto.Beolvas("autok.csv");

            Console.WriteLine($"5.Feladat: {autok.Count} autó található a listában");

            Console.WriteLine($"6.Feladat: Az autók esetében az átlagosan eladott darabszám {Math.Round(autok.Average(x => x.EladottDb), 1)}");

            Console.WriteLine("7. feladat: Az elmúlt 5 évben gyártott autók:");
            autok.Where(x => x.GyartasiEv >= DateTime.Now.Year-5).ToList().ForEach(x => Console.WriteLine($"- {x.Marka} {x.Modell}: {x.GyartasiEv}"));

            Console.WriteLine("8. feladat: Legsikeresebb márkák listája az eladott darabszám alapján:");
            autok.GroupBy(x => x.Marka).Select(x => new { Marka = x.Key, EladottDb = x.Sum(x => x.EladottDb) }).OrderByDescending(x => x.EladottDb).ToList().ForEach(x => Console.WriteLine($"- {x.Marka}: {x.EladottDb} darab"));
        }
    }
}
