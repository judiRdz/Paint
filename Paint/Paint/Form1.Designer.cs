namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxPapel = new System.Windows.Forms.PictureBox();
            this.picBoxNegro = new System.Windows.Forms.PictureBox();
            this.picBoxColores = new System.Windows.Forms.PictureBox();
            this.trackBarTamanioPincel = new System.Windows.Forms.TrackBar();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnPincel = new System.Windows.Forms.Button();
            this.lblTamanioPincel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTamanioPincel)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPapel
            // 
            this.picBoxPapel.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxPapel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBoxPapel.Location = new System.Drawing.Point(78, 58);
            this.picBoxPapel.Name = "picBoxPapel";
            this.picBoxPapel.Size = new System.Drawing.Size(823, 487);
            this.picBoxPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPapel.TabIndex = 0;
            this.picBoxPapel.TabStop = false;
            this.picBoxPapel.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoxPapel_Paint);
            this.picBoxPapel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseDown);
            this.picBoxPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseMove);
            this.picBoxPapel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseUp);
            // 
            // picBoxNegro
            // 
            this.picBoxNegro.BackColor = System.Drawing.Color.Black;
            this.picBoxNegro.Location = new System.Drawing.Point(12, 301);
            this.picBoxNegro.Name = "picBoxNegro";
            this.picBoxNegro.Size = new System.Drawing.Size(27, 27);
            this.picBoxNegro.TabIndex = 1;
            this.picBoxNegro.TabStop = false;
            this.picBoxNegro.Click += new System.EventHandler(this.picBoxNegro_Click);
            // 
            // picBoxColores
            // 
            this.picBoxColores.Location = new System.Drawing.Point(45, 301);
            this.picBoxColores.Name = "picBoxColores";
            this.picBoxColores.Size = new System.Drawing.Size(27, 27);
            this.picBoxColores.TabIndex = 2;
            this.picBoxColores.TabStop = false;
            this.picBoxColores.Click += new System.EventHandler(this.picBoxColores_Click);
            // 
            // trackBarTamanioPincel
            // 
            this.trackBarTamanioPincel.LargeChange = 1;
            this.trackBarTamanioPincel.Location = new System.Drawing.Point(13, 64);
            this.trackBarTamanioPincel.Maximum = 20;
            this.trackBarTamanioPincel.Minimum = 1;
            this.trackBarTamanioPincel.Name = "trackBarTamanioPincel";
            this.trackBarTamanioPincel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTamanioPincel.Size = new System.Drawing.Size(45, 202);
            this.trackBarTamanioPincel.TabIndex = 3;
            this.trackBarTamanioPincel.Value = 3;
            this.trackBarTamanioPincel.Scroll += new System.EventHandler(this.trackBarTamanioPincel_Scroll);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(28, 334);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(44, 23);
            this.txtR.TabIndex = 5;
            this.txtR.Text = "0";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(28, 363);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(44, 23);
            this.txtG.TabIndex = 6;
            this.txtG.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(28, 392);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(44, 23);
            this.txtB.TabIndex = 7;
            this.txtB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Paint.Properties.Resources.disco_flexible;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.Location = new System.Drawing.Point(857, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 45);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrador
            // 
            this.btnBorrador.BackgroundImage = global::Paint.Properties.Resources.borrador;
            this.btnBorrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrador.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBorrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBorrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrador.ForeColor = System.Drawing.Color.Black;
            this.btnBorrador.Location = new System.Drawing.Point(213, 7);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(44, 45);
            this.btnBorrador.TabIndex = 12;
            this.btnBorrador.UseVisualStyleBackColor = true;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnPincel
            // 
            this.btnPincel.BackgroundImage = global::Paint.Properties.Resources.cepillo_de_pintura;
            this.btnPincel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPincel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPincel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPincel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPincel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPincel.ForeColor = System.Drawing.Color.Black;
            this.btnPincel.Location = new System.Drawing.Point(13, 7);
            this.btnPincel.Name = "btnPincel";
            this.btnPincel.Size = new System.Drawing.Size(44, 45);
            this.btnPincel.TabIndex = 13;
            this.btnPincel.UseVisualStyleBackColor = true;
            this.btnPincel.Click += new System.EventHandler(this.btnPincel_Click);
            // 
            // lblTamanioPincel
            // 
            this.lblTamanioPincel.AutoSize = true;
            this.lblTamanioPincel.Location = new System.Drawing.Point(17, 268);
            this.lblTamanioPincel.Name = "lblTamanioPincel";
            this.lblTamanioPincel.Size = new System.Drawing.Size(13, 15);
            this.lblTamanioPincel.TabIndex = 14;
            this.lblTamanioPincel.Text = "3";
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackgroundImage = global::Paint.Properties.Resources.cuadrado__1_;
            this.btnCuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCuadrado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCuadrado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCuadrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCuadrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuadrado.ForeColor = System.Drawing.Color.Black;
            this.btnCuadrado.Location = new System.Drawing.Point(63, 7);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(44, 45);
            this.btnCuadrado.TabIndex = 15;
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.BackgroundImage = global::Paint.Properties.Resources.elipse;
            this.btnElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnElipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnElipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnElipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElipse.ForeColor = System.Drawing.Color.Black;
            this.btnElipse.Location = new System.Drawing.Point(113, 7);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(44, 45);
            this.btnElipse.TabIndex = 16;
            this.btnElipse.UseVisualStyleBackColor = true;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.BackgroundImage = global::Paint.Properties.Resources.linea_diagonal;
            this.btnLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLinea.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLinea.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLinea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLinea.ForeColor = System.Drawing.Color.Black;
            this.btnLinea.Location = new System.Drawing.Point(163, 7);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(44, 45);
            this.btnLinea.TabIndex = 17;
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImage = global::Paint.Properties.Resources.delete;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.Location = new System.Drawing.Point(807, 7);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(44, 45);
            this.delete.TabIndex = 18;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 557);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.btnLinea);
            this.Controls.Add(this.btnElipse);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.lblTamanioPincel);
            this.Controls.Add(this.btnPincel);
            this.Controls.Add(this.btnBorrador);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.trackBarTamanioPincel);
            this.Controls.Add(this.picBoxColores);
            this.Controls.Add(this.picBoxNegro);
            this.Controls.Add(this.picBoxPapel);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTamanioPincel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBoxPapel;
        private PictureBox picBoxNegro;
        private PictureBox picBoxColores;
        private TrackBar trackBarTamanioPincel;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnBorrador;
        private Button btnPincel;
        private Label lblTamanioPincel;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnCuadrado;
        private Button btnElipse;
        private Button btnLinea;
        private Button delete;
    }
}