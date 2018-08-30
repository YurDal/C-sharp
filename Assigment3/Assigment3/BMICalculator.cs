using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3
{
    /// <summary>
    /// @author Yurdaer Dalkic 
    /// date : 05/11/2017
    /// This class computes the BMI and has private fields
    /// that are accesable via getter and setter methods.
    /// </summary>
    class BMICalculator
    {
        private string name = "No name";
        private double height = 0; // m, inch
        private double weight = 0; // kg, lb
        private UnitTypes unit; // Metric or US

        /// <summary>
        /// This method computes depends on private fields "height" and "weight".
        /// Input values "height" and "weight" can be metric or US units.
        /// </summary>
        /// <returns> The BMI value </returns>
        internal double CalculateBMI()
        {
            double bmi;
            if (unit == UnitTypes.American)
            {
                bmi = (703 * weight) / (height * height);
            }
            else
            {
                bmi = (weight) / (height * height);
                Console.WriteLine(weight+"  "+height);
            }
            return bmi;
        }

      
        /// <summary>
        /// Method that sets the weight category depending on the value of BMI.
        /// </summary>
        /// <returns> Weight category based on the BMI value </returns>
        internal string bmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string str = string.Empty;
            if (bmi > 40)
            {
                str = "Overweight (Obesity class III)";
            }
            else  if (bmi <= 40 && bmi > 35)
            {
                str = "Overweight (Obesity class II)";
            }
            else if (bmi < 35 && bmi >= 30)
            {
                str = "Overweight (Obesity class I)";
            }
            else if (bmi < 30 && bmi >= 25)
            {
                str = "Overweight (Pre-Obesity)";
            }
            else if (bmi < 25 && bmi >= 18.5)
            {
                str = "Normal weight";
            }
            else if (bmi< 18.5)
            {
                str = "Underweight";
            }
            return str;

        }

        /// <summary>
        /// Setter method: Changes (overwrites) private field unit.
        /// </summary>
        /// <param name="value"> Input: new UnitTypes to be saved in units </param>
        internal void SetUnit(UnitTypes value)
        {
                this.unit = value;
        }

        /// <summary>
        /// Getter method: connected to unit-field.
        /// </summary>
        /// <returns> UnitTypes stored in the field unit. </returns>
        internal UnitTypes getUnit()
        {
            return unit;
        }

        /// <summary>
        /// Getter method: connected to height-field.
        /// </summary>
        /// <returns> The value stored in the field height. </returns>
        private double getHeight()
        {
            return height;
        }

        /// <summary>
        /// Getter method: connected to weight-field.
        /// </summary>
        /// <returns> The value stored in the field weight. </returns>
        private double getWeight()
        {
            return weight;
        }

        /// <summary>
        /// Setter method: Changes (overwrites) private field height.
        /// </summary>
        /// <param name="value"> Input: new value to be saved in height </param>
        internal void SetHeight(double height)
        {
            if (height > 0)
            {
                this.height = height;
            }
        }

        /// <summary>
        /// Setter method: Changes (overwrites) private field weight.
        /// </summary>
        /// <param name="value"> Input: new value to be saved in weight </param>
        internal void SetWeight(double value)
        {
            if (value > 0)
            {
                this.weight = value;
            }
        }

        /// <summary>
        /// Setter method: Changes (overwrites) private field name.
        /// </summary>
        /// <param name="value"> Input: new value to be saved in name </param>
        internal void setName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.name = name;
            }
           
        }

        /// <summary>
        /// Getter method: connected to name-field.
        /// </summary>
        /// <returns> The value stored in the field name. </returns>
        internal string getName()
        {
            return name;
        }
    }
}
