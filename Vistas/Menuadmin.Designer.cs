namespace SG
{
    partial class Menuadmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuadmin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel_menu = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_regsal = new Guna.UI.WinForms.GunaButton();
            this.btn_regan = new Guna.UI.WinForms.GunaButton();
            this.btn_establo = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.infoanimal = new SG.infoanimal();
            this.establo2 = new SG.establo();
            this.logo1 = new SG.Logo();
            this.animales1 = new SG.Animales();
            this.establo1 = new SG.establo();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(267, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(842, 41);
            this.gunaPanel2.TabIndex = 1;
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.BackgroundImage")));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(798, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(44, 39);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.GunaPictureBox1_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.Controls.Add(this.infoanimal);
            this.panel_menu.Controls.Add(this.establo2);
            this.panel_menu.Controls.Add(this.logo1);
            this.panel_menu.Controls.Add(this.animales1);
            this.panel_menu.Controls.Add(this.establo1);
            this.panel_menu.Location = new System.Drawing.Point(267, 39);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(842, 526);
            this.panel_menu.TabIndex = 2;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel3_Paint);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(53, 167);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(145, 28);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Nombre admin";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.gunaPanel1.Controls.Add(this.btn_regsal);
            this.gunaPanel1.Controls.Add(this.btn_regan);
            this.gunaPanel1.Controls.Add(this.btn_establo);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaPanel4);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(267, 565);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // btn_regsal
            // 
            this.btn_regsal.Animated = true;
            this.btn_regsal.AnimationHoverSpeed = 0.07F;
            this.btn_regsal.AnimationSpeed = 0.03F;
            this.btn_regsal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_regsal.BorderColor = System.Drawing.Color.Black;
            this.btn_regsal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_regsal.FocusedColor = System.Drawing.Color.Empty;
            this.btn_regsal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regsal.ForeColor = System.Drawing.Color.White;
            this.btn_regsal.Image = ((System.Drawing.Image)(resources.GetObject("btn_regsal.Image")));
            this.btn_regsal.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_regsal.Location = new System.Drawing.Point(7, 347);
            this.btn_regsal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regsal.Name = "btn_regsal";
            this.btn_regsal.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_regsal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_regsal.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_regsal.OnHoverImage = null;
            this.btn_regsal.OnPressedColor = System.Drawing.Color.Black;
            this.btn_regsal.Size = new System.Drawing.Size(256, 52);
            this.btn_regsal.TabIndex = 9;
            this.btn_regsal.Text = "Registrar salida";
            this.btn_regsal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_regsal.Click += new System.EventHandler(this.Btn_regsal_Click);
            // 
            // btn_regan
            // 
            this.btn_regan.Animated = true;
            this.btn_regan.AnimationHoverSpeed = 0.07F;
            this.btn_regan.AnimationSpeed = 0.03F;
            this.btn_regan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_regan.BorderColor = System.Drawing.Color.Black;
            this.btn_regan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_regan.FocusedColor = System.Drawing.Color.Empty;
            this.btn_regan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regan.ForeColor = System.Drawing.Color.White;
            this.btn_regan.Image = ((System.Drawing.Image)(resources.GetObject("btn_regan.Image")));
            this.btn_regan.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_regan.Location = new System.Drawing.Point(7, 288);
            this.btn_regan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regan.Name = "btn_regan";
            this.btn_regan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_regan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_regan.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_regan.OnHoverImage = null;
            this.btn_regan.OnPressedColor = System.Drawing.Color.Black;
            this.btn_regan.Size = new System.Drawing.Size(256, 52);
            this.btn_regan.TabIndex = 8;
            this.btn_regan.Text = "Registrar ganado";
            this.btn_regan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_regan.Click += new System.EventHandler(this.Btn_regan_Click_1);
            // 
            // btn_establo
            // 
            this.btn_establo.Animated = true;
            this.btn_establo.AnimationHoverSpeed = 0.07F;
            this.btn_establo.AnimationSpeed = 0.03F;
            this.btn_establo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_establo.BorderColor = System.Drawing.Color.Black;
            this.btn_establo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_establo.FocusedColor = System.Drawing.Color.Empty;
            this.btn_establo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_establo.ForeColor = System.Drawing.Color.White;
            this.btn_establo.Image = ((System.Drawing.Image)(resources.GetObject("btn_establo.Image")));
            this.btn_establo.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_establo.Location = new System.Drawing.Point(7, 229);
            this.btn_establo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_establo.Name = "btn_establo";
            this.btn_establo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_establo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_establo.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_establo.OnHoverImage = null;
            this.btn_establo.OnPressedColor = System.Drawing.Color.Black;
            this.btn_establo.Size = new System.Drawing.Size(256, 52);
            this.btn_establo.TabIndex = 3;
            this.btn_establo.Text = "Corrales";
            this.btn_establo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_establo.Click += new System.EventHandler(this.Btn_establo_Click);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel4.BackgroundImage")));
            this.gunaPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaPanel4.Location = new System.Drawing.Point(29, 15);
            this.gunaPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(197, 149);
            this.gunaPanel4.TabIndex = 0;
            this.gunaPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel4_Paint);
            // 
            // infoanimal
            // 
            this.infoanimal.BackColor = System.Drawing.SystemColors.Control;
            this.infoanimal.Location = new System.Drawing.Point(-3, 0);
            this.infoanimal.Margin = new System.Windows.Forms.Padding(4);
            this.infoanimal.Name = "infoanimal";
            this.infoanimal.Size = new System.Drawing.Size(842, 525);
            this.infoanimal.TabIndex = 5;
            // 
            // establo2
            // 
            this.establo2.Location = new System.Drawing.Point(0, 4);
            this.establo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.establo2.Name = "establo2";
            this.establo2.Size = new System.Drawing.Size(838, 526);
            this.establo2.TabIndex = 4;
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.SystemColors.Control;
            this.logo1.Location = new System.Drawing.Point(0, -8);
            this.logo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(842, 534);
            this.logo1.TabIndex = 2;
            this.logo1.Load += new System.EventHandler(this.logo1_Load);
            // 
            // animales1
            // 
            this.animales1.BackColor = System.Drawing.SystemColors.Control;
            this.animales1.Location = new System.Drawing.Point(0, 2);
            this.animales1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animales1.Name = "animales1";
            this.animales1.Size = new System.Drawing.Size(839, 523);
            this.animales1.TabIndex = 1;
            this.animales1.Load += new System.EventHandler(this.animales1_Load);
            // 
            // establo1
            // 
            this.establo1.BackColor = System.Drawing.SystemColors.Control;
            this.establo1.Location = new System.Drawing.Point(0, 0);
            this.establo1.Margin = new System.Windows.Forms.Padding(5);
            this.establo1.Name = "establo1";
            this.establo1.Size = new System.Drawing.Size(842, 521);
            this.establo1.TabIndex = 0;
            this.establo1.Load += new System.EventHandler(this.establo1_Load);
            // 
            // Menuadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1109, 565);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menuadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menuadmin_Load);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel panel_menu;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public establo establo1;
        public Animales animales1;
        public Logo logo1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_establo;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaButton btn_regan;
        private Guna.UI.WinForms.GunaButton btn_regsal;
        public establo establo2;
        public infoanimal infoanimal;
    }
}

