namespace Ex3_Heritage_VictorPholien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carre carre = new Carre(6, "bleu");
            Rectangle rectangle = new Rectangle(3, 2, "vert");

            Console.WriteLine(carre.Afficher());
            Console.WriteLine(rectangle.Afficher());
        }
    }
}