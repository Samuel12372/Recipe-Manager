using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net;

namespace FoodRecipeManager2
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            GenerateDynamicUserControl();
            panel1.Visible = false;
            lbxSearchHistory.Visible = false;    
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        Dictionary<string, DataRow[]> searchCache = new Dictionary<string, DataRow[]>();
       
        List<string> searchHistory = new List<string>(10);
    
        private void LoadData()
        {
            try
            {
                sql_con = new SQLiteConnection
                    ("Data Source=Recipes.db;Version=3;New=False;Compress=True;");
                sql_con.Open();

                string query = "SELECT Title, Description, Time, Ingredients, Method FROM Recipes"; 
                sql_cmd = new SQLiteCommand(query, sql_con);
                DB = new SQLiteDataAdapter(sql_cmd);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GenerateDynamicUserControl()
        {
            Dictionary<string, Recipes> recipesDictionary = new Dictionary<string, Recipes>();

            flowLayoutPanel2.Controls.Clear();
             

            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    //creates an instance of Recipes stores it in the dictionary
                    Recipes recipe = new Recipes(                        
                        DT.Rows[i]["Title"].ToString(),
                        DT.Rows[i]["Description"].ToString(),
                        Convert.ToInt32(DT.Rows[i]["Time"]),
                        DT.Rows[i]["Ingredients"].ToString(),
                        DT.Rows[i]["Method"].ToString()
                      );

                    recipesDictionary.Add(recipe.Title, recipe);

                    //creates a UserControl1 instance
                    UserControl1 userControl = new UserControl1
                    {
                        Title = recipe.Title,
                        Time = recipe.Time

                    };
                    Image image = RetrieveImageFromDatabase(recipe.Title);
                    userControl.SetImage(image);

                    //adds UserControl1 to flowLayoutPanel
                    flowLayoutPanel2.Controls.Add(userControl);

                    
                    userControl.Click += new System.EventHandler(this.UserControl1_Click);
                }
            }
            this.Tag = recipesDictionary;
        }

         void UserControl1_Click(object sender, EventArgs e)
         {
            UserControl1 obj = (UserControl1)sender;
            string title = obj.Title;

            //display the image for the selected recipe
            DisplayImage(title);

            //retrieve the image from the database
            Image image = RetrieveImageFromDatabase(title);

            //set the image in UserControl1
            obj.SetImage(image);
         
            Dictionary<string, Recipes> recipesDictionary = (Dictionary<string, Recipes>)this.Tag;

            if (recipesDictionary.TryGetValue(title, out Recipes selectedRecipe))
            {
                //display the details
                lblTitle.Text = selectedRecipe.Title;
                lblDescription.Text = selectedRecipe.Description;
                lblIngredients.Text = selectedRecipe.Ingredients;
                lblMethod.Text = selectedRecipe.Method;


                showpanel();
            }
         }
        private void PerformSearch()
        {
            //search query from textbox
            string searchQuery = txtSearchBar.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                //add the search query to the search history
                AddToSearchHistory(searchQuery);

                    //check if search has been chached
                if (searchCache.ContainsKey(searchQuery))
                {
                    UpdateUIWithSearchResults(searchCache[searchQuery]);
                }
                else
                {
                    //perform the search
                    DataRow[] searchResults = DT.Select($"Title LIKE '%{searchQuery}%' OR Description LIKE '%{searchQuery}%'");
                    //update the cache
                    searchCache[searchQuery] = searchResults;
                    //display the results
                    UpdateUIWithSearchResults(searchResults);
                }
            }
        }
        private void UpdateUIWithSearchResults(DataRow[] searchResults)
        {
            //clear existing controls in flowLayoutPanel2
            flowLayoutPanel2.Controls.Clear();

            //display search results in UserControl1 instances
            foreach (DataRow row in searchResults)
            {
                //create an instance of Recipes
                Recipes recipe = new Recipes(
                   
                    row["Title"].ToString(),
                    row["Description"].ToString(),
                    Convert.ToInt32(row["Time"]),
                    row["Ingredients"].ToString(),
                    row["Method"].ToString()
                );
                               
                UserControl1 userControl = new UserControl1
                {
                    Title = recipe.Title,
                    Time = recipe.Time,
                    
                };
                Image image = RetrieveImageFromDatabase(recipe.Title);
                userControl.SetImage(image);

                //add the UserControl1 to the flowLayoutPanel
                flowLayoutPanel2.Controls.Add(userControl);

                userControl.Click += UserControl1_Click;
            }
        }
        private void AddToSearchHistory(string searchQuery)
        {
            //add the search to the search history
            searchHistory.Add(searchQuery);
            
            UpdateSearchHistoryUI();
        }

        private void UpdateSearchHistoryUI()
        {
            //clear existing items
            lbxSearchHistory.Items.Clear();  

            foreach (var query in searchHistory)
            {
                lbxSearchHistory.Items.Add(query);
            }
        }
        private void DisplayImage(string title)
        {
            try
            {
                //open the connection
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Recipes.db;Version=3;New=False;Compress=True;"))
                {
                    conn.Open();

                    //retrieve the image bytes from the database
                    string query = "SELECT Image FROM Recipes WHERE Title = @Title";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        byte[] imageBytes = (byte[])cmd.ExecuteScalar();

                        //convert the bytes to an Image object
                        Image image;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            image = Image.FromStream(ms);
                        }

                        //display the image in pictureBox1
                        pictureBox1.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Image RetrieveImageFromDatabase(string title)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Recipes.db;Version=3;New=False;Compress=True;"))
                {
                    conn.Open();

                    string query = "SELECT Image FROM Recipes WHERE Title = @Title";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        byte[] imageBytes = (byte[])cmd.ExecuteScalar();

                        //convert the bytes to an Image object
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void showpanel()
        {
            panel1.Visible = true;
        }
        private void hidepanel()
        {
            panel1.Visible = false;
        }

        private void btnPanelClose_Click(object sender, EventArgs e)
        {
            hidepanel();
        }

        private void lblRecipes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();   
            f2.Show();
        }
        private void lblRecipes_MouseEnter(object sender, EventArgs e)
        {
            lblRecipes.ForeColor = Color.FromArgb(17, 29, 242);
        }

        private void lblRecipes_MouseLeave(object sender, EventArgs e)
        {
            lblRecipes.ForeColor = Color.FromArgb(0, 0, 0);
        }
        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.FromArgb(17, 29, 242);
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnSearchRecipe_Click(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "")
                GenerateDynamicUserControl();
            PerformSearch();
            lbxSearchHistory.Hide();
            txtSearchBar.Clear();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            lbxSearchHistory.Show();
        }

        private void lbxSearchHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSearchHistory.SelectedItem != null)
            {
                string selectedQuery = lbxSearchHistory.SelectedItem.ToString();
                txtSearchBar.Text = selectedQuery;
                PerformSearch();
                lbxSearchHistory.Hide();
            }
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            lbxSearchHistory.Show();
        }
    }

}