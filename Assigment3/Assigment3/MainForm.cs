using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment3
{
    /// <summary>
    /// @author Yurdaer Dalkic 
    /// date : 05/11/2017
    /// The MainForm constructor - will run as soon as the GUI is created.
    /// </summary>
    public partial class MainForm : Form
    {
        private BMICalculator bMI = new BMICalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// This method calls when button btnCalculate clicks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                DisplayResult();
            }

        }

        /// <summary>
        /// This method displays the result based on the input value.
        /// </summary>
        private void DisplayResult()
        {
            labelResultBMI.Text = bMI.CalculateBMI().ToString("f2");
            labelResultCategory.Text = bMI.bmiWeightCategory().ToString();
            gbResult.Text = "Result for " + bMI.getName();
            labelResultInfo.Text = "Normal BMI is between 18.50 and 24.9";
        }


        /// <summary>
        /// This method calls when radio button radioMetric checked and change input types to metric units (cm, kg).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMetric.Checked)
            {
                labelHeight.Text = "Height (cm)";
                labelWeight.Text = "Weight (kg)";
                bMI.SetUnit(UnitTypes.Metric);
            }

        }


        /// <summary>
        /// This method calls when radio button radioUS checked and change input types to American system (feet, lbs).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioUS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUS.Checked)
            {
                labelHeight.Text = "Height (feet)";
                labelWeight.Text = "Weight (lbs)";
                bMI.SetUnit(UnitTypes.American);
            }
        }


        /// <summary>
        /// Read the input height from the dedicated textbox (tbHeight)
        /// Validate input and if ok writes data to BMI object.
        /// Height must be in converted to m (if read as cm) or inch (from feet).
        /// </summary>
        /// <returns></returns>
        private bool ReadHeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(tbHeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (bMI.getUnit() == UnitTypes.American)
                    {
                        bMI.SetHeight(outValue * 12.00);
                    }
                    else
                    {
                        bMI.SetHeight(outValue / 100.0);
                    }
                }
                else
                    ok = false;
            }

            if (!ok)
                MessageBox.Show("Invalid height value!","Error");

            return ok;
        }

        /// <summary>
        /// The method calls other methods for read all input values.
        /// </summary>
        /// <returns></returns>
        private bool ReadInputBMI()
        {
            ReadName();
            return (ReadHeight() &&  ReadWeight());
        }


        /// <summary>
        /// Read the input name from the dedicated textbox (tbName)
        /// Validate input and if ok writes data to BMI object.
        /// </summary>
        /// <returns></returns>
        private void ReadName()
        {
            string name = "";
            bool ok = string.IsNullOrEmpty(tbName.Text);
            if (!ok)
            {
                name = tbName.Text;
                bMI.setName(name);
             
            }
            else
            {
                name = "Unknown";
                bMI.setName(name);
            }

        }

        /// <summary>
        /// Read the input weight from the dedicated textbox (tbWeight)
        /// Validate input and if ok writes data to BMI object.
        /// Weight must be kg or lbs.
        /// </summary>
        /// <returns></returns>
        private bool ReadWeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(tbWeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (bMI.getUnit() == UnitTypes.American)
                    {
                        bMI.SetWeight(outValue);
                    }
                    else
                    {
                        bMI.SetWeight(outValue);
                    }
                }
                else
                    ok = false;
            }

            if (!ok)
                MessageBox.Show("Invalid weight value!", "Error");

            return ok;
        }

        /// <summary>
        /// Initialize the GUI with some preset options.
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "The Body Mass Calculator";
            radioUS.Checked = true;
            labelHeight.Text = "Height (feet)";
            labelWeight.Text = "Weight (lbs)";
            tbHeight.Text = string.Empty;
            tbWeight.Text = string.Empty;
        }


    }
}
