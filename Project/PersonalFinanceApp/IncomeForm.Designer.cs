namespace PersonalFinanceApp
{
    partial class IncomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescriptionIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerIncome = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIncome = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmountIncome = new System.Windows.Forms.TextBox();
            this.btnOkIncome = new System.Windows.Forms.Button();
            this.btnCancelExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // tbDescriptionIncome
            // 
            this.tbDescriptionIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptionIncome.Location = new System.Drawing.Point(128, 119);
            this.tbDescriptionIncome.Name = "tbDescriptionIncome";
            this.tbDescriptionIncome.Size = new System.Drawing.Size(218, 22);
            this.tbDescriptionIncome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // dateTimePickerIncome
            // 
            this.dateTimePickerIncome.Location = new System.Drawing.Point(128, 54);
            this.dateTimePickerIncome.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerIncome.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerIncome.Name = "dateTimePickerIncome";
            this.dateTimePickerIncome.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerIncome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // cbIncome
            // 
            this.cbIncome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIncome.FormattingEnabled = true;
            this.cbIncome.Location = new System.Drawing.Point(128, 190);
            this.cbIncome.Name = "cbIncome";
            this.cbIncome.Size = new System.Drawing.Size(218, 21);
            this.cbIncome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount (SEK)";
            // 
            // tbAmountIncome
            // 
            this.tbAmountIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmountIncome.Location = new System.Drawing.Point(128, 258);
            this.tbAmountIncome.Name = "tbAmountIncome";
            this.tbAmountIncome.Size = new System.Drawing.Size(218, 22);
            this.tbAmountIncome.TabIndex = 7;
            // 
            // btnOkIncome
            // 
            this.btnOkIncome.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkIncome.ForeColor = System.Drawing.Color.Black;
            this.btnOkIncome.Location = new System.Drawing.Point(57, 328);
            this.btnOkIncome.Name = "btnOkIncome";
            this.btnOkIncome.Size = new System.Drawing.Size(88, 25);
            this.btnOkIncome.TabIndex = 8;
            this.btnOkIncome.Text = "OK";
            this.btnOkIncome.UseVisualStyleBackColor = true;
            this.btnOkIncome.Click += new System.EventHandler(this.btnOkIncome_Click);
            // 
            // btnCancelExp
            // 
            this.btnCancelExp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelExp.ForeColor = System.Drawing.Color.Black;
            this.btnCancelExp.Location = new System.Drawing.Point(200, 328);
            this.btnCancelExp.Name = "btnCancelExp";
            this.btnCancelExp.Size = new System.Drawing.Size(88, 25);
            this.btnCancelExp.TabIndex = 9;
            this.btnCancelExp.Text = "Cancel";
            this.btnCancelExp.UseVisualStyleBackColor = true;
            this.btnCancelExp.Click += new System.EventHandler(this.btnOkCancel_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(358, 382);
            this.Controls.Add(this.btnCancelExp);
            this.Controls.Add(this.btnOkIncome);
            this.Controls.Add(this.tbAmountIncome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescriptionIncome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescriptionIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAmountIncome;
        private System.Windows.Forms.Button btnOkIncome;
        private System.Windows.Forms.Button btnCancelExp;
    }
}