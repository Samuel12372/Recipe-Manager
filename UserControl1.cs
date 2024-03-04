using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRecipeManager2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private string _title;
        private int _time;
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        public int Time
        {
            get { return _time; }
            set { _time = value; lblTime.Text = Convert.ToString(value); }
        }
        public void SetImage(Image image)
        {
            pictureBox1.Image = image;
        }

        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

       
    }
}
