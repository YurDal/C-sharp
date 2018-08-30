namespace Assignment4v2
{
    partial class FormMain
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
            this.gbAddNew = new System.Windows.Forms.GroupBox();
            this.tbDiscrip = new System.Windows.Forms.RichTextBox();
            this.cbNewCategory = new System.Windows.Forms.ComboBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.labelNewName = new System.Windows.Forms.Label();
            this.btnAddIng = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labellName = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.gbAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddNew
            // 
            this.gbAddNew.Controls.Add(this.tbDiscrip);
            this.gbAddNew.Controls.Add(this.cbNewCategory);
            this.gbAddNew.Controls.Add(this.tbNewName);
            this.gbAddNew.Controls.Add(this.lblCategory);
            this.gbAddNew.Controls.Add(this.labelNewName);
            this.gbAddNew.Controls.Add(this.btnAddIng);
            this.gbAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbAddNew.Location = new System.Drawing.Point(12, 12);
            this.gbAddNew.Name = "gbAddNew";
            this.gbAddNew.Size = new System.Drawing.Size(379, 393);
            this.gbAddNew.TabIndex = 0;
            this.gbAddNew.TabStop = false;
            this.gbAddNew.Text = "Add new recipe";
            // 
            // tbDiscrip
            // 
            this.tbDiscrip.Location = new System.Drawing.Point(19, 109);
            this.tbDiscrip.Name = "tbDiscrip";
            this.tbDiscrip.Size = new System.Drawing.Size(354, 284);
            this.tbDiscrip.TabIndex = 5;
            this.tbDiscrip.Text = "";
            // 
            // cbNewCategory
            // 
            this.cbNewCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNewCategory.FormattingEnabled = true;
            this.cbNewCategory.Location = new System.Drawing.Point(157, 72);
            this.cbNewCategory.Name = "cbNewCategory";
            this.cbNewCategory.Size = new System.Drawing.Size(121, 25);
            this.cbNewCategory.TabIndex = 4;
            this.cbNewCategory.SelectedIndexChanged += new System.EventHandler(this.cbNewCategory_SelectedIndexChanged);
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(157, 36);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(222, 23);
            this.tbNewName.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(16, 72);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(16, 36);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(104, 17);
            this.labelNewName.TabIndex = 1;
            this.labelNewName.Text = "Name of recipe";
            // 
            // btnAddIng
            // 
            this.btnAddIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddIng.Location = new System.Drawing.Point(284, 72);
            this.btnAddIng.Name = "btnAddIng";
            this.btnAddIng.Size = new System.Drawing.Size(95, 25);
            this.btnAddIng.TabIndex = 0;
            this.btnAddIng.Text = "Add Ingredients";
            this.btnAddIng.UseVisualStyleBackColor = true;
            this.btnAddIng.Click += new System.EventHandler(this.btnAddIng_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(31, 411);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(354, 23);
            this.btnAddRecipe.TabIndex = 1;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(487, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Recipe";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(642, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Recipe";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labellName
            // 
            this.labellName.AutoSize = true;
            this.labellName.Location = new System.Drawing.Point(446, 58);
            this.labellName.Name = "labellName";
            this.labellName.Size = new System.Drawing.Size(35, 13);
            this.labellName.TabIndex = 4;
            this.labellName.Text = "Name";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Location = new System.Drawing.Point(518, 58);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(68, 13);
            this.labelNo.TabIndex = 5;
            this.labelNo.Text = "Num. of. Ing.";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(623, 58);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Category";
            // 
            // labelDiscription
            // 
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Location = new System.Drawing.Point(712, 58);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(56, 13);
            this.labelDiscription.TabIndex = 7;
            this.labelDiscription.Text = "Discription";
            // 
            // listBoxMain
            // 
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(423, 102);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(361, 303);
            this.listBoxMain.TabIndex = 8;
            this.listBoxMain.SelectedIndexChanged += new System.EventHandler(this.listBoxMain_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 503);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.labelDiscription);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.labellName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.gbAddNew);
            this.Name = "FormMain";
            this.Text = "A Cook Book";
            this.gbAddNew.ResumeLayout(false);
            this.gbAddNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddNew;
        private System.Windows.Forms.RichTextBox tbDiscrip;
        private System.Windows.Forms.ComboBox cbNewCategory;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.Button btnAddIng;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labellName;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDiscription;
        private System.Windows.Forms.ListBox listBoxMain;
    }
}

