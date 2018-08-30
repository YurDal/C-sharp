namespace Assigment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.gbUnit = new System.Windows.Forms.GroupBox();
            this.radioUS = new System.Windows.Forms.RadioButton();
            this.radioMetric = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.labelResultInfo = new System.Windows.Forms.Label();
            this.labelResultCategory = new System.Windows.Forms.Label();
            this.labelResultBMI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResultW = new System.Windows.Forms.Label();
            this.gbUnit.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelName.Location = new System.Drawing.Point(38, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Your Name";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelHeight.Location = new System.Drawing.Point(38, 64);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(81, 17);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height (cm)";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelWeight.Location = new System.Drawing.Point(38, 101);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(81, 17);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Weight (kg)";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(157, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(306, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(157, 64);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 4;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(157, 101);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 5;
            // 
            // gbUnit
            // 
            this.gbUnit.Controls.Add(this.radioUS);
            this.gbUnit.Controls.Add(this.radioMetric);
            this.gbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbUnit.Location = new System.Drawing.Point(292, 64);
            this.gbUnit.Name = "gbUnit";
            this.gbUnit.Size = new System.Drawing.Size(171, 100);
            this.gbUnit.TabIndex = 6;
            this.gbUnit.TabStop = false;
            this.gbUnit.Text = "Unit";
            // 
            // radioUS
            // 
            this.radioUS.AutoSize = true;
            this.radioUS.Location = new System.Drawing.Point(21, 60);
            this.radioUS.Name = "radioUS";
            this.radioUS.Size = new System.Drawing.Size(138, 21);
            this.radioUS.TabIndex = 1;
            this.radioUS.TabStop = true;
            this.radioUS.Text = "US Unit ( foot lbs)";
            this.radioUS.UseVisualStyleBackColor = true;
            this.radioUS.CheckedChanged += new System.EventHandler(this.radioUS_CheckedChanged);
            // 
            // radioMetric
            // 
            this.radioMetric.AutoSize = true;
            this.radioMetric.Location = new System.Drawing.Point(21, 33);
            this.radioMetric.Name = "radioMetric";
            this.radioMetric.Size = new System.Drawing.Size(142, 21);
            this.radioMetric.TabIndex = 0;
            this.radioMetric.TabStop = true;
            this.radioMetric.Text = "Metric unit (cm kg)";
            this.radioMetric.UseVisualStyleBackColor = true;
            this.radioMetric.CheckedChanged += new System.EventHandler(this.radioMetric_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCalculate.Location = new System.Drawing.Point(180, 185);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 36);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.labelResultInfo);
            this.gbResult.Controls.Add(this.labelResultCategory);
            this.gbResult.Controls.Add(this.labelResultBMI);
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Controls.Add(this.labelResult);
            this.gbResult.Controls.Add(this.labelResultW);
            this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbResult.Location = new System.Drawing.Point(41, 244);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(422, 194);
            this.gbResult.TabIndex = 8;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Results for";
            // 
            // labelResultInfo
            // 
            this.labelResultInfo.ForeColor = System.Drawing.Color.Lime;
            this.labelResultInfo.Location = new System.Drawing.Point(70, 125);
            this.labelResultInfo.Name = "labelResultInfo";
            this.labelResultInfo.Size = new System.Drawing.Size(346, 25);
            this.labelResultInfo.TabIndex = 6;
            this.labelResultInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelResultCategory
            // 
            this.labelResultCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultCategory.Location = new System.Drawing.Point(168, 73);
            this.labelResultCategory.Name = "labelResultCategory";
            this.labelResultCategory.Size = new System.Drawing.Size(246, 19);
            this.labelResultCategory.TabIndex = 5;
            this.labelResultCategory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelResultBMI
            // 
            this.labelResultBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultBMI.Location = new System.Drawing.Point(323, 37);
            this.labelResultBMI.Name = "labelResultBMI";
            this.labelResultBMI.Size = new System.Drawing.Size(87, 19);
            this.labelResultBMI.TabIndex = 4;
            this.labelResultBMI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelResult.Location = new System.Drawing.Point(30, 39);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(65, 17);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Your BMI";
            // 
            // labelResultW
            // 
            this.labelResultW.AutoSize = true;
            this.labelResultW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelResultW.Location = new System.Drawing.Point(30, 73);
            this.labelResultW.Name = "labelResultW";
            this.labelResultW.Size = new System.Drawing.Size(113, 17);
            this.labelResultW.TabIndex = 1;
            this.labelResultW.Text = "Weight Category";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 462);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbUnit);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelName);
            this.Name = "MainForm";
            this.Text = "Universal Calculator";
            this.gbUnit.ResumeLayout(false);
            this.gbUnit.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.GroupBox gbUnit;
        private System.Windows.Forms.RadioButton radioUS;
        private System.Windows.Forms.RadioButton radioMetric;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelResultW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResultInfo;
        private System.Windows.Forms.Label labelResultCategory;
        private System.Windows.Forms.Label labelResultBMI;
    }

   
}

