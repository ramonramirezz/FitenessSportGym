namespace FitnessSportGym
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
               this.UsuarioT = new System.Windows.Forms.TextBox();
               this.ContraseñaT = new System.Windows.Forms.TextBox();
               this.Encabezado = new System.Windows.Forms.Label();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.AccederB = new System.Windows.Forms.Button();
               this.Cuadro = new System.Windows.Forms.PictureBox();
               this.Fondo = new System.Windows.Forms.PictureBox();
               this.SalirB = new System.Windows.Forms.Button();
               this.Reloj = new System.Windows.Forms.Label();
               this.timer = new System.Windows.Forms.Timer(this.components);
               this.BuscarB = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Cuadro)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
               this.SuspendLayout();
               // 
               // UsuarioT
               // 
               this.UsuarioT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.UsuarioT.Location = new System.Drawing.Point(570, 387);
               this.UsuarioT.Name = "UsuarioT";
               this.UsuarioT.Size = new System.Drawing.Size(250, 35);
               this.UsuarioT.TabIndex = 2;
               // 
               // ContraseñaT
               // 
               this.ContraseñaT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ContraseñaT.Location = new System.Drawing.Point(571, 456);
               this.ContraseñaT.Name = "ContraseñaT";
               this.ContraseñaT.PasswordChar = '*';
               this.ContraseñaT.Size = new System.Drawing.Size(250, 35);
               this.ContraseñaT.TabIndex = 3;
               this.ContraseñaT.UseSystemPasswordChar = true;
               this.ContraseñaT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseñaT_KeyPress);
               // 
               // Encabezado
               // 
               this.Encabezado.AutoSize = true;
               this.Encabezado.BackColor = System.Drawing.Color.DarkRed;
               this.Encabezado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Encabezado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.Encabezado.Location = new System.Drawing.Point(535, 277);
               this.Encabezado.Name = "Encabezado";
               this.Encabezado.Size = new System.Drawing.Size(263, 43);
               this.Encabezado.TabIndex = 5;
               this.Encabezado.Text = "Iniciar Sesion";
               // 
               // pictureBox2
               // 
               this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
               this.pictureBox2.Image = global::FitnessSportGym.Properties.Resources.Lock;
               this.pictureBox2.Location = new System.Drawing.Point(511, 452);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(40, 40);
               this.pictureBox2.TabIndex = 7;
               this.pictureBox2.TabStop = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
               this.pictureBox1.Image = global::FitnessSportGym.Properties.Resources.User;
               this.pictureBox1.Location = new System.Drawing.Point(512, 383);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(40, 40);
               this.pictureBox1.TabIndex = 6;
               this.pictureBox1.TabStop = false;
               // 
               // AccederB
               // 
               this.AccederB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.AccederB.Image = global::FitnessSportGym.Properties.Resources.AccederB;
               this.AccederB.Location = new System.Drawing.Point(511, 535);
               this.AccederB.Name = "AccederB";
               this.AccederB.Size = new System.Drawing.Size(142, 41);
               this.AccederB.TabIndex = 4;
               this.AccederB.UseVisualStyleBackColor = true;
               this.AccederB.Click += new System.EventHandler(this.AccederB_Click);
               // 
               // Cuadro
               // 
               this.Cuadro.BackColor = System.Drawing.Color.DarkRed;
               this.Cuadro.Location = new System.Drawing.Point(471, 224);
               this.Cuadro.Name = "Cuadro";
               this.Cuadro.Size = new System.Drawing.Size(389, 440);
               this.Cuadro.TabIndex = 1;
               this.Cuadro.TabStop = false;
               // 
               // Fondo
               // 
               this.Fondo.Image = global::FitnessSportGym.Properties.Resources.Fondo;
               this.Fondo.Location = new System.Drawing.Point(0, 0);
               this.Fondo.Name = "Fondo";
               this.Fondo.Size = new System.Drawing.Size(1008, 664);
               this.Fondo.TabIndex = 0;
               this.Fondo.TabStop = false;
               // 
               // SalirB
               // 
               this.SalirB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.SalirB.Image = global::FitnessSportGym.Properties.Resources.SalirB;
               this.SalirB.Location = new System.Drawing.Point(678, 535);
               this.SalirB.Name = "SalirB";
               this.SalirB.Size = new System.Drawing.Size(142, 41);
               this.SalirB.TabIndex = 8;
               this.SalirB.UseVisualStyleBackColor = true;
               this.SalirB.Click += new System.EventHandler(this.button1_Click);
               // 
               // Reloj
               // 
               this.Reloj.AutoSize = true;
               this.Reloj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.Reloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.Reloj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Reloj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.Reloj.Image = global::FitnessSportGym.Properties.Resources.Fondo;
               this.Reloj.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
               this.Reloj.Location = new System.Drawing.Point(1, 589);
               this.Reloj.Name = "Reloj";
               this.Reloj.Size = new System.Drawing.Size(300, 75);
               this.Reloj.TabIndex = 9;
               this.Reloj.Text = "00:00:00";
               // 
               // timer
               // 
               this.timer.Enabled = true;
               this.timer.Tick += new System.EventHandler(this.timer_Tick);
               // 
               // BuscarB
               // 
               this.BuscarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.BuscarB.Image = global::FitnessSportGym.Properties.Resources.VerB;
               this.BuscarB.Location = new System.Drawing.Point(590, 608);
               this.BuscarB.Name = "BuscarB";
               this.BuscarB.Size = new System.Drawing.Size(142, 41);
               this.BuscarB.TabIndex = 10;
               this.BuscarB.UseVisualStyleBackColor = true;
               this.BuscarB.Click += new System.EventHandler(this.BuscarB_Click);
               // 
               // Inicio
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ClientSize = new System.Drawing.Size(1008, 661);
               this.Controls.Add(this.BuscarB);
               this.Controls.Add(this.Reloj);
               this.Controls.Add(this.SalirB);
               this.Controls.Add(this.pictureBox2);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.Encabezado);
               this.Controls.Add(this.AccederB);
               this.Controls.Add(this.ContraseñaT);
               this.Controls.Add(this.UsuarioT);
               this.Controls.Add(this.Cuadro);
               this.Controls.Add(this.Fondo);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "Inicio";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Cuadro)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.PictureBox Cuadro;
        private System.Windows.Forms.TextBox UsuarioT;
        private System.Windows.Forms.TextBox ContraseñaT;
        private System.Windows.Forms.Button AccederB;
        private System.Windows.Forms.Label Encabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SalirB;
        private System.Windows.Forms.Label Reloj;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BuscarB;
    }
}

