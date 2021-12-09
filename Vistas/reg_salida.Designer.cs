namespace SG
{
    partial class reg_salida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_salida));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.rtb_des = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lbl_des = new Guna.UI.WinForms.GunaLabel();
            this.txb_peso = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dat_sal = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_asistentes = new Guna.UI.WinForms.GunaLabel();
            this.cbx_id = new Guna.UI.WinForms.GunaComboBox();
            this.txb_crias = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_crias = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            this.cancelar_btn = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_volver = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btn_guardar = new Guna.UI.WinForms.GunaGradientButton();
            this.lbl_reg = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl_ganado = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
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
            this.gunaGradient2Panel1.Controls.Add(this.rtb_des);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_des);
            this.gunaGradient2Panel1.Controls.Add(this.txb_peso);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel1.Controls.Add(this.dat_sal);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_asistentes);
            this.gunaGradient2Panel1.Controls.Add(this.cbx_id);
            this.gunaGradient2Panel1.Controls.Add(this.txb_crias);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_crias);
            this.gunaGradient2Panel1.Controls.Add(this.lbl_id);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(66)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(108, 213);
            this.gunaGradient2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 10;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(588, 640);
            this.gunaGradient2Panel1.TabIndex = 46;
            // 
            // rtb_des
            // 
            this.rtb_des.Location = new System.Drawing.Point(115, 470);
            this.rtb_des.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.Size = new System.Drawing.Size(371, 139);
            this.rtb_des.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtb_des.TabIndex = 5;
            this.rtb_des.Text = "";
            // 
            // lbl_des
            // 
            this.lbl_des.AutoSize = true;
            this.lbl_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_des.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_des.Location = new System.Drawing.Point(105, 427);
            this.lbl_des.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_des.Name = "lbl_des";
            this.lbl_des.Size = new System.Drawing.Size(144, 29);
            this.lbl_des.TabIndex = 42;
            this.lbl_des.Text = "descripcion:";
            // 
            // txb_peso
            // 
            this.txb_peso.Animated = true;
            this.txb_peso.BackColor = System.Drawing.Color.White;
            this.txb_peso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_peso.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.txb_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_peso.LineColor = System.Drawing.Color.Gainsboro;
            this.txb_peso.Location = new System.Drawing.Point(323, 234);
            this.txb_peso.Margin = new System.Windows.Forms.Padding(4);
            this.txb_peso.Name = "txb_peso";
            this.txb_peso.PasswordChar = '\0';
            this.txb_peso.Size = new System.Drawing.Size(164, 41);
            this.txb_peso.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel3.Location = new System.Drawing.Point(105, 330);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(83, 29);
            this.gunaLabel3.TabIndex = 40;
            this.gunaLabel3.Text = "salida:";
            // 
            // dat_sal
            // 
            this.dat_sal.BaseColor = System.Drawing.Color.White;
            this.dat_sal.BorderColor = System.Drawing.Color.Silver;
            this.dat_sal.CustomFormat = null;
            this.dat_sal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dat_sal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dat_sal.ForeColor = System.Drawing.Color.Black;
            this.dat_sal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_sal.Location = new System.Drawing.Point(323, 326);
            this.dat_sal.Margin = new System.Windows.Forms.Padding(4);
            this.dat_sal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dat_sal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dat_sal.Name = "dat_sal";
            this.dat_sal.OnHoverBaseColor = System.Drawing.Color.White;
            this.dat_sal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_sal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dat_sal.OnPressedColor = System.Drawing.Color.Black;
            this.dat_sal.Size = new System.Drawing.Size(164, 32);
            this.dat_sal.TabIndex = 4;
            this.dat_sal.Text = "14/10/2021";
            this.dat_sal.Value = new System.DateTime(2021, 10, 14, 1, 33, 14, 379);
            // 
            // lbl_asistentes
            // 
            this.lbl_asistentes.AutoSize = true;
            this.lbl_asistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asistentes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_asistentes.Location = new System.Drawing.Point(105, 238);
            this.lbl_asistentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_asistentes.Name = "lbl_asistentes";
            this.lbl_asistentes.Size = new System.Drawing.Size(123, 29);
            this.lbl_asistentes.TabIndex = 36;
            this.lbl_asistentes.Text = "peso final:";
            // 
            // cbx_id
            // 
            this.cbx_id.BackColor = System.Drawing.Color.Transparent;
            this.cbx_id.BaseColor = System.Drawing.Color.White;
            this.cbx_id.BorderColor = System.Drawing.Color.Silver;
            this.cbx_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_id.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbx_id.ForeColor = System.Drawing.Color.Black;
            this.cbx_id.FormattingEnabled = true;
            this.cbx_id.Location = new System.Drawing.Point(323, 44);
            this.cbx_id.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_id.Name = "cbx_id";
            this.cbx_id.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbx_id.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_id.Size = new System.Drawing.Size(163, 31);
            this.cbx_id.TabIndex = 1;
            // 
            // txb_crias
            // 
            this.txb_crias.Animated = true;
            this.txb_crias.BackColor = System.Drawing.Color.White;
            this.txb_crias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_crias.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.txb_crias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_crias.LineColor = System.Drawing.Color.Gainsboro;
            this.txb_crias.Location = new System.Drawing.Point(323, 138);
            this.txb_crias.Margin = new System.Windows.Forms.Padding(4);
            this.txb_crias.Name = "txb_crias";
            this.txb_crias.PasswordChar = '\0';
            this.txb_crias.Size = new System.Drawing.Size(164, 41);
            this.txb_crias.TabIndex = 2;
            // 
            // lbl_crias
            // 
            this.lbl_crias.AutoSize = true;
            this.lbl_crias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crias.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_crias.Location = new System.Drawing.Point(105, 142);
            this.lbl_crias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_crias.Name = "lbl_crias";
            this.lbl_crias.Size = new System.Drawing.Size(101, 29);
            this.lbl_crias.TabIndex = 27;
            this.lbl_crias.Text = "importe:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_id.Location = new System.Drawing.Point(105, 46);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(48, 29);
            this.lbl_id.TabIndex = 23;
            this.lbl_id.Text = "ID: ";
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Animated = true;
            this.cancelar_btn.AnimationHoverSpeed = 0.07F;
            this.cancelar_btn.AnimationSpeed = 0.03F;
            this.cancelar_btn.BackColor = System.Drawing.Color.Transparent;
            this.cancelar_btn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(151)))));
            this.cancelar_btn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.cancelar_btn.BorderColor = System.Drawing.Color.Black;
            this.cancelar_btn.BorderSize = 1;
            this.cancelar_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar_btn.FocusedColor = System.Drawing.Color.Empty;
            this.cancelar_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_btn.ForeColor = System.Drawing.Color.White;
            this.cancelar_btn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.cancelar_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancelar_btn.Image")));
            this.cancelar_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelar_btn.Location = new System.Drawing.Point(457, 868);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.cancelar_btn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cancelar_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelar_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelar_btn.OnHoverImage = null;
            this.cancelar_btn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelar_btn.Radius = 5;
            this.cancelar_btn.Size = new System.Drawing.Size(180, 52);
            this.cancelar_btn.TabIndex = 7;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Animated = true;
            this.btn_volver.AnimationHoverSpeed = 0.07F;
            this.btn_volver.AnimationSpeed = 0.03F;
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(69)))), ((int)(((byte)(68)))));
            this.btn_volver.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(151)))));
            this.btn_volver.BorderColor = System.Drawing.Color.Black;
            this.btn_volver.BorderSize = 1;
            this.btn_volver.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_volver.FocusedColor = System.Drawing.Color.Empty;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_volver.Location = new System.Drawing.Point(535, 976);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.btn_volver.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btn_volver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_volver.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_volver.OnHoverImage = null;
            this.btn_volver.OnPressedColor = System.Drawing.Color.Black;
            this.btn_volver.Radius = 5;
            this.btn_volver.Size = new System.Drawing.Size(161, 52);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "Volver";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.gunaSeparator1.LineColor = System.Drawing.Color.Black;
            this.gunaSeparator1.Location = new System.Drawing.Point(144, 183);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(539, 22);
            this.gunaSeparator1.TabIndex = 45;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Animated = true;
            this.btn_guardar.AnimationHoverSpeed = 0.07F;
            this.btn_guardar.AnimationSpeed = 0.03F;
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(151)))));
            this.btn_guardar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_guardar.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.BorderSize = 1;
            this.btn_guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_guardar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_guardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_guardar.Location = new System.Drawing.Point(181, 868);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_guardar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.btn_guardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_guardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_guardar.OnHoverImage = null;
            this.btn_guardar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_guardar.Radius = 5;
            this.btn_guardar.Size = new System.Drawing.Size(180, 52);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            // 
            // lbl_reg
            // 
            this.lbl_reg.Location = new System.Drawing.Point(223, 138);
            this.lbl_reg.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_reg.Name = "lbl_reg";
            this.lbl_reg.Size = new System.Drawing.Size(335, 48);
            this.lbl_reg.StateCommon.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lbl_reg.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.lbl_reg.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.lbl_reg.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.lbl_reg.StateCommon.ShortText.ColorAngle = 4F;
            this.lbl_reg.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch90;
            this.lbl_reg.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_reg.TabIndex = 44;
            this.lbl_reg.Values.Text = "Registro de Salida";
            // 
            // pnl_ganado
            // 
            this.pnl_ganado.Controls.Add(this.gunaPictureBox1);
            this.pnl_ganado.Controls.Add(this.kryptonBorderEdge1);
            this.pnl_ganado.Location = new System.Drawing.Point(-59, -12);
            this.pnl_ganado.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_ganado.Name = "pnl_ganado";
            this.pnl_ganado.Size = new System.Drawing.Size(1073, 127);
            this.pnl_ganado.TabIndex = 43;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(16, -183);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(987, 399);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(321, 114);
            this.kryptonBorderEdge1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(67, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // reg_salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(825, 970);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_reg);
            this.Controls.Add(this.pnl_ganado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reg_salida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reg_salida";
            this.Load += new System.EventHandler(this.reg_salida_Load);
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
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtb_des;
        private Guna.UI.WinForms.GunaLabel lbl_des;
        private Guna.UI.WinForms.GunaLineTextBox txb_peso;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDateTimePicker dat_sal;
        private Guna.UI.WinForms.GunaLabel lbl_asistentes;
        private Guna.UI.WinForms.GunaComboBox cbx_id;
        private Guna.UI.WinForms.GunaLineTextBox txb_crias;
        private Guna.UI.WinForms.GunaLabel lbl_crias;
        private Guna.UI.WinForms.GunaLabel lbl_id;
        private Guna.UI.WinForms.GunaGradientButton cancelar_btn;
        private Guna.UI.WinForms.GunaGradientButton btn_volver;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaGradientButton btn_guardar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_reg;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnl_ganado;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
    }
}