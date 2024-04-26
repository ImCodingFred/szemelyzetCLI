using System.IO;

namespace szemelyzetCLI
{
    internal class Program
    {
        static List<Dolgozo> dolgozok = new List<Dolgozo>();
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"szemelyzetCLI_adatok.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                dolgozok.Add(new Dolgozo(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine($"3. feladat: {dolgozok.Count} dolgozó van az állományban");
            Console.WriteLine($"4. feladat: {dolgozok.Average(x=>x.fizetes)} Ft a dolgozók átlagbére");
            Dictionary<string, int> telephelyek = new Dictionary<string, int>();
            foreach (var dolgozo in dolgozok)
            {
                if (!telephelyek.ContainsKey(dolgozo.telephely))
                {
                    telephelyek.Add(dolgozo.telephely, 1);
                }
                else
                {
                    telephelyek[dolgozo.telephely]++;
                }
            }
            Console.WriteLine($"5. feladat:");
            foreach (var telephely in telephelyek)
            {
                Console.WriteLine($"\t{telephely.Key}: {telephely.Value} dolgozó");
            }

            //Dictionary<string, int> beszotber = new Dictionary<string, int>();
            //foreach (var dolgozo in dolgozok)
            //{
            //    if (!beszotber.ContainsKey(dolgozo.beosztas))
            //    {
            //        beszotber.Add(dolgozo.beosztas, dolgozo.fizetes);
            //    }
            //    else
            //    {
            //        beszotber[dolgozo.beosztas]+= dolgozo.fizetes;

            //    }
            //}
            var beosztber = dolgozok.GroupBy(x => x.telephely).Select(x => new { x.Key, Osszber = x.Sum(x => x.fizetes) });

            Console.WriteLine($"6. feladat:");
            foreach (var beosztas in beosztber)
            {
                Console.WriteLine($"\t{beosztas.Key}: {beosztas.Osszber} ft");
            }
            Console.WriteLine($"7. feladat: {dolgozok.Where(x => x.munkabaallas < Convert.ToDateTime("2019 - 01 - 01")).Count()}");
            List<Dolgozo> Egri = dolgozok.Where(x=>x.telephely=="Eger").ToList();
            Random rnd = new Random();
            int a= rnd.Next( 0, Egri.Count );
            Console.WriteLine($"8. feladat: {Egri[a].nev}, {Egri[a].munkabaallas.ToString("yyyy-MM-dd")}, {Egri[a].fizetes}");
            string be;
            bool ki;
            do
            {
                Console.Write($"9. feladat: adjon meg egy pozíciót: ");
                be = Console.ReadLine();
                if (be == "szellemi" || be == "fizikai") 
                {
                    ki = false;
                }
                else
                {
                    ki = true;
                    Console.WriteLine("Próbálja újra!");
                }
            } while (ki);
            List<Dolgozo> kivalasztott = dolgozok.Where(x=>x.beosztas==be).ToList();
            a = rnd.Next(0, kivalasztott.Count);
            Console.WriteLine($"10. feladat: {kivalasztott[a].nev}, {kivalasztott[a].munkabaallas.ToString("yyyy-MM-dd")}, {kivalasztott[a].fizetes}");
            Console.ReadKey();
        }
    }
}
