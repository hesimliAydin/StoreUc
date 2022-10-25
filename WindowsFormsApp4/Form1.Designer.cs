namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.productsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.productsLbl = new System.Windows.Forms.Label();
            this.homePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.homeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.productIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.homeIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.productsPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderThickness = 6;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.mainPanel);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1135, 649);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderThickness = 6;
            this.guna2Panel2.Controls.Add(this.productsPanel);
            this.guna2Panel2.Controls.Add(this.homePanel);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(268, 649);
            this.guna2Panel2.TabIndex = 0;
            // 
            // productsPanel
            // 
            this.productsPanel.BorderColor = System.Drawing.Color.White;
            this.productsPanel.BorderThickness = 4;
            this.productsPanel.Controls.Add(this.productsLbl);
            this.productsPanel.Controls.Add(this.productIcon);
            this.productsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsPanel.Location = new System.Drawing.Point(12, 279);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(242, 65);
            this.productsPanel.TabIndex = 3;
            this.productsPanel.Click += new System.EventHandler(this.productsPanel_Click);
            // 
            // productsLbl
            // 
            this.productsLbl.AutoSize = true;
            this.productsLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLbl.ForeColor = System.Drawing.Color.White;
            this.productsLbl.Location = new System.Drawing.Point(74, 12);
            this.productsLbl.Name = "productsLbl";
            this.productsLbl.Size = new System.Drawing.Size(142, 41);
            this.productsLbl.TabIndex = 2;
            this.productsLbl.Text = "Products";
            this.productsLbl.Click += new System.EventHandler(this.productsPanel_Click);
            // 
            // homePanel
            // 
            this.homePanel.BorderColor = System.Drawing.Color.White;
            this.homePanel.BorderThickness = 4;
            this.homePanel.Controls.Add(this.homeLbl);
            this.homePanel.Controls.Add(this.homeIcon);
            this.homePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePanel.Location = new System.Drawing.Point(12, 208);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(242, 65);
            this.homePanel.TabIndex = 1;
            this.homePanel.Click += new System.EventHandler(this.homeLbl_Click);
            this.homePanel.MouseEnter += new System.EventHandler(this.homePanel_MouseEnter);
            this.homePanel.MouseLeave += new System.EventHandler(this.homePanel_MouseLeave);
            // 
            // homeLbl
            // 
            this.homeLbl.AutoSize = true;
            this.homeLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLbl.ForeColor = System.Drawing.Color.White;
            this.homeLbl.Location = new System.Drawing.Point(74, 12);
            this.homeLbl.Name = "homeLbl";
            this.homeLbl.Size = new System.Drawing.Size(97, 41);
            this.homeLbl.TabIndex = 2;
            this.homeLbl.Text = "Home";
            this.homeLbl.Click += new System.EventHandler(this.homeLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store UI";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BorderColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderThickness = 6;
            this.mainPanel.Location = new System.Drawing.Point(301, 139);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(817, 483);
            this.mainPanel.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderThickness = 6;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1053, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(65, 65);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // productIcon
            // 
            this.productIcon.Image = global::WindowsFormsApp4.Properties.Resources.product;
            this.productIcon.ImageRotate = 0F;
            this.productIcon.Location = new System.Drawing.Point(12, 12);
            this.productIcon.Name = "productIcon";
            this.productIcon.Size = new System.Drawing.Size(40, 40);
            this.productIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productIcon.TabIndex = 0;
            this.productIcon.TabStop = false;
            this.productIcon.Click += new System.EventHandler(this.productsPanel_Click);
            // 
            // homeIcon
            // 
            this.homeIcon.Image = global::WindowsFormsApp4.Properties.Resources.homeIcon;
            this.homeIcon.ImageRotate = 0F;
            this.homeIcon.Location = new System.Drawing.Point(12, 12);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(40, 40);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 0;
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.homeLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 649);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel homePanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox homeIcon;
        private System.Windows.Forms.Label homeLbl;
        private Guna.UI2.WinForms.Guna2Panel productsPanel;
        private System.Windows.Forms.Label productsLbl;
        private Guna.UI2.WinForms.Guna2PictureBox productIcon;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
    }
}

