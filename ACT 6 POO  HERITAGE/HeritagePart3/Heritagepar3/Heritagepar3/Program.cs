namespace Heritagepar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carre");

            Carre carre1 = new Carre(5);
            Forme carre1Couleur = new Forme("rouge");
            

            Console.WriteLine(carre1.CalculePerimetre());
            Console.WriteLine(carre1.CalculeSurface());
            Console.WriteLine(carre1Couleur.AfficheCouleur());

            Console.WriteLine("Rectangle");

            Rectangle rectangle1 = new Rectangle(5,5);
            Forme rectangle1Couleur = new Forme("rouge");

            Console.WriteLine(rectangle1.CalculePerimetre());
            Console.WriteLine(rectangle1.CalculeSurface());
            Console.WriteLine(rectangle1Couleur.AfficheCouleur());
        }
    }
}