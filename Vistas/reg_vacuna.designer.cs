namespace SG
{
    partial class reg_vacuna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_vacuna));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.txb_nom = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txb_obs = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lbl_obs = new Guna.UI.WinForms.GunaLabel();
            this.btn_guardar = new Guna.UI.WinForms.GunaGradientButton();
            this.txb_aplicador = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dat_reg = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_parto = new Guna.UI.WinForms.GunaLabel();
            this.dat_apli = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_asistentes = new Guna.UI.WinForms.GunaLabel();
            this.txb_vac = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_crias = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            this.btn_volver = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_reg = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl_ganado = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.idrv_cbx = new Guna.UI.WinForms.GunaComboBox();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_ganado)).BeginInit();
            this.pnl_ganado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.idrv_cbx);
            this.gunaGradient2Panel1.Controls.Add(this.txb_nom);
            this.gunaGradient2Panel1.Controls.Add(this.gunaGradientButton1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Controls.Add(this.txb_obs);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_obs);
            this.gunaGradient2Panel1.Controls.Add(this.btn_guardar);
            this.gunaGradient2Panel1.Controls.Add(this.txb_aplicador);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel1.Controls.Add(this.dat_reg);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_parto);
            this.gunaGradient2Panel1.Controls.Add(this.dat_apli);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_asistentes);
            this.gunaGradient2Panel1.Controls.Add(this.txb_vac);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_crias);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_id);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(69)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(230)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(16, 143);
            this.gunaGradient2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 10;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1077, 679);
            this.gunaGradient2Panel1.TabIndex = 53;
            this.gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel1_Paint);
            // 
            // txb_nom
            // 
            this.txb_nom.Animated = true;
            this.txb_nom.BackColor = System.Drawing.Color.White;
            this.txb_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_nom.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.txb_nom.Font = new System.Drawing.Font("Altone Trial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nom.LineColor = System.Drawing.Color.Gainsboro;
            this.txb_nom.Location = new System.Drawing.Point(363, 249);
            this.txb_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.PasswordChar = '\0';
            this.txb_nom.Size = new System.Drawing.Size(293, 42);
            this.txb_nom.TabIndex = 5;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Animated = true;
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(128)))), ((int)(((byte)(112)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(79)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.BorderSize = 1;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Altone Trial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(843, 569);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(192)))), ((int)(((byte)(168)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 5;
            this.gunaGradientButton1.Size = new System.Drawing.Size(180, 52);
            this.gunaGradientButton1.TabIndex = 9;
            this.gunaGradientButton1.Text = "Cancelar";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Altone Trial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.gunaLabel1.Location = new System.Drawing.Point(68, 249);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(273, 32);
            this.gunaLabel1.TabIndex = 44;
            this.gunaLabel1.Text = "Nombre de vacuna:";
            // 
            // txb_obs
            // 
            this.txb_obs.Location = new System.Drawing.Point(73, 496);
            this.txb_obs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_obs.Name = "txb_obs";
            this.txb_obs.Size = new System.Drawing.Size(551, 153);
            this.txb_obs.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_obs.StateNormal.Border.Rounding = 5;
            this.txb_obs.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_obs.TabIndex = 7;
            this.txb_obs.Text = "";
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Font = new System.Drawing.Font("Altone Trial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.lbl_obs.Location = new System.Drawing.Point(68, 438);
            this.lbl_obs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(221, 32);
            this.lbl_obs.TabIndex = 42;
            this.lbl_obs.Text = "Observaciones:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Animated = true;
            this.btn_guardar.AnimationHoverSpeed = 0.07F;
            this.btn_guardar.AnimationSpeed = 0.03F;
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(128)))), ((int)(((byte)(112)))));
            this.btn_guardar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(79)))));
            this.btn_guardar.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.BorderSize = 1;
            this.btn_guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_guardar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_guardar.Font = new System.Drawing.Font("Altone Trial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_guardar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_guardar.Location = new System.Drawing.Point(843, 438);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(192)))), ((int)(((byte)(168)))));
            this.btn_guardar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.btn_guardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_guardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_guardar.OnHoverImage = null;
            this.btn_guardar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_guardar.Radius = 5;
            this.btn_guardar.Size = new System.Drawing.Size(180, 52);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // txb_aplicador
            // 
            this.txb_aplicador.Animated = true;
            this.txb_aplicador.BackColor = System.Drawing.Color.White;
            this.txb_aplicador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_aplicador.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.txb_aplicador.Font = new System.Drawing.Font("Altone Trial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_aplicador.LineColor = System.Drawing.Color.Gainsboro;
            this.txb_aplicador.Location = new System.Drawing.Point(363, 341);
            this.txb_aplicador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_aplicador.Name = "txb_aplicador";
            this.txb_aplicador.PasswordChar = '\0';
            this.txb_aplicador.Size = new System.Drawing.Size(293, 42);
            this.txb_aplicador.TabIndex = 6;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Altone Trial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.gunaLabel3.Location = new System.Drawing.Point(781, 258);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(254, 32);
            this.gunaLabel3.TabIndex = 40;
            this.gunaLabel3.Text = "Fecha de registro:";
            this.gunaLabel3.Click += new System.EventHandler(this.GunaLabel3_Click);
            // 
            // dat_reg
            // 
            this.dat_reg.BaseColor = System.Drawing.Color.White;
            this.dat_reg.BorderColor = System.Drawing.Color.Silver;
            this.dat_reg.CustomFormat = null;
            this.dat_reg.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dat_reg.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_reg.Font = new System.Drawing.Font("Altone Trial", 12F);
            this.dat_reg.ForeColor = System.Drawing.Color.Black;
            this.dat_reg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_reg.Location = new System.Drawing.Point(807, 290);
            this.dat_reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dat_reg.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dat_reg.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dat_reg.Name = "dat_reg";
            this.dat_reg.OnHoverBaseColor = System.Drawing.Color.White;
            this.dat_reg.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_reg.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_reg.OnPressedColor = System.Drawing.Color.Black;
            this.dat_reg.Size = new System.Drawing.Size(185, 32);
            this.dat_reg.TabIndex = 4;
            this.dat_reg.Text = "14/10/2021";
            this.dat_reg.Value = new System.DateTime(2021, 10, 14, 1, 33, 14, 379);
            // 
            // lbl_parto
            // 
            this.lbl_parto.AutoSize = true;
            this.lbl_parto.Font = new System.Drawing.Font("Altone Trial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.lbl_parto.Location = new System.Drawing.Point(763, 128);
            this.lbl_parto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_parto.Name = "lbl_parto";
            this.lbl_parto.Size = new System.Drawing.Size(287, 32);
            this.lbl_parto.TabIndex = 39;
            this.lbl_parto.Text = "Fecha de aplicacion:";
            this.lbl_parto.Click += new System.EventHandler(this.lbl_parto_Click);
            // 
            // dat_apli
            // 
            this.dat_apli.BaseColor = System.Drawing.Color.White;
            this.dat_apli.BorderColor = System.Drawing.Color.Silver;
            this.dat_apli.CustomFormat = null;
            this.dat_apli.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dat_apli.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_apli.Font = new System.Drawing.Font("Altone Trial", 12F);
            this.dat_apli.ForeColor = System.Drawing.Color.Black;
            this.dat_apli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_apli.Location = new System.Drawing.Point(807, 162);
            this.dat_apli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dat_apli.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dat_apli.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dat_apli.Name = "dat_apli";
            this.dat_apli.OnHoverBaseColor = System.Drawing.Color.White;
            this.dat_apli.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_apli.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_apli.OnPressedColor = System.Drawing.Color.Black;
            this.dat_apli.Size = new System.Drawing.Size(185, 34);
            this.dat_apli.TabIndex = 2;
            this.dat_apli.Text = "14/10/2021";
            this.dat_apli.Value = new System.DateTime(2021, 10, 14, 1, 33, 14, 379);
            // 
            // lbl_asistentes
            // 
            this.lbl_asistentes.AutoSize = true;
            this.lbl_asistentes.Font = new System.Drawing.Font("Altone Trial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asistentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.lbl_asistentes.Location = new System.Drawing.Point(68, 351);
            this.lbl_asistentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_asistentes.Name = "lbl_asistentes";
            this.lbl_asistentes.Size = new System.Drawing.Size(149, 32);
            this.lbl_asistentes.TabIndex = 36;
            this.lbl_asistentes.Text = "Aplicador:";
            // 
            // txb_vac
            // 
            this.txb_vac.Animated = true;
            this.txb_vac.BackColor = System.Drawing.Color.White;
            this.txb_vac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_vac.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.txb_vac.Font = new System.Drawing.Font("Altone Trial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_vac.LineColor = System.Drawing.Color.Gainsboro;
            this.txb_vac.Location = new System.Drawing.Point(363, 156);
            this.txb_vac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_vac.Name = "txb_vac";
            this.txb_vac.PasswordChar = '\0';
            this.txb_vac.Size = new System.Drawing.Size(293, 42);
            this.txb_vac.TabIndex = 3;
            // 
            // lbl_crias
            // 
            this.lbl_crias.AutoSize = true;
            this.lbl_crias.Font = new System.Drawing.Font("Altone Trial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.lbl_crias.Location = new System.Drawing.Point(71, 156);
            this.lbl_crias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_crias.Name = "lbl_crias";
            this.lbl_crias.Size = new System.Drawing.Size(146, 32);
            this.lbl_crias.TabIndex = 27;
            this.lbl_crias.Text = "Id vacuna";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Altone Trial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.lbl_id.Location = new System.Drawing.Point(67, 63);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(95, 32);
            this.lbl_id.TabIndex = 23;
            this.lbl_id.Text = "Arete:";
            // 
            // btn_volver
            // 
            this.btn_volver.Animated = true;
            this.btn_volver.AnimationHoverSpeed = 0.07F;
            this.btn_volver.AnimationSpeed = 0.03F;
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(149)))), ((int)(((byte)(133)))));
            this.btn_volver.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(54)))), ((int)(((byte)(48)))));
            this.btn_volver.BorderColor = System.Drawing.Color.Black;
            this.btn_volver.BorderSize = 1;
            this.btn_volver.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_volver.FocusedColor = System.Drawing.Color.Empty;
            this.btn_volver.Font = new System.Drawing.Font("Altone Trial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_volver.Location = new System.Drawing.Point(897, 830);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.btn_volver.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_volver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_volver.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_volver.OnHoverImage = null;
            this.btn_volver.OnPressedColor = System.Drawing.Color.Black;
            this.btn_volver.Radius = 5;
            this.btn_volver.Size = new System.Drawing.Size(184, 64);
            this.btn_volver.TabIndex = 49;
            this.btn_volver.Text = "Volver";
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.gunaSeparator1.LineColor = System.Drawing.Color.Black;
            this.gunaSeparator1.Location = new System.Drawing.Point(301, 121);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(539, 22);
            this.gunaSeparator1.TabIndex = 52;
            // 
            // lbl_reg
            // 
            this.lbl_reg.Location = new System.Drawing.Point(233, 70);
            this.lbl_reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_reg.Name = "lbl_reg";
            this.lbl_reg.Size = new System.Drawing.Size(592, 61);
            this.lbl_reg.StateCommon.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lbl_reg.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(23)))));
            this.lbl_reg.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(23)))));
            this.lbl_reg.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.lbl_reg.StateCommon.ShortText.ColorAngle = 4F;
            this.lbl_reg.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassTrackingSimple;
            this.lbl_reg.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_reg.StateDisabled.LongText.Font = new System.Drawing.Font("Couture", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg.StateNormal.LongText.Font = new System.Drawing.Font("Couture", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_reg.StateNormal.ShortText.Font = new System.Drawing.Font("LEMON MILK Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg.TabIndex = 51;
            this.lbl_reg.Values.Text = "Registro de Vacunación";
            // 
            // pnl_ganado
            // 
            this.pnl_ganado.Controls.Add(this.gunaPictureBox1);
            this.pnl_ganado.Controls.Add(this.kryptonBorderEdge1);
            this.pnl_ganado.Location = new System.Drawing.Point(-88, -78);
            this.pnl_ganado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_ganado.Name = "pnl_ganado";
            this.pnl_ganado.Size = new System.Drawing.Size(1285, 140);
            this.pnl_ganado.TabIndex = 50;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(84, -82);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1124, 390);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(321, 114);
            this.kryptonBorderEdge1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(67, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // idrv_cbx
            // 
            this.idrv_cbx.BackColor = System.Drawing.Color.Transparent;
            this.idrv_cbx.BaseColor = System.Drawing.Color.White;
            this.idrv_cbx.BorderColor = System.Drawing.Color.Silver;
            this.idrv_cbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idrv_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idrv_cbx.FocusedColor = System.Drawing.Color.Empty;
            this.idrv_cbx.Font = new System.Drawing.Font("Altone Trial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idrv_cbx.ForeColor = System.Drawing.Color.Black;
            this.idrv_cbx.FormattingEnabled = true;
            this.idrv_cbx.Location = new System.Drawing.Point(363, 63);
            this.idrv_cbx.Name = "idrv_cbx";
            this.idrv_cbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.idrv_cbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.idrv_cbx.Size = new System.Drawing.Size(293, 32);
            this.idrv_cbx.TabIndex = 45;
            // 
            // reg_vacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(188)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1121, 908);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.lbl_reg);
            this.Controls.Add(this.pnl_ganado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "reg_vacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reg_vacuna";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_ganado)).EndInit();
            this.pnl_ganado.ResumeLayout(false);
            this.pnl_ganado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLineTextBox txb_nom;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txb_obs;
        private Guna.UI.WinForms.GunaLabel lbl_obs;
        private Guna.UI.WinForms.GunaLineTextBox txb_aplicador;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDateTimePicker dat_reg;
        private Guna.UI.WinForms.GunaLabel lbl_parto;
        private Guna.UI.WinForms.GunaDateTimePicker dat_apli;
        private Guna.UI.WinForms.GunaLabel lbl_asistentes;
        private Guna.UI.WinForms.GunaLineTextBox txb_vac;
        private Guna.UI.WinForms.GunaLabel lbl_crias;
        private Guna.UI.WinForms.GunaLabel lbl_id;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton btn_volver;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaGradientButton btn_guardar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_reg;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnl_ganado;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Guna.UI.WinForms.GunaComboBox idrv_cbx;
    }
}