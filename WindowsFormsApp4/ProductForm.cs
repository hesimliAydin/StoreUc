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
        public EventHandler<EventArgs> MyDataChangedEvent { get; set; }
        private Product _product;
        public ProductForm(Product product, EventHandler<EventArgs> myDataChangedEvent)
        {
            InitializeComponent();
            _product = product;
            MyDataChangedEvent = myDataChangedEvent;

            //label1.Text = _product.Name+"  "+_product.Price.ToString()+" $";
            guna2PictureBox1.Image = _product.Image;
            nameTxtb.Text = _product.Name;
            priceTxtb.Text = product.Price.ToString();

        }


        public string NameProduct
        {
            get { return nameTxtb.Text; }
            set { nameTxtb.Text=value;  }
        }

        public string PriceProduct
        {
            get { return priceTxtb.Text; }
            set { priceTxtb.Text=value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // label1.Text = "New Data";
            MyEvent.Invoke(sender, e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            _product.Name = NameProduct;
            _product.Price = double.Parse(PriceProduct);
            this.DialogResult = DialogResult.OK;
        }

        private void nameTxtb_TextChanged(object sender, EventArgs e)
        {
            MyDataChangedEvent.Invoke(sender, e);
        }

    }
}
