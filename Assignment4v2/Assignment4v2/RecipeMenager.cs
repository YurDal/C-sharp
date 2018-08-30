using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment4v2
{
    /// <summary>
    /// @ author Yurdaer Dalkic
    /// This class works as a container class for an array of Recipe objects
    /// </summary>
    public class RecipeMenager
    {

        private Recipe[] recipeList; // decleras an array

        public RecipeMenager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements]; // creates the array with a size ewaual to maxNumOfElements
        }

        /// <summary>
        /// This method fins the first vacant position in the recipeList
        /// </summary>
        /// <returns> position value of first vacant position </returns>
        private int FindeVacantPosition()
        {
            int index = -1;
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                {
                    index= i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// This method returns a recipe objekt in the gicen position in the recipeList
        /// </summary>
        /// <param name="index"> position of the elemet which will be returns </param>
        /// <returns> Recipe objekt in the gicen position </returns>
        public Recipe GetRecipeAt(int index)
        {
            Recipe recipe = null;
        
            if (CheckIndex(index))
            {
                recipe = recipeList[index];
            }
            return recipe;
        }

        /// <summary>
        ///  This method checks if the element in given position is null or not
        /// </summary>
        /// <param name="index"> position value of element which will be checks </param>
        /// <returns> returns true if elemet is not null otherwise returns false </returns>
        private bool CheckIndex(int index)
        {
            if( recipeList[index] == null){
                return false;
            }
            else {
                return true; }
          
        }

        /// <summary>
        /// This method take values for a Recipe as a number of parameters. A new Recipe objects creats with gicen parameters and the new objects adds in the recipeList.
        /// </summary>
        /// <param name="name"> Recipe name </param>
        /// <param name="category"> Recipe category </param>
        /// <param name="discription">Recipe discription </param>
        /// <param name="ingreidents"> Recipe ingreindents </param>
        /// <returns> returns true add process was succesfull </returns>
        public bool Add(string name, FoodCategory category,string discription, string[] ingreidents)
        {
            bool ok = false;
            int index = FindeVacantPosition(); // finds first vacant position in the array
            if (index >= 0)
            {
                Recipe recipe = new Recipe(ingreidents.Length); // creats new Recipe object
                recipe.Name = name;
                recipe.Ingreidents = ingreidents;
                recipe.Category = category;
                recipe.Description = discription;
                recipeList[index] = recipe; // adding the new Recipe object in the array
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// This method take a new Recipe object as a parameter and adds this new object in the recipeList
        /// </summary>
        /// <param name="rec"> new Recipe object which will be adds in the recipeList </param>
        /// <returns> returns true add process was succesfull </returns>
        public bool Add(Recipe rec)
        {
            bool ok = false;
            int index = FindeVacantPosition();
            if (index >= 0)
            {
                recipeList[index] = rec;
                ok = true;
            }
        
      

            return ok;

        }

        /// <summary>
        ///  This method replace an Recipe object at a given position to a new object
        /// </summary>
        /// <param name="index"> index of the Recipe object which will be repleces </param>
        /// <param name="recipe"> new Recipe objet </param>
        /// <returns>returns true change process was succesfull </returns>
        public bool ChangeElement(int index, Recipe recipe)
        {
            bool ok = true;
            if (CheckIndex(index))
            {
                recipeList[index] = recipe;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// This method sorts the recipeList so that null elemets is always last.
        /// </summary>
        private void updateRecipeList()
        {
            Recipe[] newRecipeList = new Recipe[recipeList.Length]; // Creates a new array
            int index = 0;
            for(int i = 0; i < recipeList.Length; i++)
            {
                if(recipeList[i] != null)
                {
                    newRecipeList[index] = recipeList[i]; // if elemets is nat null add it in the new array
                    index++;
                }
            }
            recipeList = newRecipeList; // change old recipeList with the sorted one

        }

        /// <summary>
        /// This method removes an element from recipeList in the given position 
        /// </summary>
        /// <param name="index"></param>
        public void DeleteElement(int index)
        {
            recipeList[index] = null;
            updateRecipeList();
     
        }

    
        /// <summary>
        /// This method returns number of total elements which is not null
        /// </summary>
        /// <returns> number of total elements which is not null </returns>
        private int TotalItems()
        {
            int totalElements = 0;
            for(int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null && !string.IsNullOrEmpty(recipeList[i].Name))
                {
                    totalElements++;
                }
            }
            return totalElements;
        }


        /// <summary>
        ///  This method returns a string array which contains string presentations of all Recept objects in the recipeList
        /// </summary>
        /// <returns></returns>
        public string[] RecipeListToString()
        {
            int arrayIndex = 0;
            string[] array = new string[TotalItems()];
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null && !string.IsNullOrEmpty( recipeList[i].Name))
                {
                    array[arrayIndex] = recipeList[i].ToString();
                    arrayIndex++;
                }

            }
            return array;
        }
    }
}
