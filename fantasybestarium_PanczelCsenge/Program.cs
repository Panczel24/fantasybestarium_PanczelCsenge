namespace fantasybestarium_PanczelCsenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis szornyadatbazis = new SzornyAdatbazis();
            var szornyek = szornyadatbazis.Feltolt("server=localhost; " +
                           "database=fantasybestariumdb; uid=root; password=");

            Szornyelemzo szornyelemzo = new Szornyelemzo();
            Console.WriteLine($"összes szörny: { szornyelemzo.OsszesSzornyszama()}");
            Console.WriteLine($"Veszelyesszornyeknevei: {szornyelemzo.Veszelyesszornyeknevei}");
            Console.WriteLine($"EgyediElohelyek:{szornyelemzo.EgyediElohelyek}");
            Console.WriteLine($"AtlagosVeszelyesseg:{szornyelemzo.AtlagosVeszelyesseg}");
            Console.WriteLine($"LegveszelyesebbSzorny:{szornyelemzo.LegveszelyesebbSzorny}");
            Console.WriteLine($"MocsariVeszelyesSzornyek:{szornyelemzo.MocsariVeszelyesSzornyek}");
            Console.WriteLine($"vanEextremtuzgyengeszorny?{szornyelemzo.vanEextremtuzgyengeszorny}");
        }
    }
}
