namespace ConsoleApp2_BossFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Héros = 100;
            int Boss = 150;
            int tour = 1;

            while (Héros > 0 && Boss > 0)
            {
                Console.WriteLine($"Tour {tour}");

                int dégâtsHéros = new Random().Next(10, 26);
                Boss -= dégâtsHéros;
                Console.WriteLine($"Le Héros inflige {dégâtsHéros} dégâts au Boss !");
                Console.WriteLine($"Le Boss a maintenant {Boss} points de vie.");
               
                if (Boss <= 0)
                {
                    Console.WriteLine("Le Héros a vaincu le Boss !");
                    break;
                }
                    int dégâtsBoss = new Random().Next(5, 20);
                    Héros -= dégâtsBoss;
                    Console.WriteLine($"Le Boss attaque et inflige {dégâtsBoss} dégâts au Héros !");
                    Console.WriteLine($"Le Héros a maintenant {Héros} points de vie.");

                if (Héros <= 0)
                {
                    Console.WriteLine("Le Boss a vaincu le Héros !");
                    break;

                }

                tour++;
            }
            // evite que la console se ferme automatiquement
            Console.WriteLine("Appuie sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
