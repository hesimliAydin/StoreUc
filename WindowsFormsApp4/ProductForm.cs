using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ProductForm : Form
    {
        public EventHandler<EventArgs> MyEvent { get; set; }
        private Product _product;
        public ProductForm(Product product)
        {
            InitializeComponent();
            _product = product;

            label1.Text = _product.Name+"  "+_product.Price.ToString()+" $";
            guna2PictureBox1.Image = _product.Image;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "New Data";
            MyEvent.Invoke(sender, e);
        }
    }
}
