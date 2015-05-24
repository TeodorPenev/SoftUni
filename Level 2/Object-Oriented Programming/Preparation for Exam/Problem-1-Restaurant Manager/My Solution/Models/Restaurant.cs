using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Restaurant:IRestaurant
    {
        private string name;
        private string location;
        private IList<IRecipe> recipes;
        private Recipe rec;
        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            recipes = new List<IRecipe>();
        }

        public string Name
        {
            get { return this.name; }
            private set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public string Location
        {
            get { return this.location; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The locaion name cannot be null or empty!");
                }
                this.location = value;
            }
        }

        public IList<IRecipe> Recipes
        {
            get { return this.recipes; }
        }

        public void AddRecipe(IRecipe recipe)
        {
            Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("{0} {1} - {2} {0}", new String('*', 5), this.name, this.location));
            if (recipes.Count == 0)
            {
                result.Append("\nNo recipes...yet");
            }
            else
            {
                foreach (var recipe in recipes)
                {
                    rec = (Recipe)recipe;
                    if (recipe.GetType().ToString() == "RestaurantManager.Models.Drink")
                    {
                        result.Append(String.Format("\n{0} DRINKS {0}", new String('~', 5)));
                        result.Append(String.Format("\n{0} {1} {0} {2}",new String('=',2), recipe.Name,recipe.Price));
                        result.Append(
                            (String.Format("\nPer serving: {0} {1}, {2} kcal", recipe.QuantityPerServing, recipe.Unit,
                                recipe.Calories)));
                        result.Append(String.Format("\nReady in {0} minutes", recipe.TimeToPrepare));
                        result.Append(String.Format("\nCarbonated: {0}",boolCheck(rec.IsCarbonated)));
                    }

                    if (recipe.GetType().ToString() == "RestaurantManager.Models.Drink")
                    {
                        result.Append(String.Format("\n{0} DRINKS {0}", new String('~', 5)));
                        result.Append(String.Format("\n{0} {1} {0} {2}", new String('=', 2), recipe.Name, recipe.Price));
                        result.Append(
                            (String.Format("\nPer serving: {0} {1}, {2} kcal", recipe.QuantityPerServing, recipe.Unit,
                                recipe.Calories)));
                        result.Append(String.Format("\nReady in {0} minutes", recipe.TimeToPrepare));
                        result.Append(String.Format("\nCarbonated: {0}", boolCheck(rec.IsCarbonated)));
                    }

                    if (recipe.GetType().ToString() == "RestaurantManager.Models.Salads")
                    {
                        result.Append(String.Format("\n{0} SALADS {0}", new String('~', 5)));
                        result.Append(String.Format("\n{0} {1} {0} {2}", new String('=', 2), recipe.Name, recipe.Price));
                        result.Append(
                            (String.Format("\nPer serving: {0} {1}, {2} kcal", recipe.QuantityPerServing, recipe.Unit,
                                recipe.Calories)));
                        result.Append(String.Format("\nReady in {0} minutes", recipe.TimeToPrepare));
                        result.Append(String.Format("\nCarbonated: {0}", boolCheck(rec.IsCarbonated)));
                    }
                }
                ;
            }

            return result.ToString();
        }

        private string boolCheck(bool p)
        {
            if (p==true)
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }
    }
}
