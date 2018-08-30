namespace PersonalFinanceApp
{
    partial class ExpenditureForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerExp = new System.Windows.Forms.DateTimePicker();
            this.tbDescriptionExp = new System.Windows.Forms.TextBox();
            this.cbExp = new System.Windows.Forms.ComboBox();
            this.tbAmountExp = new System.Windows.Forms.TextBox();
            this.btnOkExp = new System.Windows.Forms.Button();
            this.btnCancelExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount (SEK)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // dateTimePickerExp
            // 
            this.dateTimePickerExp.Location = new System.Drawing.Point(128, 55);
            this.dateTimePickerExp.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerExp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerExp.Name = "dateTimePickerExp";
            this.dateTimePickerExp.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerExp.TabIndex = 7;
            // 
            // tbDescriptionExp
            // 
            this.tbDescriptionExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptionExp.Location = new System.Drawing.Point(128, 122);
            this.tbDescriptionExp.Name = "tbDescriptionExp";
            this.tbDescriptionExp.Size = new System.Drawing.Size(218, 22);
            this.tbDescriptionExp.TabIndex = 8;
            // 
            // cbExp
            // 
            this.cbExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExp.FormattingEnabled = true;
            this.cbExp.Location = new System.Drawing.Point(128, 191);
            this.cbExp.Name = "cbExp";
            this.cbExp.Size = new System.Drawing.Size(218, 21);
            this.cbExp.TabIndex = 9;
            // 
            // tbAmountExp
            // 
            this.tbAmountExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmountExp.Location = new System.Drawing.Point(128, 258);
            this.tbAmountExp.Name = "tbAmountExp";
            this.tbAmountExp.Size = new System.Drawing.Size(218, 22);
            this.tbAmountExp.TabIndex = 10;
            // 
            // btnOkExp
            // 
            this.btnOkExp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkExp.ForeColor = System.Drawing.Color.Black;
            this.btnOkExp.Location = new System.Drawing.Point(48, 329);
            this.btnOkExp.Name = "btnOkExp";
            this.btnOkExp.Size = new System.Drawing.Size(88, 25);
            this.btnOkExp.TabIndex = 11;
            this.btnOkExp.Text = "OK";
            this.btnOkExp.UseVisualStyleBackColor = true;
            this.btnOkExp.Click += new System.EventHandler(this.btnOkExp_Click);
            // 
            // btnCancelExp
            // 
            this.btnCancelExp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelExp.ForeColor = System.Drawing.Color.Black;
            this.btnCancelExp.Location = new System.Drawing.Point(202, 329);
            this.btnCancelExp.Name = "btnCancelExp";
            this.btnCancelExp.Size = new System.Drawing.Size(88, 25);
            this.btnCancelExp.TabIndex = 12;
            this.btnCancelExp.Text = "Cancel";
            this.btnCancelExp.UseVisualStyleBackColor = true;
            this.btnCancelExp.Click += new System.EventHandler(this.btnCancelExp_Click);
            // 
            // ExpenditureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(358, 382);
            this.Controls.Add(this.btnCancelExp);
            this.Controls.Add(this.btnOkExp);
            this.Controls.Add(this.tbAmountExp);
            this.Controls.Add(this.cbExp);
            this.Controls.Add(this.tbDescriptionExp);
            this.Controls.Add(this.dateTimePickerExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ExpenditureForm";
            this.Text = "ExpenditureForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpenditureForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerExp;
        private System.Windows.Forms.TextBox tbDescriptionExp;
        private System.Windows.Forms.ComboBox cbExp;
        private System.Windows.Forms.TextBox tbAmountExp;
        private System.Windows.Forms.Button btnOkExp;
        private System.Windows.Forms.Button btnCancelExp;
    }
}