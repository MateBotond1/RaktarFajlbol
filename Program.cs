using RaktarFajlbol;

List<Termek> Adatok=new List<Termek>();
string[] Adat= File.ReadAllLines("termekek.txt");

foreach (string sor in Adat)
{
    string[] adatok = sor.Split(';');

    Termek Termekek=new Termek
    {
        Nev=adatok[0],
        Egysegar=int.Parse(adatok[1]),
        RaktaronDb=int.Parse(adatok[2]),
    };
    Adatok.Add(Termekek);
}
int osszertek = 0;
double atlag = 0;
Console.WriteLine("Raktáron lévő termékek:");
for (int i=0;i<Adatok.Count;i++)
{
    osszertek += Adatok[i].Egysegar * Adatok[i].RaktaronDb;
    atlag += Adatok[i].Egysegar;
    Console.WriteLine($"\t-{Adatok[i].Nev}: {Adatok[i].Egysegar}/db ({Adatok[i].RaktaronDb} db) -> Érték:{Adatok[i].Egysegar * Adatok[i].RaktaronDb}");
}
double osszatlag=atlag/Adatok.Count;
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Raktár teljes összértéke: {osszertek} Ft");
Console.WriteLine($"Termékek átlagos egységára: {osszatlag:F0} Ft");