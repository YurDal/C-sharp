using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    /// <summary>
    /// @ author Yurdaer Dalkic
    ///  The GUI that user can add a new task in the to do list.
    /// </summary>
    public partial class MainForm : Form
    {
        private Files.TaskManager taskManager;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            taskManager = new Files.TaskManager();
        }

        /// <summary>
        /// This method clears all user input from the GUI and makes all necesseery configuration.
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "To Do Reminder Yurdaer";
            taskManager = new Files.TaskManager();
            comboBox.Items.Clear();
            string[] priority = Enum.GetNames(typeof(Files.PriorityType));
            foreach (var item in priority) comboBox.Items.Add(item.Replace("_", " "));
            comboBox.SelectedItem = Files.PriorityType.Normal.ToString().Replace("_"," ");
            toolTip.SetToolTip(dateTimePicker, "Click to open calender for date, write in time here");
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd    HH:mm";
            menuFileOpen.Enabled = false;
            menuFileSave.Enabled = false;
            textBox.Text = "";
            listBox.Items.Clear();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method updates the timeLabel every second with new time data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Seconds_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// This method close the program after a confirmation message given to the user and when the user clicks the OK button in the message box.
        /// Do not closes the application if the user presses the Cancel button, nothing changes in this case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ResultFromInputDialog();
        }

        /// <summary>
        /// This method shows a conformation message and retrund the users choose as true or false.
        /// </summary>
        /// <returns></returns>
        private bool ResultFromInputDialog()
        {
            DialogResult result = MessageBox.Show("Sure to exit program ?","Think twice",MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
                return true;
            else
                return false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the user selects the sub-menu Help - Om..., an About Box  displays.
        /// About box contains infromation about the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        /// <summary>
        /// This method reset the program without terminate it When the user selects the sub-menu New
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }


        /// <summary>
        /// This method close the program after a confirmation message given to the user and when the user clicks the OK button in the message box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// This method calls when user click on button btnAdd and user adds a new task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Files.Task newTask = GetTaskFromUserInputs();
            if(newTask != null)
            {
                taskManager.Add(newTask);
                UpdateGUI();
            }
        }

        /// <summary>
        /// This methid updates the GUI
        /// </summary>
        private void UpdateGUI()
        {
            listBox.Items.Clear();
            string[] arr = taskManager.ListToStringArray();
            if (arr != null)
            {
                listBox.Items.AddRange(arr);
            }
        }

        /// <summary>
        /// This method creats a new task from user input and returns it.
        /// </summary>
        /// <returns></returns>
        private Files.Task GetTaskFromUserInputs()
        {
            Files.Task task;
            if (CheckUserInputs())
            {
                return task = new Files.Task(dateTimePicker.Value, (Files.PriorityType)Enum.Parse(typeof(Files.PriorityType), comboBox.SelectedItem.ToString().Replace(" ","_")), textBox.Text);
            }
            else
                return null;
        }

        /// <summary>
        /// This method checks the user input.
        /// </summary>
        /// <returns></returns>
        private bool CheckUserInputs()
        {
            return !string.IsNullOrEmpty(textBox.Text.ToString()) && comboBox.SelectedIndex != -1; 
        }
    }
}
