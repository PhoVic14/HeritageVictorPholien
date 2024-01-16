namespace HeritageEx1_VictorPholien
{ 

class Program
{
    static void Main(string[] args)
    {
        Vehicule monVehicule = new Vehicule("Opel", "corsia", "Noir", 1500000);
        Console.WriteLine(monVehicule.Affiche());
        Velo monVelo = new Velo("VTT", false, "BMW", "racingFast", "or", 150000000);
        Console.WriteLine(monVelo.Affiche());
        Voiture MaVoiture = new Voiture("essence", true, "forza", "horizon", "Noir", 2);
        Console.WriteLine(MaVoiture.Affiche());
    }
}
}
