namespace FitnessSportGym
{
    partial class Entrenador
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrenador));
               this.NombreT = new System.Windows.Forms.TextBox();
               this.numb = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.registro = new System.Windows.Forms.DataGridView();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.button1 = new System.Windows.Forms.Button();
               this.VentasB = new System.Windows.Forms.Button();
               this.Imagen = new System.Windows.Forms.PictureBox();
               this.ImagenC = new System.Windows.Forms.PictureBox();
               this.SalirB = new System.Windows.Forms.Button();
               this.LimpiarB = new System.Windows.Forms.Button();
               this.BuscarB = new System.Windows.Forms.Button();
               this.ClientesG = new System.Windows.Forms.GroupBox();
               this.button2 = new System.Windows.Forms.Button();
               this.AClientesB = new System.Windows.Forms.Button();
               this.VClientesB = new System.Windows.Forms.Button();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.registro)).BeginInit();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.ImagenC)).BeginInit();
               this.ClientesG.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // NombreT
               // 
               this.NombreT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.NombreT.Location = new System.Drawing.Point(592, 123);
               this.NombreT.Name = "NombreT";
               this.NombreT.Size = new System.Drawing.Size(250, 35);
               this.NombreT.TabIndex = 11;
               // 
               // numb
               // 
               this.numb.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.numb.Location = new System.Drawing.Point(592, 47);
               this.numb.Name = "numb";
               this.numb.Size = new System.Drawing.Size(250, 35);
               this.numb.TabIndex = 12;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Black;
               this.label1.Location = new System.Drawing.Point(589, 25);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(110, 22);
               this.label1.TabIndex = 13;
               this.label1.Text = "No. Cliente";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.Black;
               this.label2.Location = new System.Drawing.Point(593, 86);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(83, 22);
               this.label2.TabIndex = 14;
               this.label2.Text = "Nombre";
               // 
               // registro
               // 
               this.registro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
               this.registro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
               this.registro.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
               this.registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.registro.Location = new System.Drawing.Point(362, 234);
               this.registro.Name = "registro";
               this.registro.Size = new System.Drawing.Size(606, 416);
               this.registro.TabIndex = 17;
               this.registro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registro_CellClick);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.Gray;
               this.groupBox1.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo_gris;
               this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.groupBox1.Controls.Add(this.button1);
               this.groupBox1.Controls.Add(this.VentasB);
               this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.groupBox1.Location = new System.Drawing.Point(62, 412);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(238, 161);
               this.groupBox1.TabIndex = 19;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Agregar";
               // 
               // button1
               // 
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Image = global::FitnessSportGym.Properties.Resources.PagoB;
               this.button1.Location = new System.Drawing.Point(43, 95);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(142, 41);
               this.button1.TabIndex = 22;
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // VentasB
               // 
               this.VentasB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.VentasB.Image = global::FitnessSportGym.Properties.Resources.VentasB;
               this.VentasB.Location = new System.Drawing.Point(43, 39);
               this.VentasB.Name = "VentasB";
               this.VentasB.Size = new System.Drawing.Size(142, 41);
               this.VentasB.TabIndex = 18;
               this.VentasB.UseVisualStyleBackColor = true;
               this.VentasB.Click += new System.EventHandler(this.VentasB_Click);
               // 
               // Imagen
               // 
               this.Imagen.Location = new System.Drawing.Point(82, 12);
               this.Imagen.Name = "Imagen";
               this.Imagen.Size = new System.Drawing.Size(200, 200);
               this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.Imagen.TabIndex = 21;
               this.Imagen.TabStop = false;
               // 
               // ImagenC
               // 
               this.ImagenC.Location = new System.Drawing.Point(362, 12);
               this.ImagenC.Name = "ImagenC";
               this.ImagenC.Size = new System.Drawing.Size(200, 200);
               this.ImagenC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.ImagenC.TabIndex = 20;
               this.ImagenC.TabStop = false;
               // 
               // SalirB
               // 
               this.SalirB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.SalirB.Image = global::FitnessSportGym.Properties.Resources.SalirB;
               this.SalirB.Location = new System.Drawing.Point(105, 593);
               this.SalirB.Name = "SalirB";
               this.SalirB.Size = new System.Drawing.Size(142, 41);
               this.SalirB.TabIndex = 18;
               this.SalirB.UseVisualStyleBackColor = true;
               this.SalirB.Click += new System.EventHandler(this.SalirB_Click);
               // 
               // LimpiarB
               // 
               this.LimpiarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.LimpiarB.Image = global::FitnessSportGym.Properties.Resources.LimpiarB;
               this.LimpiarB.Location = new System.Drawing.Point(854, 117);
               this.LimpiarB.Name = "LimpiarB";
               this.LimpiarB.Size = new System.Drawing.Size(142, 41);
               this.LimpiarB.TabIndex = 16;
               this.LimpiarB.UseVisualStyleBackColor = true;
               this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
               // 
               // BuscarB
               // 
               this.BuscarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.BuscarB.Image = global::FitnessSportGym.Properties.Resources.VerB;
               this.BuscarB.Location = new System.Drawing.Point(854, 47);
               this.BuscarB.Name = "BuscarB";
               this.BuscarB.Size = new System.Drawing.Size(142, 41);
               this.BuscarB.TabIndex = 15;
               this.BuscarB.UseVisualStyleBackColor = true;
               this.BuscarB.Click += new System.EventHandler(this.BuscarB_Click);
               // 
               // ClientesG
               // 
               this.ClientesG.BackColor = System.Drawing.Color.DimGray;
               this.ClientesG.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo_gris;
               this.ClientesG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientesG.Controls.Add(this.button2);
               this.ClientesG.Controls.Add(this.AClientesB);
               this.ClientesG.Controls.Add(this.VClientesB);
               this.ClientesG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ClientesG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ClientesG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ClientesG.Location = new System.Drawing.Point(38, 234);
               this.ClientesG.Name = "ClientesG";
               this.ClientesG.Size = new System.Drawing.Size(300, 158);
               this.ClientesG.TabIndex = 8;
               this.ClientesG.TabStop = false;
               this.ClientesG.Text = "Clientes";
               // 
               // button2
               // 
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button2.Image = global::FitnessSportGym.Properties.Resources.inactivo;
               this.button2.Location = new System.Drawing.Point(154, 96);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(142, 41);
               this.button2.TabIndex = 3;
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click_1);
               // 
               // AClientesB
               // 
               this.AClientesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.AClientesB.Image = global::FitnessSportGym.Properties.Resources.AgregarB;
               this.AClientesB.Location = new System.Drawing.Point(67, 25);
               this.AClientesB.Name = "AClientesB";
               this.AClientesB.Size = new System.Drawing.Size(142, 41);
               this.AClientesB.TabIndex = 1;
               this.AClientesB.UseVisualStyleBackColor = true;
               this.AClientesB.Click += new System.EventHandler(this.AClientesB_Click);
               // 
               // VClientesB
               // 
               this.VClientesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.VClientesB.Image = global::FitnessSportGym.Properties.Resources.activo;
               this.VClientesB.Location = new System.Drawing.Point(6, 96);
               this.VClientesB.Name = "VClientesB";
               this.VClientesB.Size = new System.Drawing.Size(142, 41);
               this.VClientesB.TabIndex = 2;
               this.VClientesB.UseVisualStyleBackColor = true;
               this.VClientesB.Click += new System.EventHandler(this.VClientesB_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo1;
               this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBox1.Location = new System.Drawing.Point(0, 0);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(1009, 661);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // Entrenador
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ClientSize = new System.Drawing.Size(1008, 661);
               this.Controls.Add(this.Imagen);
               this.Controls.Add(this.ImagenC);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.SalirB);
               this.Controls.Add(this.registro);
               this.Controls.Add(this.LimpiarB);
               this.Controls.Add(this.BuscarB);
               this.Controls.Add(this.numb);
               this.Controls.Add(this.NombreT);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.ClientesG);
               this.Controls.Add(this.pictureBox1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "Entrenador";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Load += new System.EventHandler(this.Entrenador_Load);
               ((System.ComponentModel.ISupportInitialize)(this.registro)).EndInit();
               this.groupBox1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.ImagenC)).EndInit();
               this.ClientesG.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ClientesG;
        private System.Windows.Forms.Button AClientesB;
        private System.Windows.Forms.Button VClientesB;
        private System.Windows.Forms.TextBox NombreT;
        private System.Windows.Forms.TextBox numb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarB;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.DataGridView registro;
        private System.Windows.Forms.Button SalirB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VentasB;
        private System.Windows.Forms.PictureBox ImagenC;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}