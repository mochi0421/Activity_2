using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("Muffler Stainless");
            wishList.Items.Add("Muffler Rusty");
            wishList.Items.Add("Muffler Standard");
            wishList.Items.Add("Muffler Open pipe");
            wishList.Items.Add("Muffler Orbr");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CountOutputBox.Text = Convert.ToString(wishList.Items.Count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Wishlist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SelectionOutputBox.Text = wishList.Text;
        }
    }
}
