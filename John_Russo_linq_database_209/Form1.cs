using System;// John Russo chapter 14 cpt 206   comments are about pointless if you name your varibles correctly
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace John_Russo_linq_database_209
{
    public partial class Form1 : Form
    {
        private productData db; // Class-level variable for the database 

        public Form1()
        {
            InitializeComponent();
            db = new productData(); // Initialize the database  
            this.searchProductDesc.Click += new EventHandler(this.searchProductDesc_Click);
            this.searchMoreUnitsButton.Click += new EventHandler(this.searchMoreUnits_Click); // button love
            this.searchLessUnitsButton.Click += new EventHandler(this.searchLessUnits_Click); // more sexy button love

           // this.newFormButton.Click += new EventHandler(this.newFormButton_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data into the DataGridView upon form load
            var results = from Product in db.Products
                          orderby Product.Units_On_Hand ascending
                          select Product;
            productDataGridView.DataSource = results.ToList();
        }

        private void searchProNo_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(John_Russo_linq_database_209.Properties.Resources.mtrx_bodymind);

                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while playing the sound: " + ex.Message);
            }
            // Search based on the product number and update the DataGridView
            var productNo = textBoxProductNo.Text;
            var results = from Product in db.Products
                          where Product.Product_Number == productNo
                          select Product;
            productDataGridView.DataSource = results.ToList();
        }

        
        private void searchProductDesc_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.mtrx_desert);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while playing the sound: " + ex.Message);
            }
            var descriptionText = textBoxProductDesc.Text; 
            var results = from Product in db.Products
                          where Product.Description.Contains(descriptionText)
                          select Product;
            productDataGridView.DataSource = results.ToList();
        }
        private void searchMoreUnits_Click(object sender, EventArgs e)
        {

            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.mtrx_hitme);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while playing the sound: " + ex.Message);
            }
            int units;
            if (int.TryParse(textBoxMoreUnits.Text, out units))
            {
                var results = from Product in db.Products
                              where Product.Units_On_Hand > units
                              orderby Product.Units_On_Hand ascending
                              select Product;
                productDataGridView.DataSource = results.ToList();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
        private void searchLessUnits_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.oracle);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while playing the sound: " + ex.Message);
            }
            // Search for products with less units on hand than specified
            int units;
            if (int.TryParse(textBoxLessUnits.Text, out units))
            {
                var results = from Product in db.Products
                              where Product.Units_On_Hand < units
                              orderby Product.Units_On_Hand ascending
                              select Product;
                productDataGridView.DataSource = results.ToList();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void newFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.matrix);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while playing the sound: " + ex.Message);
            }
            TheMatrix matrixForm = new TheMatrix(); 
            matrixForm.Show();
        }

        
    }
}