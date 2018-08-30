using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Assignment4v2
{
    /// <summary>
    /// @ author Yurdaer Dalkic
    /// This is the main GUI of this solition.
    /// </summary>
    public partial class FormMain : Form
    {

        // instance variables
        private const int numOfIngredients = 20;
        private const int numOfElements = 50;
        private Recipe currRecipe = new Recipe(numOfIngredients);
        private RecipeMenager recipeMng = new RecipeMenager(numOfElements);
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            currRecipe.Name = string.Empty;
            cbNewCategory.Items.Add(FoodCategory.Vegetarian);
            cbNewCategory.Items.Add(FoodCategory.Meat);
            cbNewCategory.Items.Add(FoodCategory.Fish);
            cbNewCategory.Items.Add(FoodCategory.SeaFood);
            cbNewCategory.SelectedIndex = 0;
            EnableButtons(false,false,true);
        }

        /// <summary>
        /// This method checks the user input
        /// </summary>
        /// <returns> returns true if input is not null </returns>
        private bool CheckInput()
        {
            string name = tbNewName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Recipe name is empty!");
                return false;
            }
        }

        /// <summary>
        /// This method calls when user click an element i the listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxMain.SelectedIndex; // get the index og selected item
            if (index >= 0) {
                // Fills GUI with selected items information
              currRecipe = new Recipe(numOfIngredients);
              currRecipe = recipeMng.GetRecipeAt(index);
              string[] ingArray = recipeMng.GetRecipeAt(index).Ingreidents;
              currRecipe.Ingreidents = ingArray;
              cbNewCategory.SelectedItem = currRecipe.Category;
              tbNewName.Text = currRecipe.Name;
              tbDiscrip.Text = currRecipe.Description;
              EnableButtons(true,true,false);
           }
        }

        /// <summary>
        /// This method enables buttons for edit, delete and add
        /// </summary>
        /// <param name="delete"></param>
        /// <param name="edit"></param>
        /// <param name="add"></param>
        private void EnableButtons(bool delete, bool edit, bool add)
        {
            btnDelete.Enabled = delete;
            btnEdit.Enabled = edit;
            btnAddRecipe.Enabled = add;
        }


        /// <summary>
        /// This method calls when user click on the add button and creates a new Recipe objects withh the user inputs. The new object add in the array for Recipe objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            string[] ing= currRecipe.Ingreidents;
            bool ok = recipeMng.Add(tbNewName.Text.Trim(), (FoodCategory)cbNewCategory.SelectedItem, tbDiscrip.Text.Trim(),ing);
            if (!ok)
            {
                MessageBox.Show("Maximum recipes are achieved");
            }
            currRecipe = new Recipe(numOfIngredients);
            ing = new string[0];
            UpdateGUI();
        }

        /// <summary>
        /// This method refresh the GUI.
        /// </summary>
        private void UpdateGUI()
        {
            cbNewCategory.SelectedIndex = 0; // current category : Vegetarian
            tbNewName.Text = string.Empty;   // clear text box for name
            tbDiscrip.Text = string.Empty;    // clear text box for discription
            refreshList();
        }

        /// <summary>
        /// This method refresh the listbox on the gui
        /// </summary>
        private void refreshList()
        {
            string[] arr = recipeMng.RecipeListToString(); // get all recipes as a string array
            listBoxMain.Items.Clear();       // celar the lisbox
            listBoxMain.Items.AddRange(arr); // adds all recipes in the listBox
            listBoxMain.SelectedIndex = -1;  // no elemt is selected in the listBox
            EnableButtons(false,false,true);
        }

      
        /// <summary>
        /// This method calls when user click on the Add Ingreindent button. Whith click opens a new windows for that user can add new ingreidents in the current recipe object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIng_Click(object sender, EventArgs e)
        {
            FormIngdredients dlg = new FormIngdredients(currRecipe); // Create a new form
            DialogResult dlgResult = dlg.ShowDialog();  // show the new form
            if (dlgResult == DialogResult.OK)   // if user clcik on the ok button in the new form
            {
                if (currRecipe.GetCurrentNumOfIngreidents() <= 0)
                {
                    MessageBox.Show("No ingredients specified!");                    
                }
            }

        }

        /// <summary>
        /// This method calls when user click on the button Edit. Selected item values repleces with the new user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = listBoxMain.SelectedIndex;
            if (index >= 0 && CheckInput())
            {
                currRecipe.Name = tbNewName.Text;
                currRecipe.Category = (FoodCategory) cbNewCategory.SelectedItem;
                currRecipe.Description = tbDiscrip.Text;
                recipeMng.ChangeElement(index,currRecipe);
                currRecipe = new Recipe(numOfIngredients);
                UpdateGUI();

            }

        }

        /// <summary>
        /// Ths method calls when user click on the button delete. Selected item in the listbox removes from the listBox and array for Recipe objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxMain.SelectedIndex;
            if (index >= 0)
            {
              recipeMng.DeleteElement(index);
              currRecipe = new Recipe(numOfIngredients);
                UpdateGUI();
            }
        }

        private void cbNewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
