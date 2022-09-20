using Distrubteur_Boision_Chaude;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Veillez choisir L'un de bossion suivants pour savoir prix de recette et coût");
        Console.WriteLine("1-Expresso");
        Console.WriteLine("2-Allengé");
        Console.WriteLine("3-Capuccino ");
        Console.WriteLine("4-Choclat ");
        Console.WriteLine("5-Thé");
        Console.WriteLine("6-Autre (nouvelle recette)");
        Recette recette = new Recette();
        var menu = new List<string>() { "expresso", "allongé", "allonge", "capuccino", "choclat", "thé", "the", "autre" };
        bool valid = false;
        while (!valid)
        {
            var input = Console.ReadLine().ToLower();
            if (BoissonCost.IsExistInListAndValidBoisson(menu, input))
            {
                recette.Name = input;
                valid = true;
            }
            else if (BoissonCost.IsNewBoisson(menu, input))
            {
                recette.Name = input;
                bool CheckValidNumber = false;
                while (!CheckValidNumber)
                {
                    Console.WriteLine("entrer les doses de Café");
                    CheckValidNumber = int.TryParse(Console.ReadLine(), out int cafe);
                    if (CheckValidNumber) { recette.Cafe = cafe; }
                    Console.WriteLine("entrer les doses de lait");
                    CheckValidNumber = int.TryParse(Console.ReadLine(), out int lait);
                    if (CheckValidNumber) { recette.Lait = lait; }
                    Console.WriteLine("entrer les doses de Thé");
                    CheckValidNumber = int.TryParse(Console.ReadLine(), out int the);
                    if (CheckValidNumber) { recette.The = the; }
                    Console.WriteLine("entrer les doses d'Eau");
                    CheckValidNumber = int.TryParse(Console.ReadLine(), out int eau);
                    if (CheckValidNumber) { recette.Eau = eau; }
                    Console.WriteLine("entrer les doses de Chocolat");
                    CheckValidNumber = int.TryParse(Console.ReadLine(), out int chocalat);
                    if (CheckValidNumber) { recette.Choclat = chocalat; }
                    Console.WriteLine("entrer les doses de Crème");
                    CheckValidNumber = int.TryParse(Console.ReadLine(), out int creme);
                    if (CheckValidNumber) { recette.Creme = creme; }
                    Console.WriteLine("entrer les doses de Sucre");
                    CheckValidNumber = int.TryParse(Console.ReadLine(), out int sucre);
                    if (CheckValidNumber) { recette.Sucre = sucre; }

                }
                valid = true;
            }
            else
            {
                Console.WriteLine("le nom n'est pas valide.Essayer encore!");
            }
        }



        Console.WriteLine(BoissonCost.CalculCostBoission(recette));
    }

 
}
