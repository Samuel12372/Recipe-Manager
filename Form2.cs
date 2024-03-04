using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodRecipeManager2
{
    public partial class Form2 : Form
    {
        public List<Recipes> recipes = new List<Recipes>();
        public Form2()
        { 
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            SQLiteConnection conn = new SQLiteConnection
                    ("Data Source=Recipes.db;Version=3;New=False;Compress=True;");
            conn.Open();

            string query = "Select * from Recipes";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }
        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection
                    ("Data Source=Recipes.db;Version=3;New=False;Compress=True;");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            txtTitle.Clear();
            txtDesc.Clear();
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxRecipeUpload.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dbquery = "Delete from Recipes where ID = '" + numericUpDown1.Value + "'";
            AmendDatabase(dbquery);
            LoadData();
            Refreshtxtboxes();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             //convert the image to byte array
             byte[] imageBytes = ImageToByteArray(pbxRecipeUpload.Image);
                      
            string dbquery = "Insert into Recipes(ID, Title, Description, Time, Image, Ingredients, Method) " +
                "values (@ID, @Title, @Description, @Time, @Image, @Ingredients, @Method)";

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Recipes.db;Version=3;New=False;Compress=True;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(dbquery, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@Time", numericUpDown2.Value);
                    cmd.Parameters.AddWithValue("@Image", imageBytes);
                    cmd.Parameters.AddWithValue("@Ingredients", txtIngredients.Text);
                    cmd.Parameters.AddWithValue("@Method", txtMethod.Text);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            LoadData();
            Refreshtxtboxes();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string dbquery = "Update Recipes set Description = @Description, Time = @Time, Image = @Image where ID = @ID";

            SQLiteConnection conn = new SQLiteConnection("Data Source=Recipes.db;Version=3;New=False;Compress=True;");
            
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(dbquery, conn);
             
            cmd.Parameters.AddWithValue("@ID", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
            cmd.Parameters.AddWithValue("@Time", numericUpDown2.Value);
              
            byte[] imageBytes = ImageToByteArray(pbxRecipeUpload.Image);
            cmd.Parameters.AddWithValue("@Image", imageBytes);

            cmd.ExecuteNonQuery();
             conn.Close();
        

            LoadData();
            Refreshtxtboxes();

        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1(); 
            f1.Show();
        }
        private byte[] ImageToByteArray(Image image)
        {
            //convert image to byte array
            MemoryStream ms = new MemoryStream();
      
            image.Save(ms, image.RawFormat);
            return ms.ToArray();            
        }
        private void Refreshtxtboxes()
        {
            numericUpDown1.ResetText();
            txtDesc.Clear();
            txtIngredients.Clear();
            txtMethod.Clear();
            txtTitle.Clear();
            numericUpDown2.ResetText();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dataGridView1.CurrentCell.RowIndex;

                string fileName = txtFileName.Text;
                if (!fileName.EndsWith(".bin"))
                {
                    fileName = txtFileName.Text + ".bin";
                }

                if (selectedRow >= 0)
                {
                    DataRow selectedDataRow = ((DataRowView)dataGridView1.Rows[selectedRow].DataBoundItem).Row;
                    Recipes selectedRecipe = new Recipes(
                        (string)selectedDataRow["Title"],
                        (string)selectedDataRow["Description"],
                        Convert.ToInt32(selectedDataRow["Time"]),
                        (string)selectedDataRow["Ingredients"],
                        (string)selectedDataRow["Method"]
                    );

                    //serialize object to a binary stream
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream stream = new FileStream(fileName, FileMode.Create);
                    
                    formatter.Serialize(stream, selectedRecipe);
                   
                    MessageBox.Show("Recipe saved to file successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a row to save.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void lblRecipes_MouseLeave(object sender, EventArgs e)
        {
            lblRecipes.ForeColor = Color.FromArgb(0, 0, 0);
        }
        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.FromArgb(17, 29, 242);
        }
        private void lblRecipes_MouseEnter(object sender, EventArgs e)
        {
            lblRecipes.ForeColor = Color.FromArgb(17, 29, 242);
        }
        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
    
}
