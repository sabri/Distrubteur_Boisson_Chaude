using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distrubteur_Boision_Chaude
{
    public static class BoissonCost
    {
        public const double CAFE_COST = 1;
        public const double SUCRE_COST = 0.1;
        public const double CREME_COST =0.5;
        public const double THE_COST = 2; 
        public const double EAU_COST = 0.2;
        public const double CHOCLAT_COST = 1;
        public const double LAIT_COST = 0.4;

        public static string CalculCostBoission(Recette recette)
        {
            double cost = 0;
            double costSell = 0;
            switch (recette.Name.ToLower())
            {
                case "expresso":
                    recette.Cafe = 1;
                    recette.Eau = 1;
                    cost = CalculByRecette(recette);
                    costSell = cost + cost * 0.3;
                    break;
                case "allongé":
                case "allonge":
                    recette.Cafe = 1;
                    recette.Eau = 2;
                    cost = CalculByRecette(recette);
                    costSell = cost + cost * 0.3;
                    break;
                case "capuccino":
                    recette.Cafe = 1;
                    recette.Eau = 1;
                    recette.Choclat = 1;
                    recette.Creme = 1;
                    cost = CalculByRecette(recette);
                    costSell = cost + cost * 0.3;
                    break;
                case "chocolat":
                    recette.Sucre= 1;
                    recette.Eau = 1;
                    recette.Choclat = 3;
                    recette.Lait = 2;
                    cost = CalculByRecette(recette);
                    costSell = cost + cost * 0.3;
                    break;
                case "thé":
                case "the":
                    recette.The = 1;
                    recette.Eau = 2;
                    cost = CalculByRecette(recette);
                    costSell = cost + cost * 0.3;
                    break;
                case "autre":
                    cost = CalculByRecette(recette);
                    costSell = cost + cost * 0.3;
                    break;
                    default:
                    break;

            }
            return $"Le prix de recette de {recette.Name} est {cost} et le prix de Vente est {costSell}";
        }
        // calculate the cost of recipe
        private static double CalculByRecette(Recette rec)
        {
            double res= (CAFE_COST * rec.Cafe ?? 0) + (SUCRE_COST * rec.Sucre ?? 0) + (CREME_COST * rec.Creme ?? 0) + (THE_COST * rec.The ?? 0) + (EAU_COST * rec.Eau ?? 0) + (CHOCLAT_COST * rec.Choclat ?? 0) + (LAIT_COST * rec.Lait ?? 0);
            return res;
        }
        //function chcks is autre 
        public static bool IsNewBoisson(List<string> menu, string input)
        {
            return menu.Any(x => x == input) && input == "autre";
        }
        // function checks that input name belongs to our default names List
        public static bool IsExistInListAndValidBoisson(List<string> menu, string? input)
        {
            return input is not null && menu.Any(x => x == input) && input != "autre";
        }
    }
}
