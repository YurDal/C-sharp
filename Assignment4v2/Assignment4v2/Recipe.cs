using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4v2
{
    /// <summary>
    ///  @ author Yurdaer Dalkic
    ///  This class storing and handling all dara and operations for a recipe
    /// </summary>
    public class Recipe
    {
        /// Instance variables
        private FoodCategory category;
        private string description;
        private string[] ingreidentArray;
        private String name;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxNumOfIngredients"> Max number of Ingreidents </param>
        public Recipe(int maxNumOfIngredients)
        {
            ingreidentArray = new string[maxNumOfIngredients];
            DefaultValues();
        }

        /// <summary>
        /// This method do all necessary initialization
        /// </summary>
        public void DefaultValues()
        {

            for (int i = 0; i < ingreidentArray.Length; i++)
                ingreidentArray[i] = string.Empty;
            name = string.Empty;
            category = FoodCategory.Vegetarian;
            description = string.Empty;
        }

        /// <summary>
        /// This method adds a new string in the string array "ingreidentArray"
        /// </summary>
        /// <param name="value"> The value of new ingreident </param>
        /// <returns></returns>
        public bool AddIngreident(string value)
        {
            bool ok = true;
            int index = FindVacantPosition(); /// Finf first empty position in the array
            if (index >= 0)
            {
                ingreidentArray[index] = value;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// This method find the first vacant position in the array "ingreidentArray"
        /// </summary>
        /// <returns> first vacant position index </returns>
        private int FindVacantPosition()
        {
            int index = -1;
            for (int i = 0; i < ingreidentArray.Length; i++)
            {
                if (string.IsNullOrEmpty(ingreidentArray[i]))
                {
                    return i;
                }
            }
            return index;
        }

        /// <summary>
        /// This method returns a formatted string which contains all information about the recipe
        /// </summary>
        /// <returns> string with values name, number of ingreidents, cateory, disription </returns>
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);
            string categoryString = category.ToString();
            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description";
            string textout = string.Format("{0,-20 }                     {1,4}                  {2,-12}      {3,-15 }", name, CurrentNumOfIngredients, categoryString, descriptionText);

            return textout;
        }

        /// <summary>
        /// This method replace the value of an ingreident at a position index  to a new value
        /// </summary>
        /// <param name="index"> positon a value which will be repleces </param>
        /// <param name="value"> new value </param>
        /// <returns></returns>
        public bool ChangeIngreidentAt(int index, string value)
        {
            bool ok = true;
            if (CheckIndex(index))
            {
                ingreidentArray[index] = value;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// This methot remove an ingreindent in the given position
        /// </summary>
        /// <param name="index"> position of ingredients whic will be removes </param>
        /// <returns></returns>
        public bool DeleteIngreidentAt(int index)
        {
            bool ok = true;
            if (CheckIndex(index))
            {
                ingreidentArray[index] = string.Empty;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        ///  This method checks if ingreident on the given position is empty or null
        /// </summary>
        /// <param name="index"> returns true if value is null or empty otherwise returns false </param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            return (!string.IsNullOrEmpty(ingreidentArray[index]));
        }

        /// <summary>
        /// This method returns number of saved values in the array  at a certain time
        /// </summary>
        /// <returns></returns>
        public int GetCurrentNumOfIngreidents()
        {
            int count = 0;
            for (int i = 0; i < ingreidentArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingreidentArray[i]))
                {
                    count++;
                }
            }
            return count;
        }


        /// <summary>
        /// This method sort the array for ingredient so all null elements comes last.
        /// </summary>
        public void SortIngreidentArray()
        {
            int numOfElements = ingreidentArray.Length;
            string[] newIngreidents = new string[numOfElements]; // create a new string array 
            for (int i = 0; i < newIngreidents.Length; i++)
                newIngreidents[i] = string.Empty;               // initialize the new array
        
            int count = 0;
            for (int i = 0; i < numOfElements; i++)
            {
                if (!string.IsNullOrEmpty(ingreidentArray[i]))
                {
                    newIngreidents[count] = ingreidentArray[i];  // copy the element from old array to the new array if elemt is not null or emty
                    count++;
                }
            }
            ingreidentArray = newIngreidents;  // replace the new array with old one

        }

        /// <summary>
        ///  Getter and setter for instance variable "category"
        /// </summary>
        public FoodCategory Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        /// <summary>
        /// Getter and setter for instance variable "description"
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        /// <summary>
        /// Getter and setter for instance variable "name"
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        /// <summary>
        /// Getter and setter for instance variable "ingreidentArray"
        /// </summary>
        public string[] Ingreidents
        {
            get
            {
                return ingreidentArray;
            }
            set
            {

                ingreidentArray = value;
            }
        }

        /// <summary>
        /// getter for maximum number of elements for "ingreidentArray"
        /// </summary>
        public int MaxNumOfIngreidents
        {
            get
            {
                return ingreidentArray.Length;
            }

        }

        /// <summary>
        /// getter for number of saved values in the array at a certain time
        /// </summary>
        public string CurrentNumOfIngredients
        {
            get
            {
                return GetCurrentNumOfIngreidents().ToString();
            }

        }


    }
}
