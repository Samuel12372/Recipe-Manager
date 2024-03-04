namespace FoodRecipeManager2
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAR1 = new System.Windows.Forms.Label();
            this.lblAR2 = new System.Windows.Forms.Label();
            this.lblAR3 = new System.Windows.Forms.Label();
            this.lblAR4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pbxRecipeUpload = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearchRecipe = new System.Windows.Forms.Button();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecipeUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(896, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblAR1
            // 
            this.lblAR1.AutoSize = true;
            this.lblAR1.Location = new System.Drawing.Point(23, 393);
            this.lblAR1.Name = "lblAR1";
            this.lblAR1.Size = new System.Drawing.Size(24, 20);
            this.lblAR1.TabIndex = 1;
            this.lblAR1.Text = "ID";
            // 
            // lblAR2
            // 
            this.lblAR2.AutoSize = true;
            this.lblAR2.Location = new System.Drawing.Point(9, 428);
            this.lblAR2.Name = "lblAR2";
            this.lblAR2.Size = new System.Drawing.Size(38, 20);
            this.lblAR2.TabIndex = 2;
            this.lblAR2.Text = "Title";
            // 
            // lblAR3
            // 
            this.lblAR3.AutoSize = true;
            this.lblAR3.Location = new System.Drawing.Point(193, 393);
            this.lblAR3.Name = "lblAR3";
            this.lblAR3.Size = new System.Drawing.Size(85, 20);
            this.lblAR3.TabIndex = 3;
            this.lblAR3.Text = "Description";
            // 
            // lblAR4
            // 
            this.lblAR4.AutoSize = true;
            this.lblAR4.Location = new System.Drawing.Point(5, 456);
            this.lblAR4.Name = "lblAR4";
            this.lblAR4.Size = new System.Drawing.Size(42, 20);
            this.lblAR4.TabIndex = 4;
            this.lblAR4.Text = "Time";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(55, 421);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 27);
            this.txtTitle.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(284, 391);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(292, 27);
            this.txtDesc.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(55, 391);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 27);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(55, 454);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(132, 27);
            this.numericUpDown2.TabIndex = 9;
            // 
            // pbxRecipeUpload
            // 
            this.pbxRecipeUpload.Image = global::FoodRecipeManager2.Properties.Resources.SpagBol;
            this.pbxRecipeUpload.Location = new System.Drawing.Point(55, 488);
            this.pbxRecipeUpload.Name = "pbxRecipeUpload";
            this.pbxRecipeUpload.Size = new System.Drawing.Size(143, 132);
            this.pbxRecipeUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRecipeUpload.TabIndex = 10;
            this.pbxRecipeUpload.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(59, 626);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(128, 25);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(914, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 54);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(914, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 54);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(914, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 54);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblRecipes.Location = new System.Drawing.Point(175, 9);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(208, 54);
            this.lblRecipes.TabIndex = 1;
            this.lblRecipes.Text = "Recipes";
            this.lblRecipes.MouseEnter += new System.EventHandler(this.lblRecipes_MouseEnter);
            this.lblRecipes.MouseLeave += new System.EventHandler(this.lblRecipes_MouseLeave);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblHome.Location = new System.Drawing.Point(12, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(157, 54);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            this.lblHome.MouseEnter += new System.EventHandler(this.lblHome_MouseEnter);
            this.lblHome.MouseLeave += new System.EventHandler(this.lblHome_MouseLeave);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(779, 12);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(175, 27);
            this.txtSearchBar.TabIndex = 17;
            // 
            // btnSearchRecipe
            // 
            this.btnSearchRecipe.Location = new System.Drawing.Point(960, 9);
            this.btnSearchRecipe.Name = "btnSearchRecipe";
            this.btnSearchRecipe.Size = new System.Drawing.Size(73, 33);
            this.btnSearchRecipe.TabIndex = 16;
            this.btnSearchRecipe.Text = "Search";
            this.btnSearchRecipe.UseVisualStyleBackColor = true;
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(284, 428);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(292, 224);
            this.txtIngredients.TabIndex = 18;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(582, 394);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(61, 20);
            this.lblMethod.TabIndex = 19;
            this.lblMethod.Text = "Method";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(195, 424);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(83, 20);
            this.lblIngredients.TabIndex = 20;
            this.lblIngredients.Text = "Ingredients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Image";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(649, 393);
            this.txtMethod.Multiline = true;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(384, 258);
            this.txtMethod.TabIndex = 22;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(914, 331);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(119, 54);
            this.btnSaveToFile.TabIndex = 23;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(914, 298);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(119, 27);
            this.txtFileName.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(914, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "FileName";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 659);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblRecipes);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnSearchRecipe);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbxRecipeUpload);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAR4);
            this.Controls.Add(this.lblAR3);
            this.Controls.Add(this.lblAR2);
            this.Controls.Add(this.lblAR1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecipeUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblAR1;
        private Label lblAR2;
        private Label lblAR3;
        private Label lblAR4;
        private TextBox txtTitle;
        private TextBox txtDesc;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private PictureBox pbxRecipeUpload;
        private Button btnBrowse;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblHome;
        private Label lblRecipes;
        private Label label1;
        private TextBox txtSearchBar;
        private Button btnSearchRecipe;
        private TextBox txtIngredients;
        private Label lblMethod;
        private Label lblIngredients;
        private Label label2;
        private TextBox txtMethod;
        private Button btnSaveToFile;
        private TextBox txtFileName;
        private Label label3;
    }
}