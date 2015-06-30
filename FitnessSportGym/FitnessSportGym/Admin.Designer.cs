namespace FitnessSportGym
{
    partial class Admin
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
               this.NombreT = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.registro = new System.Windows.Forms.DataGridView();
               this.label3 = new System.Windows.Forms.Label();
               this.numb = new System.Windows.Forms.TextBox();
               this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.Imagen = new System.Windows.Forms.PictureBox();
               this.SalirB = new System.Windows.Forms.Button();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.button2 = new System.Windows.Forms.Button();
               this.ComprasB1 = new System.Windows.Forms.Button();
               this.VentasB1 = new System.Windows.Forms.Button();
               this.ProductosB1 = new System.Windows.Forms.Button();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.button1 = new System.Windows.Forms.Button();
               this.ProductoB = new System.Windows.Forms.Button();
               this.ComprasB = new System.Windows.Forms.Button();
               this.VentasB = new System.Windows.Forms.Button();
               this.EntrenadoresG = new System.Windows.Forms.GroupBox();
               this.AEntrenador = new System.Windows.Forms.Button();
               this.VEntrenadores = new System.Windows.Forms.Button();
               this.ClientesG = new System.Windows.Forms.GroupBox();
               this.button3 = new System.Windows.Forms.Button();
               this.AClientesB = new System.Windows.Forms.Button();
               this.VClientesB = new System.Windows.Forms.Button();
               this.LimpiarB = new System.Windows.Forms.Button();
               this.BuscarB = new System.Windows.Forms.Button();
               this.Fondo = new System.Windows.Forms.PictureBox();
               this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               ((System.ComponentModel.ISupportInitialize)(this.registro)).BeginInit();
               this.contextMenuStrip1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
               this.groupBox2.SuspendLayout();
               this.groupBox1.SuspendLayout();
               this.EntrenadoresG.SuspendLayout();
               this.ClientesG.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
               this.SuspendLayout();
               // 
               // NombreT
               // 
               this.NombreT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.NombreT.Location = new System.Drawing.Point(575, 167);
               this.NombreT.Name = "NombreT";
               this.NombreT.Size = new System.Drawing.Size(250, 35);
               this.NombreT.TabIndex = 9;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Black;
               this.label1.Location = new System.Drawing.Point(571, 136);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(83, 22);
               this.label1.TabIndex = 11;
               this.label1.Text = "Nombre";
               // 
               // registro
               // 
               this.registro.BackgroundColor = System.Drawing.Color.Gray;
               this.registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.registro.ContextMenuStrip = this.contextMenuStrip1;
               this.registro.Location = new System.Drawing.Point(347, 265);
               this.registro.Name = "registro";
               this.registro.Size = new System.Drawing.Size(606, 416);
               this.registro.TabIndex = 14;
               this.registro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registro_CellClick);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.Color.Black;
               this.label3.Location = new System.Drawing.Point(571, 47);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(110, 22);
               this.label3.TabIndex = 18;
               this.label3.Text = "No. Cliente";
               this.label3.Click += new System.EventHandler(this.label3_Click);
               // 
               // numb
               // 
               this.numb.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.numb.Location = new System.Drawing.Point(573, 86);
               this.numb.Name = "numb";
               this.numb.Size = new System.Drawing.Size(81, 35);
               this.numb.TabIndex = 19;
               // 
               // contextMenuStrip1
               // 
               this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
               this.contextMenuStrip1.Name = "contextMenuStrip1";
               this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
               // 
               // modificarToolStripMenuItem
               // 
               this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
               this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
               this.modificarToolStripMenuItem.Text = "Modificar";
               this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
               // 
               // Imagen
               // 
               this.Imagen.Location = new System.Drawing.Point(347, 36);
               this.Imagen.Name = "Imagen";
               this.Imagen.Size = new System.Drawing.Size(200, 200);
               this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.Imagen.TabIndex = 17;
               this.Imagen.TabStop = false;
               // 
               // SalirB
               // 
               this.SalirB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.SalirB.Image = global::FitnessSportGym.Properties.Resources.SalirB;
               this.SalirB.Location = new System.Drawing.Point(844, 167);
               this.SalirB.Name = "SalirB";
               this.SalirB.Size = new System.Drawing.Size(142, 41);
               this.SalirB.TabIndex = 16;
               this.SalirB.UseVisualStyleBackColor = true;
               this.SalirB.Click += new System.EventHandler(this.button1_Click);
               // 
               // groupBox2
               // 
               this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
               this.groupBox2.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo_gris;
               this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.groupBox2.Controls.Add(this.button2);
               this.groupBox2.Controls.Add(this.ComprasB1);
               this.groupBox2.Controls.Add(this.VentasB1);
               this.groupBox2.Controls.Add(this.ProductosB1);
               this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.groupBox2.Location = new System.Drawing.Point(45, 479);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(238, 221);
               this.groupBox2.TabIndex = 0;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "Reporte";
               // 
               // button2
               // 
               this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.button2.Image = global::FitnessSportGym.Properties.Resources.PagoB;
               this.button2.Location = new System.Drawing.Point(49, 23);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(142, 41);
               this.button2.TabIndex = 22;
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // ComprasB1
               // 
               this.ComprasB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ComprasB1.Image = global::FitnessSportGym.Properties.Resources.Compras;
               this.ComprasB1.Location = new System.Drawing.Point(49, 117);
               this.ComprasB1.Name = "ComprasB1";
               this.ComprasB1.Size = new System.Drawing.Size(142, 41);
               this.ComprasB1.TabIndex = 20;
               this.ComprasB1.UseVisualStyleBackColor = true;
               this.ComprasB1.Click += new System.EventHandler(this.ComprasB1_Click_1);
               // 
               // VentasB1
               // 
               this.VentasB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.VentasB1.Image = global::FitnessSportGym.Properties.Resources.VentasB;
               this.VentasB1.Location = new System.Drawing.Point(49, 70);
               this.VentasB1.Name = "VentasB1";
               this.VentasB1.Size = new System.Drawing.Size(142, 41);
               this.VentasB1.TabIndex = 19;
               this.VentasB1.UseVisualStyleBackColor = true;
               this.VentasB1.Click += new System.EventHandler(this.VentasB1_Click);
               // 
               // ProductosB1
               // 
               this.ProductosB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ProductosB1.Image = global::FitnessSportGym.Properties.Resources.ProductosB;
               this.ProductosB1.Location = new System.Drawing.Point(49, 164);
               this.ProductosB1.Name = "ProductosB1";
               this.ProductosB1.Size = new System.Drawing.Size(142, 41);
               this.ProductosB1.TabIndex = 21;
               this.ProductosB1.UseVisualStyleBackColor = true;
               this.ProductosB1.Click += new System.EventHandler(this.ProductosB1_Click);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
               this.groupBox1.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo_gris;
               this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.groupBox1.Controls.Add(this.button1);
               this.groupBox1.Controls.Add(this.ProductoB);
               this.groupBox1.Controls.Add(this.ComprasB);
               this.groupBox1.Controls.Add(this.VentasB);
               this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.groupBox1.Location = new System.Drawing.Point(45, 247);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(238, 226);
               this.groupBox1.TabIndex = 15;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Agregar";
               // 
               // button1
               // 
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Image = global::FitnessSportGym.Properties.Resources.PagoB;
               this.button1.Location = new System.Drawing.Point(48, 26);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(142, 41);
               this.button1.TabIndex = 18;
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click_1);
               // 
               // ProductoB
               // 
               this.ProductoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ProductoB.Image = global::FitnessSportGym.Properties.Resources.ProductosB;
               this.ProductoB.Location = new System.Drawing.Point(49, 167);
               this.ProductoB.Name = "ProductoB";
               this.ProductoB.Size = new System.Drawing.Size(142, 41);
               this.ProductoB.TabIndex = 16;
               this.ProductoB.UseVisualStyleBackColor = true;
               this.ProductoB.Click += new System.EventHandler(this.ProductoB_Click);
               // 
               // ComprasB
               // 
               this.ComprasB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ComprasB.Image = global::FitnessSportGym.Properties.Resources.Compras;
               this.ComprasB.Location = new System.Drawing.Point(49, 120);
               this.ComprasB.Name = "ComprasB";
               this.ComprasB.Size = new System.Drawing.Size(142, 41);
               this.ComprasB.TabIndex = 17;
               this.ComprasB.UseVisualStyleBackColor = true;
               this.ComprasB.Click += new System.EventHandler(this.ComprasB_Click);
               // 
               // VentasB
               // 
               this.VentasB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.VentasB.Image = global::FitnessSportGym.Properties.Resources.VentasB;
               this.VentasB.Location = new System.Drawing.Point(49, 73);
               this.VentasB.Name = "VentasB";
               this.VentasB.Size = new System.Drawing.Size(142, 41);
               this.VentasB.TabIndex = 18;
               this.VentasB.UseVisualStyleBackColor = true;
               this.VentasB.Click += new System.EventHandler(this.VentasB_Click);
               // 
               // EntrenadoresG
               // 
               this.EntrenadoresG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.EntrenadoresG.BackColor = System.Drawing.SystemColors.ControlDarkDark;
               this.EntrenadoresG.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo_gris;
               this.EntrenadoresG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.EntrenadoresG.Controls.Add(this.AEntrenador);
               this.EntrenadoresG.Controls.Add(this.VEntrenadores);
               this.EntrenadoresG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.EntrenadoresG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.EntrenadoresG.Location = new System.Drawing.Point(45, 122);
               this.EntrenadoresG.Name = "EntrenadoresG";
               this.EntrenadoresG.Size = new System.Drawing.Size(238, 119);
               this.EntrenadoresG.TabIndex = 8;
               this.EntrenadoresG.TabStop = false;
               this.EntrenadoresG.Text = "Entrenadores";
               // 
               // AEntrenador
               // 
               this.AEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.AEntrenador.Image = global::FitnessSportGym.Properties.Resources.AgregarB;
               this.AEntrenador.Location = new System.Drawing.Point(48, 24);
               this.AEntrenador.Name = "AEntrenador";
               this.AEntrenador.Size = new System.Drawing.Size(142, 41);
               this.AEntrenador.TabIndex = 3;
               this.AEntrenador.UseVisualStyleBackColor = true;
               this.AEntrenador.Click += new System.EventHandler(this.AEntrenador_Click);
               // 
               // VEntrenadores
               // 
               this.VEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.VEntrenadores.Image = global::FitnessSportGym.Properties.Resources.VerB;
               this.VEntrenadores.Location = new System.Drawing.Point(48, 71);
               this.VEntrenadores.Name = "VEntrenadores";
               this.VEntrenadores.Size = new System.Drawing.Size(142, 41);
               this.VEntrenadores.TabIndex = 4;
               this.VEntrenadores.UseVisualStyleBackColor = true;
               this.VEntrenadores.Click += new System.EventHandler(this.VEntrenadores_Click);
               // 
               // ClientesG
               // 
               this.ClientesG.BackColor = System.Drawing.Color.DimGray;
               this.ClientesG.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo_gris;
               this.ClientesG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientesG.Controls.Add(this.button3);
               this.ClientesG.Controls.Add(this.AClientesB);
               this.ClientesG.Controls.Add(this.VClientesB);
               this.ClientesG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ClientesG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ClientesG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ClientesG.Location = new System.Drawing.Point(12, 0);
               this.ClientesG.Name = "ClientesG";
               this.ClientesG.Size = new System.Drawing.Size(301, 116);
               this.ClientesG.TabIndex = 7;
               this.ClientesG.TabStop = false;
               this.ClientesG.Text = "Clientes";
               // 
               // button3
               // 
               this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button3.Image = global::FitnessSportGym.Properties.Resources.inactivo;
               this.button3.Location = new System.Drawing.Point(154, 68);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(142, 41);
               this.button3.TabIndex = 3;
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // AClientesB
               // 
               this.AClientesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.AClientesB.Image = global::FitnessSportGym.Properties.Resources.AgregarB;
               this.AClientesB.Location = new System.Drawing.Point(67, 21);
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
               this.VClientesB.Location = new System.Drawing.Point(6, 68);
               this.VClientesB.Name = "VClientesB";
               this.VClientesB.Size = new System.Drawing.Size(142, 41);
               this.VClientesB.TabIndex = 2;
               this.VClientesB.UseVisualStyleBackColor = true;
               this.VClientesB.Click += new System.EventHandler(this.VClientesB_Click);
               // 
               // LimpiarB
               // 
               this.LimpiarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.LimpiarB.Image = global::FitnessSportGym.Properties.Resources.LimpiarB;
               this.LimpiarB.Location = new System.Drawing.Point(844, 107);
               this.LimpiarB.Name = "LimpiarB";
               this.LimpiarB.Size = new System.Drawing.Size(142, 41);
               this.LimpiarB.TabIndex = 6;
               this.LimpiarB.UseVisualStyleBackColor = true;
               this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
               // 
               // BuscarB
               // 
               this.BuscarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.BuscarB.Image = global::FitnessSportGym.Properties.Resources.VerB;
               this.BuscarB.Location = new System.Drawing.Point(844, 47);
               this.BuscarB.Name = "BuscarB";
               this.BuscarB.Size = new System.Drawing.Size(142, 41);
               this.BuscarB.TabIndex = 5;
               this.BuscarB.UseVisualStyleBackColor = true;
               this.BuscarB.Click += new System.EventHandler(this.BuscarB_Click);
               // 
               // Fondo
               // 
               this.Fondo.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo1;
               this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.Fondo.Location = new System.Drawing.Point(0, 0);
               this.Fondo.Name = "Fondo";
               this.Fondo.Size = new System.Drawing.Size(1008, 709);
               this.Fondo.TabIndex = 0;
               this.Fondo.TabStop = false;
               // 
               // eliminarToolStripMenuItem
               // 
               this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
               this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
               this.eliminarToolStripMenuItem.Text = "Eliminar";
               this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
               // 
               // Admin
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ClientSize = new System.Drawing.Size(1008, 693);
               this.Controls.Add(this.numb);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.Imagen);
               this.Controls.Add(this.SalirB);
               this.Controls.Add(this.NombreT);
               this.Controls.Add(this.groupBox2);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.registro);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.EntrenadoresG);
               this.Controls.Add(this.ClientesG);
               this.Controls.Add(this.LimpiarB);
               this.Controls.Add(this.BuscarB);
               this.Controls.Add(this.Fondo);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "Admin";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               ((System.ComponentModel.ISupportInitialize)(this.registro)).EndInit();
               this.contextMenuStrip1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
               this.groupBox2.ResumeLayout(false);
               this.groupBox1.ResumeLayout(false);
               this.EntrenadoresG.ResumeLayout(false);
               this.ClientesG.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.Button AClientesB;
        private System.Windows.Forms.Button VClientesB;
        private System.Windows.Forms.Button AEntrenador;
        private System.Windows.Forms.Button VEntrenadores;
        private System.Windows.Forms.Button BuscarB;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.GroupBox ClientesG;
        private System.Windows.Forms.GroupBox EntrenadoresG;
        private System.Windows.Forms.TextBox NombreT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView registro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ProductoB;
        private System.Windows.Forms.Button ComprasB;
        private System.Windows.Forms.Button VentasB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ComprasB1;
        private System.Windows.Forms.Button VentasB1;
        private System.Windows.Forms.Button ProductosB1;
        private System.Windows.Forms.Button SalirB;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}