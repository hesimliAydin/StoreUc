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
    public partial class ProductUC : UserControl
    {
        public Image Image
        {
            get
            {
                return productPictureBox.Image;
            }
            set
            {
                productPictureBox.Image = value;
            }
        }
        public string Name
        {
            get
            {
                return nameLbl.Text;
            }
            set
            {
                nameLbl.Text = value;
            }
        }

        public double Price
        {
            get
            {
                return double.Parse(priceLbl.Text);
            }
            set
            {
                priceLbl.Text = value.ToString();
            }
        }
        public EventHandler<EventArgs> MyProductChangeEvent { get; set; }
        public ProductUC()
        {
            InitializeComponent();
            MyProductChangeEvent = new EventHandler<EventArgs>(ProductChange);
        }
        private void ProductChange(object sender, EventArgs e)
        {
            Name = (sender as Label).Text;
        }
        private void ProductUC_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor=Color.White;
            nameLbl.ForeColor = Color.SpringGreen;
            priceLbl.ForeColor = Color.SpringGreen;
            label1.ForeColor = Color.SpringGreen;

        }

        private void ProductUC_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SpringGreen;
            nameLbl.ForeColor = Color.White;
            priceLbl.ForeColor = Color.White;
            label1.ForeColor = Color.White;
        }

        
    }
}
