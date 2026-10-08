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