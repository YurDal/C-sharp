namespace Assignment4v2
{
    partial class FormIngdredients
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
            this.bgIng = new System.Windows.Forms.GroupBox();
            this.listBoxIng = new System.Windows.Forms.ListBox();
            this.btnIngDelete = new System.Windows.Forms.Button();
            this.btnIngEdit = new System.Windows.Forms.Button();
            this.btnAddIng = new System.Windows.Forms.Button();
            this.tbAddIng = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bgIng.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgIng
            // 
            this.bgIng.Controls.Add(this.listBoxIng);
            this.bgIng.Controls.Add(this.btnIngDelete);
            this.bgIng.Controls.Add(this.btnIngEdit);
            this.bgIng.Controls.Add(this.btnAddIng);
            this.bgIng.Controls.Add(this.tbAddIng);
            this.bgIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bgIng.Location = new System.Drawing.Point(12, 12);
            this.bgIng.Name = "bgIng";
            this.bgIng.Size = new System.Drawing.Size(415, 352);
            this.bgIng.TabIndex = 0;
            this.bgIng.TabStop = false;
            this.bgIng.Text = "Ingredients";
            // 
            // listBoxIng
            // 
            this.listBoxIng.FormattingEnabled = true;
            this.listBoxIng.ItemHeight = 17;
            this.listBoxIng.Location = new System.Drawing.Point(6, 62);
            this.listBoxIng.Name = "listBoxIng";
            this.listBoxIng.Size = new System.Drawing.Size(322, 276);
            this.listBoxIng.TabIndex = 5;
            this.listBoxIng.SelectedIndexChanged += new System.EventHandler(this.listBoxIng_SelectedIndexChanged);
            // 
            // btnIngDelete
            // 
            this.btnIngDelete.Location = new System.Drawing.Point(334, 228);
            this.btnIngDelete.Name = "btnIngDelete";
            this.btnIngDelete.Size = new System.Drawing.Size(75, 23);
            this.btnIngDelete.TabIndex = 4;
            this.btnIngDelete.Text = "Delete";
            this.btnIngDelete.UseVisualStyleBackColor = true;
            this.btnIngDelete.Click += new System.EventHandler(this.btnIngDelete_Click);
            // 
            // btnIngEdit
            // 
            this.btnIngEdit.Location = new System.Drawing.Point(334, 141);
            this.btnIngEdit.Name = "btnIngEdit";
            this.btnIngEdit.Size = new System.Drawing.Size(75, 23);
            this.btnIngEdit.TabIndex = 3;
            this.btnIngEdit.Text = "Edit";
            this.btnIngEdit.UseVisualStyleBackColor = true;
            this.btnIngEdit.Click += new System.EventHandler(this.btnIngEdit_Click);
            // 
            // btnAddIng
            // 
            this.btnAddIng.Location = new System.Drawing.Point(334, 33);
            this.btnAddIng.Name = "btnAddIng";
            this.btnAddIng.Size = new System.Drawing.Size(75, 23);
            this.btnAddIng.TabIndex = 2;
            this.btnAddIng.Text = "Add";
            this.btnAddIng.UseVisualStyleBackColor = true;
            this.btnAddIng.Click += new System.EventHandler(this.btnAddIng_Click);
            // 
            // tbAddIng
            // 
            this.tbAddIng.Location = new System.Drawing.Point(6, 33);
            this.tbAddIng.Name = "tbAddIng";
            this.tbAddIng.Size = new System.Drawing.Size(322, 23);
            this.tbAddIng.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(63, 370);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(209, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormIngdredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.bgIng);
            this.Name = "FormIngdredients";
            this.Text = "FormIngdredients";
            this.bgIng.ResumeLayout(false);
            this.bgIng.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgIng;
        private System.Windows.Forms.TextBox tbAddIng;
        private System.Windows.Forms.Button btnIngDelete;
        private System.Windows.Forms.Button btnIngEdit;
        private System.Windows.Forms.Button btnAddIng;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBoxIng;
    }
}