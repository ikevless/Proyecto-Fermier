
namespace SG
{
    partial class Animales
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dtgv_animales = new Guna.UI.WinForms.GunaDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgv_animales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtgv_animales
            // 
            this.Dtgv_animales.AllowUserToAddRows = false;
            this.Dtgv_animales.AllowUserToDeleteRows = false;
            this.Dtgv_animales.AllowUserToResizeColumns = false;
            this.Dtgv_animales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Dtgv_animales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtgv_animales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgv_animales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dtgv_animales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtgv_animales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtgv_animales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgv_animales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgv_animales.ColumnHeadersHeight = 24;
            this.Dtgv_animales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgv_animales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Animal,
            this.Raza,
            this.Edad,
            this.Color,
            this.Detalles,
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgv_animales.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dtgv_animales.EnableHeadersVisualStyles = false;
            this.Dtgv_animales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Dtgv_animales.Location = new System.Drawing.Point(14, 132);
            this.Dtgv_animales.Margin = new System.Windows.Forms.Padding(2);
            this.Dtgv_animales.Name = "Dtgv_animales";
            this.Dtgv_animales.ReadOnly = true;
            this.Dtgv_animales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtgv_animales.RowHeadersVisible = false;
            this.Dtgv_animales.RowHeadersWidth = 51;
            this.Dtgv_animales.RowTemplate.Height = 24;
            this.Dtgv_animales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dtgv_animales.Size = new System.Drawing.Size(526, 219);
            this.Dtgv_animales.TabIndex = 3;
            this.Dtgv_animales.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.Dtgv_animales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Dtgv_animales.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dtgv_animales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dtgv_animales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dtgv_animales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dtgv_animales.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.Dtgv_animales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Dtgv_animales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Dtgv_animales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtgv_animales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Dtgv_animales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dtgv_animales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgv_animales.ThemeStyle.HeaderStyle.Height = 24;
            this.Dtgv_animales.ThemeStyle.ReadOnly = true;
            this.Dtgv_animales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Dtgv_animales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtgv_animales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Dtgv_animales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Dtgv_animales.ThemeStyle.RowsStyle.Height = 24;
            this.Dtgv_animales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.Dtgv_animales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Dtgv_animales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Animal
            // 
            this.Animal.DataPropertyName = "Animal";
            this.Animal.HeaderText = "Animal";
            this.Animal.MinimumWidth = 6;
            this.Animal.Name = "Animal";
            this.Animal.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.DataPropertyName = "Raza";
            this.Raza.HeaderText = "Raza";
            this.Raza.MinimumWidth = 6;
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Image = ((System.Drawing.Image)(resources.GetObject("Detalles.Image")));
            this.Detalles.MinimumWidth = 6;
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "null";
            this.Editar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 48;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Width = 61;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(116, 67);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(83, 25);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Corral 1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Detalles";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 66;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "null";
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn3.HeaderText = "Eliminar";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox1.Image")));
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(14, 22);
            this.gunaTransfarantPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(90, 98);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 5;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(334, 98);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(195, 28);
            this.bunifuTextbox1.TabIndex = 4;
            this.bunifuTextbox1.text = "";
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::SG.Properties.Resources.edit_1;
            this.buttonSpecAny1.UniqueName = "FF54F2A57A30401B00861532EB5CAA12";
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::SG.Properties.Resources.edit_1;
            this.buttonSpecAny2.UniqueName = "447812C2DF434994DA839FDCA2B84528";
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.Dtgv_animales);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Animales";
            this.Size = new System.Drawing.Size(571, 404);
            this.Load += new System.EventHandler(this.Animales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgv_animales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaDataGridView Dtgv_animales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewImageColumn Detalles;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
