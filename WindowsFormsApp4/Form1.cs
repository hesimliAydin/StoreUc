using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Products = new List<Product>
            {
                new Product
                {
                    Name="Asus Rog Strix",
                    Price=2100,
                    Image=Properties.Resources.asus
                },
                new Product
                {
                    Name="Iphone 14",
                    Price=4000,
                    Image=Properties.Resources.iphone
                },
                new Product
                {
                    Name="Zenbook Pro Slim",
                    Price=2100,
                    Image=Properties.Resources.zen
                },
                new Product
                {
                    Name="Samsung",
                    Price=1500,
                    Image=Properties.Resources.sammsung
                },
            };


            productsPanel.MouseEnter += homePanel_MouseEnter;
            productsPanel.MouseLeave += homePanel_MouseLeave;


            mainPanel.Controls.Add(homeUC);
        }
        public List<Product> Products { get; set; }
        HomeUC homeUC = new HomeUC();



        private void homePanel_MouseEnter(object sender, EventArgs e)
        {
            (sender as Guna2Panel).BorderColor = Color.SpringGreen;
        }

        private void homePanel_MouseLeave(object sender, EventArgs e)
        {
            (sender as Guna2Panel).BorderColor = Color.White;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void productsPanel_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            int x = 20;
            int y = 30;
            foreach (var p in Products)
            {
                var productUC = new ProductUC
                {
                    Name = p.Name,
                    Price = p.Price,
                    Image = p.Image
                };
                productUC.Location = new Point(x, y);
                y += 100;

                productUC.DoubleClick += ProductUC_DoubleClick;

                mainPanel.Controls.Add(productUC);
            }
        }
        ProductUC uc;
        ProductForm productForm;
        private void ProductUC_DoubleClick(object sender, EventArgs e)
        {
            uc = sender as ProductUC;
            var product = new Product
            {
                Name = uc.Name,
                Price = uc.Price,
                Image = uc.Image
            };

            productForm = new ProductForm(product, dataChanged);
            //productForm.MyDataChangedEvent = dataChanged;
            productForm.MyEvent = uc.MyProductChangeEvent;
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                uc.Name = productForm.NameProduct;
                uc.Price = double.Parse(productForm.PriceProduct);
            }


            // MessageBox.Show(uc.Name);
        }

        private void dataChanged(object sender, EventArgs e)
        {
            try
            {

                uc.Name = productForm.NameProduct;
                uc.Price = double.Parse(productForm.PriceProduct);
            }
            catch { }
        }

        private void homeLbl_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(homeUC);
        }
    }
}
