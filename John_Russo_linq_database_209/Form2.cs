using System;
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
    public partial class TheMatrix : Form
    {
        private productData db;

        public TheMatrix()
        {

            InitializeComponent();
            db = new productData();
            LoadProducts();
        }

        private void LoadProducts()
        {
            // Load products sorted by price in ascending order
            var results = from Product in db.Products
                          orderby Product.Price ascending
                          select Product;
            MatrixDataGrid.DataSource = results.ToList();
        }

        private void priceSearchbutton_Click(object sender, EventArgs e)
        {
            decimal minPrice, maxPrice;
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.agent_smith);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while playing the sound: " + ex.Message);
            }

            if (decimal.TryParse(MinPriceTextBox.Text, out minPrice) && decimal.TryParse(MaxPriceTextBox.Text, out maxPrice))
            {
                try
                {
                    var results = from Product in db.Products
                                  where Product.Price >= minPrice && Product.Price <= maxPrice
                                  orderby Product.Price ascending
                                  select Product;

                    MatrixDataGrid.DataSource = results.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving and displaying products: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid minimum and maximum prices.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
