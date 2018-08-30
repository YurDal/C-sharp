using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4v2
{
    
    /// <summary>
    /// @ author Yurdaer Dalkic
    /// This is a GUI that user can add new ingreidents in the current recipe object
    /// </summary>
    public partial class FormIngdredients : Form
    {
       private Recipe mRecipe;
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="recipe"> Recipe object which user can add new ingredients </param>
        public FormIngdredients(Recipe recipe)
        {
            InitializeComponent();
            mRecipe = recipe;
            if (string.IsNullOrEmpty(recipe.Name))
            {
                this.Text = "No Recipe Name";
            }
            else
            {
                this.Text = recipe.Name + "Add ingredients";
            }
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            if (mRecipe.Ingreidents == null)
            {
                mRecipe.Ingreidents = new string[mRecipe.MaxNumOfIngreidents];
            }
            UpdateGUI();
        }

        /// <summary>
        /// This method calls when user click on the add ingreidents button. User input adds in the recipe object as a new ingreindent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIng_Click(object sender, EventArgs e)
        {
            if (CheckInput())  // checks if the user input is null or empty
            {

               bool ok = mRecipe.AddIngreident(tbAddIng.Text);
                if (!ok)
                {
                    MessageBox.Show("Maximum ingreidents are achieved");
                }
               UpdateGUI();

            }
        }

        /// <summary>
        /// This method calls when the user click on the Edit button. Selected ingreident repleces with the new user input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngEdit_Click(object sender, EventArgs e)
        {
            int index = listBoxIng.SelectedIndex;
            if (index >= 0)
            {
                mRecipe.ChangeIngreidentAt(index, tbAddIng.Text);
                UpdateGUI();
            }
        }

        /// <summary>
        /// This method checks if the user input is noll or empty
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            return !(string.IsNullOrEmpty(tbAddIng.Text));
        }

        /// <summary>
        /// This method checks if the user input is null or empty
        /// </summary>
        private void UpdateGUI()
        {
            tbAddIng.Text = ""; // clear the textBox
            listBoxIng.Items.Clear(); // clear the listBox
            listBoxIng.Items.AddRange(mRecipe.Ingreidents); // add all ingeridents in the listBox
            listBoxIng.SelectedIndex = -1; // no item is will be selected
            DisableButtons(); // desable edit and delete buttons
        }

        /// <summary>
        /// This method calss when user click on the delete button. Selected ingredient removes from the array and and listBox for ingreidents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxIng.SelectedIndex;
            if (index >= 0)
            {
                mRecipe.DeleteIngreidentAt(index);
                mRecipe.SortIngreidentArray();
                UpdateGUI();
            }
        }

     

        /// <summary>
        /// This method enables buttons for edit and delete
        /// </summary>
        private void EnableButtons()
        {
            btnIngDelete.Enabled = true;
            btnIngEdit.Enabled = true;
        }
        /// <summary>
        /// This method disables buttons for edit and delete
        /// </summary>
        private void DisableButtons()
        {
            btnIngDelete.Enabled = false;
            btnIngEdit.Enabled = false;


        }

        /// <summary>
        /// This method calls when user click on a item on the listBox fo ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxIng_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int index = listBoxIng.SelectedIndex;
            if (index >= 0)
            {
                tbAddIng.Text = mRecipe.Ingreidents[index]; // fill gui with selected items information
                EnableButtons();
            }
        }

     
    }
}
