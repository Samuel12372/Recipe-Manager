namespace FoodRecipeManager2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPanelClose = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearchRecipe = new System.Windows.Forms.Button();
            this.lbxSearchHistory = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblMethod);
            this.panel1.Controls.Add(this.lblIngredients);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPanelClose);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(358, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 744);
            this.panel1.TabIndex = 11;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(222, 110);
            this.lblMethod.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(61, 20);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "Method";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(3, 188);
            this.lblIngredients.MaximumSize = new System.Drawing.Size(204, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(83, 20);
            this.lblIngredients.TabIndex = 4;
            this.lblIngredients.Text = "Ingredients";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnPanelClose
            // 
            this.btnPanelClose.Location = new System.Drawing.Point(919, 4);
            this.btnPanelClose.Name = "btnPanelClose";
            this.btnPanelClose.Size = new System.Drawing.Size(38, 28);
            this.btnPanelClose.TabIndex = 2;
            this.btnPanelClose.Text = "X";
            this.btnPanelClose.UseVisualStyleBackColor = true;
            this.btnPanelClose.Click += new System.EventHandler(this.btnPanelClose_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(222, 38);
            this.lblDescription.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(41, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Desc";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(222, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 813);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblHome.Location = new System.Drawing.Point(358, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(157, 54);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.MouseEnter += new System.EventHandler(this.lblHome_MouseEnter);
            this.lblHome.MouseLeave += new System.EventHandler(this.lblHome_MouseLeave);
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblRecipes.Location = new System.Drawing.Point(521, 9);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(208, 54);
            this.lblRecipes.TabIndex = 1;
            this.lblRecipes.Text = "Recipes";
            this.lblRecipes.Click += new System.EventHandler(this.lblRecipes_Click);
            this.lblRecipes.MouseEnter += new System.EventHandler(this.lblRecipes_MouseEnter);
            this.lblRecipes.MouseLeave += new System.EventHandler(this.lblRecipes_MouseLeave);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(1064, 34);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(175, 27);
            this.txtSearchBar.TabIndex = 7;
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // btnSearchRecipe
            // 
            this.btnSearchRecipe.Location = new System.Drawing.Point(1245, 30);
            this.btnSearchRecipe.Name = "btnSearchRecipe";
            this.btnSearchRecipe.Size = new System.Drawing.Size(73, 33);
            this.btnSearchRecipe.TabIndex = 6;
            this.btnSearchRecipe.Text = "Search";
            this.btnSearchRecipe.UseVisualStyleBackColor = true;
            this.btnSearchRecipe.Click += new System.EventHandler(this.btnSearchRecipe_Click);
            // 
            // lbxSearchHistory
            // 
            this.lbxSearchHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxSearchHistory.FormattingEnabled = true;
            this.lbxSearchHistory.ItemHeight = 20;
            this.lbxSearchHistory.Location = new System.Drawing.Point(1064, 60);
            this.lbxSearchHistory.Name = "lbxSearchHistory";
            this.lbxSearchHistory.Size = new System.Drawing.Size(175, 100);
            this.lbxSearchHistory.TabIndex = 12;
            this.lbxSearchHistory.SelectedIndexChanged += new System.EventHandler(this.lbxSearchHistory_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1349, 837);
            this.Controls.Add(this.lbxSearchHistory);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRecipes);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnSearchRecipe);
            this.Name = "Form1";
            this.Text = "Recipe Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnPanelClose;
        private Label lblDescription;
        private Label lblTitle;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblHome;
        private Label lblRecipes;
        private Label label1;
        private TextBox txtSearchBar;
        private Button btnSearchRecipe;
        private PictureBox pictureBox1;
        private Label lblMethod;
        private Label lblIngredients;
        private ListBox lbxSearchHistory;
    }
}