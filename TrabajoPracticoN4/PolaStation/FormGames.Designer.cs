namespace PolaStation
{
    partial class FormGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGames));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.radiobtnDigital = new System.Windows.Forms.RadioButton();
            this.radiobtnFisico = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblprecioTotal = new System.Windows.Forms.Label();
            this.StockPS = new System.Windows.Forms.Button();
            this.rdbPS1 = new System.Windows.Forms.RadioButton();
            this.lblConsola = new System.Windows.Forms.Label();
            this.rdbPS4 = new System.Windows.Forms.RadioButton();
            this.rdbPS3 = new System.Windows.Forms.RadioButton();
            this.rdbPS2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPS = new System.Windows.Forms.ComboBox();
            this.btnCarritoConsola = new System.Windows.Forms.Button();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(160, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(549, 31);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Game";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Purple;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(41, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Purple;
            this.lblModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblModelo.Location = new System.Drawing.Point(41, 91);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(92, 27);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbModelo
            // 
            this.cmbModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            "PS1",
            "PS2",
            "PS3",
            "PS4"});
            this.cmbModelo.Location = new System.Drawing.Point(160, 86);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(549, 32);
            this.cmbModelo.TabIndex = 3;
            // 
            // lblFormato
            // 
            this.lblFormato.BackColor = System.Drawing.Color.Purple;
            this.lblFormato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFormato.Location = new System.Drawing.Point(40, 149);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(93, 27);
            this.lblFormato.TabIndex = 4;
            this.lblFormato.Text = "Formato";
            this.lblFormato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiobtnDigital
            // 
            this.radiobtnDigital.AutoSize = true;
            this.radiobtnDigital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radiobtnDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnDigital.Location = new System.Drawing.Point(160, 149);
            this.radiobtnDigital.Name = "radiobtnDigital";
            this.radiobtnDigital.Size = new System.Drawing.Size(78, 28);
            this.radiobtnDigital.TabIndex = 5;
            this.radiobtnDigital.TabStop = true;
            this.radiobtnDigital.Text = "Digital";
            this.radiobtnDigital.UseVisualStyleBackColor = false;
            // 
            // radiobtnFisico
            // 
            this.radiobtnFisico.AutoSize = true;
            this.radiobtnFisico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radiobtnFisico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radiobtnFisico.Cursor = System.Windows.Forms.Cursors.Default;
            this.radiobtnFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnFisico.Location = new System.Drawing.Point(270, 149);
            this.radiobtnFisico.Name = "radiobtnFisico";
            this.radiobtnFisico.Size = new System.Drawing.Size(78, 28);
            this.radiobtnFisico.TabIndex = 6;
            this.radiobtnFisico.TabStop = true;
            this.radiobtnFisico.Text = "Fisico";
            this.radiobtnFisico.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnMostrar.BackColor = System.Drawing.Color.Purple;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrar.Location = new System.Drawing.Point(29, 714);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(170, 42);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Stock Juegos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1249, 735);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha y Hora";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Purple;
            this.progressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar.Location = new System.Drawing.Point(1455, 733);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(232, 23);
            this.progressBar.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Indigo;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(1455, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 356);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.Purple;
            this.btnCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCarrito.Location = new System.Drawing.Point(515, 135);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(194, 41);
            this.btnCarrito.TabIndex = 11;
            this.btnCarrito.Text = "Agregar a Carrito";
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.BackColor = System.Drawing.Color.Black;
            this.lblCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCarrito.Location = new System.Drawing.Point(1515, 9);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(122, 39);
            this.lblCarrito.TabIndex = 12;
            this.lblCarrito.Text = "Carrito";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(1234, 200);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(186, 38);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar Carrito";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Purple;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComprar.Location = new System.Drawing.Point(728, 720);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(218, 39);
            this.btnComprar.TabIndex = 14;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblprecioTotal
            // 
            this.lblprecioTotal.AutoSize = true;
            this.lblprecioTotal.BackColor = System.Drawing.Color.Purple;
            this.lblprecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecioTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblprecioTotal.Location = new System.Drawing.Point(984, 722);
            this.lblprecioTotal.Name = "lblprecioTotal";
            this.lblprecioTotal.Size = new System.Drawing.Size(94, 39);
            this.lblprecioTotal.TabIndex = 15;
            this.lblprecioTotal.Text = "Total";
            // 
            // StockPS
            // 
            this.StockPS.BackColor = System.Drawing.Color.Purple;
            this.StockPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockPS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockPS.Location = new System.Drawing.Point(205, 714);
            this.StockPS.Name = "StockPS";
            this.StockPS.Size = new System.Drawing.Size(192, 42);
            this.StockPS.TabIndex = 16;
            this.StockPS.Text = "Stock Consolas PS";
            this.StockPS.UseVisualStyleBackColor = false;
            this.StockPS.Click += new System.EventHandler(this.StockPS_Click);
            // 
            // rdbPS1
            // 
            this.rdbPS1.AutoSize = true;
            this.rdbPS1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbPS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPS1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbPS1.Location = new System.Drawing.Point(886, 39);
            this.rdbPS1.Name = "rdbPS1";
            this.rdbPS1.Size = new System.Drawing.Size(60, 24);
            this.rdbPS1.TabIndex = 18;
            this.rdbPS1.TabStop = true;
            this.rdbPS1.Text = "PS1";
            this.rdbPS1.UseVisualStyleBackColor = false;
            // 
            // lblConsola
            // 
            this.lblConsola.BackColor = System.Drawing.Color.Black;
            this.lblConsola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsola.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblConsola.Location = new System.Drawing.Point(747, 35);
            this.lblConsola.Name = "lblConsola";
            this.lblConsola.Size = new System.Drawing.Size(106, 29);
            this.lblConsola.TabIndex = 19;
            this.lblConsola.Text = "Consola";
            this.lblConsola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbPS4
            // 
            this.rdbPS4.AutoSize = true;
            this.rdbPS4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbPS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPS4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbPS4.Location = new System.Drawing.Point(1234, 39);
            this.rdbPS4.Name = "rdbPS4";
            this.rdbPS4.Size = new System.Drawing.Size(60, 24);
            this.rdbPS4.TabIndex = 20;
            this.rdbPS4.TabStop = true;
            this.rdbPS4.Text = "PS4";
            this.rdbPS4.UseVisualStyleBackColor = false;
            // 
            // rdbPS3
            // 
            this.rdbPS3.AutoSize = true;
            this.rdbPS3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbPS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPS3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbPS3.Location = new System.Drawing.Point(1109, 40);
            this.rdbPS3.Name = "rdbPS3";
            this.rdbPS3.Size = new System.Drawing.Size(60, 24);
            this.rdbPS3.TabIndex = 21;
            this.rdbPS3.TabStop = true;
            this.rdbPS3.Text = "PS3";
            this.rdbPS3.UseVisualStyleBackColor = false;
            // 
            // rdbPS2
            // 
            this.rdbPS2.AutoSize = true;
            this.rdbPS2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbPS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPS2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbPS2.Location = new System.Drawing.Point(991, 40);
            this.rdbPS2.Name = "rdbPS2";
            this.rdbPS2.Size = new System.Drawing.Size(60, 24);
            this.rdbPS2.TabIndex = 22;
            this.rdbPS2.TabStop = true;
            this.rdbPS2.Text = "PS2";
            this.rdbPS2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(747, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Almacenamiento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPS
            // 
            this.cmbPS.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmbPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPS.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbPS.FormattingEnabled = true;
            this.cmbPS.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "250",
            "500",
            "1024"});
            this.cmbPS.Location = new System.Drawing.Point(974, 89);
            this.cmbPS.Name = "cmbPS";
            this.cmbPS.Size = new System.Drawing.Size(446, 28);
            this.cmbPS.TabIndex = 24;
            this.cmbPS.Text = "Almacenamiento en MB/GB";
            // 
            // btnCarritoConsola
            // 
            this.btnCarritoConsola.BackColor = System.Drawing.Color.Purple;
            this.btnCarritoConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarritoConsola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCarritoConsola.Location = new System.Drawing.Point(1234, 135);
            this.btnCarritoConsola.Name = "btnCarritoConsola";
            this.btnCarritoConsola.Size = new System.Drawing.Size(186, 41);
            this.btnCarritoConsola.TabIndex = 25;
            this.btnCarritoConsola.Text = "Agregar a Carrito";
            this.btnCarritoConsola.UseVisualStyleBackColor = false;
            this.btnCarritoConsola.Click += new System.EventHandler(this.btnCarritoConsola_Click);
            // 
            // rtb2
            // 
            this.rtb2.BackColor = System.Drawing.Color.Indigo;
            this.rtb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb2.ForeColor = System.Drawing.SystemColors.Window;
            this.rtb2.Location = new System.Drawing.Point(1455, 425);
            this.rtb2.Name = "rtb2";
            this.rtb2.Size = new System.Drawing.Size(232, 295);
            this.rtb2.TabIndex = 26;
            this.rtb2.Text = "";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.Color.Purple;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarFactura.Location = new System.Drawing.Point(1234, 262);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(192, 42);
            this.btnGenerarFactura.TabIndex = 27;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // FormGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1699, 768);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.btnCarritoConsola);
            this.Controls.Add(this.cmbPS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbPS2);
            this.Controls.Add(this.rdbPS3);
            this.Controls.Add(this.rdbPS4);
            this.Controls.Add(this.lblConsola);
            this.Controls.Add(this.rdbPS1);
            this.Controls.Add(this.StockPS);
            this.Controls.Add(this.lblprecioTotal);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.radiobtnFisico);
            this.Controls.Add(this.radiobtnDigital);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PolaStation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Closing);
            this.Load += new System.EventHandler(this.FormGames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.RadioButton radiobtnDigital;
        private System.Windows.Forms.RadioButton radiobtnFisico;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblprecioTotal;
        private System.Windows.Forms.Button StockPS;
        private System.Windows.Forms.RadioButton rdbPS1;
        private System.Windows.Forms.Label lblConsola;
        private System.Windows.Forms.RadioButton rdbPS4;
        private System.Windows.Forms.RadioButton rdbPS3;
        private System.Windows.Forms.RadioButton rdbPS2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPS;
        private System.Windows.Forms.Button btnCarritoConsola;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.Button btnGenerarFactura;
    }
}

