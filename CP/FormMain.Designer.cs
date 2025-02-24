﻿namespace CP
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnAlta = new Button();
            btnBaja = new Button();
            btnModificar = new Button();
            GrillaBD = new DataGridView();
            id_pel = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            id_director = new DataGridViewTextBoxColumn();
            desc_pel = new DataGridViewTextBoxColumn();
            id_categoria = new DataGridViewTextBoxColumn();
            id_productora = new DataGridViewTextBoxColumn();
            anio_pel = new DataGridViewTextBoxColumn();
            cant_pel = new DataGridViewTextBoxColumn();
            lblbuscar = new Label();
            txtBuscar = new TextBox();
            colorDialog1 = new ColorDialog();
            btnSalir = new Button();
            picBPeli = new PictureBox();
            labeltitulo1 = new Label();
            labelTextoAdvertencia = new Label();
            ((System.ComponentModel.ISupportInitialize)GrillaBD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBPeli).BeginInit();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.BackColor = SystemColors.GradientActiveCaption;
            btnAlta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlta.Location = new Point(30, 110);
            btnAlta.Margin = new Padding(4, 3, 4, 3);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(184, 42);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "AltaTutu";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.IndianRed;
            btnBaja.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.Location = new Point(243, 110);
            btnBaja.Margin = new Padding(4, 3, 4, 3);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(184, 42);
            btnBaja.TabIndex = 1;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 255, 128);
            btnModificar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(461, 110);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(184, 42);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // GrillaBD
            // 
            GrillaBD.BackgroundColor = Color.White;
            GrillaBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaBD.Columns.AddRange(new DataGridViewColumn[] { id_pel, Titulo, id_director, desc_pel, id_categoria, id_productora, anio_pel, cant_pel });
            GrillaBD.GridColor = Color.LightGray;
            GrillaBD.Location = new Point(14, 231);
            GrillaBD.Margin = new Padding(4, 3, 4, 3);
            GrillaBD.Name = "GrillaBD";
            GrillaBD.Size = new Size(1346, 347);
            GrillaBD.TabIndex = 3;
            GrillaBD.CellContentClick += GrillaBD_CellContentClick;
            // 
            // id_pel
            // 
            id_pel.HeaderText = "CODIGO";
            id_pel.Name = "id_pel";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "titulo";
            Titulo.Name = "Titulo";
            Titulo.Width = 200;
            // 
            // id_director
            // 
            id_director.HeaderText = "director";
            id_director.Name = "id_director";
            id_director.Width = 200;
            // 
            // desc_pel
            // 
            desc_pel.HeaderText = "descripcion";
            desc_pel.Name = "desc_pel";
            desc_pel.Width = 200;
            // 
            // id_categoria
            // 
            id_categoria.HeaderText = "categoria";
            id_categoria.Name = "id_categoria";
            // 
            // id_productora
            // 
            id_productora.HeaderText = "productora";
            id_productora.Name = "id_productora";
            // 
            // anio_pel
            // 
            anio_pel.HeaderText = "anio";
            anio_pel.Name = "anio_pel";
            // 
            // cant_pel
            // 
            cant_pel.HeaderText = "cantidad";
            cant_pel.Name = "cant_pel";
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblbuscar.Location = new Point(27, 189);
            lblbuscar.Margin = new Padding(4, 0, 4, 0);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(50, 13);
            lblbuscar.TabIndex = 4;
            lblbuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(84, 186);
            txtBuscar.Margin = new Padding(4, 3, 4, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(320, 23);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(1273, 601);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 27);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // picBPeli
            // 
            picBPeli.BackColor = Color.Black;
            picBPeli.BorderStyle = BorderStyle.FixedSingle;
            picBPeli.Image = (Image)resources.GetObject("picBPeli.Image");
            picBPeli.Location = new Point(1126, 36);
            picBPeli.Margin = new Padding(4, 3, 4, 3);
            picBPeli.Name = "picBPeli";
            picBPeli.Size = new Size(205, 137);
            picBPeli.SizeMode = PictureBoxSizeMode.StretchImage;
            picBPeli.TabIndex = 7;
            picBPeli.TabStop = false;
            // 
            // labeltitulo1
            // 
            labeltitulo1.AutoSize = true;
            labeltitulo1.BackColor = Color.Lavender;
            labeltitulo1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labeltitulo1.Location = new Point(77, 36);
            labeltitulo1.Margin = new Padding(4, 0, 4, 0);
            labeltitulo1.Name = "labeltitulo1";
            labeltitulo1.Size = new Size(487, 33);
            labeltitulo1.TabIndex = 8;
            labeltitulo1.Text = "BASE DE DATOS DE PELICULAS";
            // 
            // labelTextoAdvertencia
            // 
            labelTextoAdvertencia.AutoSize = true;
            labelTextoAdvertencia.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextoAdvertencia.ForeColor = Color.Red;
            labelTextoAdvertencia.Location = new Point(506, 194);
            labelTextoAdvertencia.Margin = new Padding(4, 0, 4, 0);
            labelTextoAdvertencia.Name = "labelTextoAdvertencia";
            labelTextoAdvertencia.Size = new Size(732, 13);
            labelTextoAdvertencia.TabIndex = 9;
            labelTextoAdvertencia.Text = "IMPORTANTE: DEBE SELECCIONAR TODA LA FILA DE LA PELÍCULA QUE DESEA DAR DE BAJA O MODIFICAR ANTES DE APRETAR EL BOTÓN\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1374, 642);
            Controls.Add(labelTextoAdvertencia);
            Controls.Add(labeltitulo1);
            Controls.Add(picBPeli);
            Controls.Add(btnSalir);
            Controls.Add(txtBuscar);
            Controls.Add(lblbuscar);
            Controls.Add(GrillaBD);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaBD).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBPeli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView GrillaBD;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picBPeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_director;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_pel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_productora;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_pel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_pel;
        private System.Windows.Forms.Label labeltitulo1;
        private System.Windows.Forms.Label labelTextoAdvertencia;
    }
}