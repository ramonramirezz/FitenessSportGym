namespace FitnessSportGym
{
    partial class AgregarEntrenador
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEntrenador));
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.CamBox = new System.Windows.Forms.ComboBox();
               this.NomT = new System.Windows.Forms.TextBox();
               this.ApesT = new System.Windows.Forms.TextBox();
               this.TelT = new System.Windows.Forms.TextBox();
               this.IdET = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.IniciarC = new System.Windows.Forms.Button();
               this.CapturarC = new System.Windows.Forms.Button();
               this.EliminarC = new System.Windows.Forms.Button();
               this.GuardarB = new System.Windows.Forms.Button();
               this.Contra = new System.Windows.Forms.TextBox();
               this.label7 = new System.Windows.Forms.Label();
               this.TipoT = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.entrenador = new System.Windows.Forms.DataGridView();
               this.label9 = new System.Windows.Forms.Label();
               this.contraseña2 = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.entrenador)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo1;
               this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBox1.Location = new System.Drawing.Point(0, 0);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(645, 659);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
               // 
               // CamBox
               // 
               this.CamBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.CamBox.FormattingEnabled = true;
               this.CamBox.Location = new System.Drawing.Point(473, 21);
               this.CamBox.Name = "CamBox";
               this.CamBox.Size = new System.Drawing.Size(151, 26);
               this.CamBox.TabIndex = 3;
               this.CamBox.SelectedIndexChanged += new System.EventHandler(this.CamBox_SelectedIndexChanged);
               // 
               // NomT
               // 
               this.NomT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.NomT.Location = new System.Drawing.Point(34, 274);
               this.NomT.Name = "NomT";
               this.NomT.Size = new System.Drawing.Size(250, 35);
               this.NomT.TabIndex = 4;
               // 
               // ApesT
               // 
               this.ApesT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ApesT.Location = new System.Drawing.Point(35, 340);
               this.ApesT.Name = "ApesT";
               this.ApesT.Size = new System.Drawing.Size(250, 35);
               this.ApesT.TabIndex = 5;
               // 
               // TelT
               // 
               this.TelT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.TelT.Location = new System.Drawing.Point(36, 405);
               this.TelT.Name = "TelT";
               this.TelT.Size = new System.Drawing.Size(250, 35);
               this.TelT.TabIndex = 7;
               this.TelT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelT_KeyPress);
               // 
               // IdET
               // 
               this.IdET.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.IdET.Location = new System.Drawing.Point(36, 471);
               this.IdET.Name = "IdET";
               this.IdET.Size = new System.Drawing.Size(250, 35);
               this.IdET.TabIndex = 9;
               this.IdET.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdET_KeyPress);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.LightGray;
               this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
               this.label1.Location = new System.Drawing.Point(35, 252);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(83, 22);
               this.label1.TabIndex = 10;
               this.label1.Text = "Nombre";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.LightGray;
               this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(38, 318);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(95, 22);
               this.label2.TabIndex = 11;
               this.label2.Text = "Apellidos";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.LightGray;
               this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(38, 383);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(88, 22);
               this.label4.TabIndex = 13;
               this.label4.Text = "Telefono";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.BackColor = System.Drawing.Color.Silver;
               this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(37, 448);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(135, 22);
               this.label6.TabIndex = 15;
               this.label6.Text = "id Entrenador";
               // 
               // IniciarC
               // 
               this.IniciarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.IniciarC.Image = global::FitnessSportGym.Properties.Resources.IniciarB;
               this.IniciarC.Location = new System.Drawing.Point(477, 74);
               this.IniciarC.Name = "IniciarC";
               this.IniciarC.Size = new System.Drawing.Size(142, 41);
               this.IniciarC.TabIndex = 16;
               this.IniciarC.UseVisualStyleBackColor = true;
               this.IniciarC.Click += new System.EventHandler(this.IniciarC_Click);
               // 
               // CapturarC
               // 
               this.CapturarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.CapturarC.Image = global::FitnessSportGym.Properties.Resources.CapturarB;
               this.CapturarC.Location = new System.Drawing.Point(477, 126);
               this.CapturarC.Name = "CapturarC";
               this.CapturarC.Size = new System.Drawing.Size(142, 41);
               this.CapturarC.TabIndex = 17;
               this.CapturarC.UseVisualStyleBackColor = true;
               this.CapturarC.Click += new System.EventHandler(this.CapturarC_Click);
               // 
               // EliminarC
               // 
               this.EliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.EliminarC.Image = global::FitnessSportGym.Properties.Resources.EliminarB;
               this.EliminarC.Location = new System.Drawing.Point(478, 178);
               this.EliminarC.Name = "EliminarC";
               this.EliminarC.Size = new System.Drawing.Size(142, 41);
               this.EliminarC.TabIndex = 18;
               this.EliminarC.UseVisualStyleBackColor = true;
               this.EliminarC.Click += new System.EventHandler(this.EliminarC_Click);
               // 
               // GuardarB
               // 
               this.GuardarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.GuardarB.Image = global::FitnessSportGym.Properties.Resources.GuardarB;
               this.GuardarB.Location = new System.Drawing.Point(491, 611);
               this.GuardarB.Name = "GuardarB";
               this.GuardarB.Size = new System.Drawing.Size(142, 41);
               this.GuardarB.TabIndex = 19;
               this.GuardarB.UseVisualStyleBackColor = true;
               this.GuardarB.Click += new System.EventHandler(this.GuardarB_Click);
               // 
               // Contra
               // 
               this.Contra.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Contra.Location = new System.Drawing.Point(33, 535);
               this.Contra.Name = "Contra";
               this.Contra.PasswordChar = '*';
               this.Contra.Size = new System.Drawing.Size(250, 35);
               this.Contra.TabIndex = 20;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.BackColor = System.Drawing.Color.Silver;
               this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(35, 512);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(115, 22);
               this.label7.TabIndex = 21;
               this.label7.Text = "Contraseña";
               // 
               // TipoT
               // 
               this.TipoT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.TipoT.Location = new System.Drawing.Point(311, 471);
               this.TipoT.Name = "TipoT";
               this.TipoT.Size = new System.Drawing.Size(61, 35);
               this.TipoT.TabIndex = 22;
               this.TipoT.Tag = "1: Admin, 2: Entrenador";
               this.TipoT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoT_KeyPress);
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.BackColor = System.Drawing.Color.LightGray;
               this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.Location = new System.Drawing.Point(310, 448);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(62, 22);
               this.label8.TabIndex = 23;
               this.label8.Text = "TipoT";
               // 
               // videoSourcePlayer1
               // 
               this.videoSourcePlayer1.Location = new System.Drawing.Point(33, 21);
               this.videoSourcePlayer1.Name = "videoSourcePlayer1";
               this.videoSourcePlayer1.Size = new System.Drawing.Size(200, 200);
               this.videoSourcePlayer1.TabIndex = 24;
               this.videoSourcePlayer1.Text = "videoSourcePlayer1";
               this.videoSourcePlayer1.VideoSource = null;
               // 
               // pictureBox3
               // 
               this.pictureBox3.Location = new System.Drawing.Point(252, 21);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(200, 200);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox3.TabIndex = 25;
               this.pictureBox3.TabStop = false;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(378, 471);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(106, 13);
               this.label3.TabIndex = 26;
               this.label3.Text = "Tipo 1: Administrador";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(378, 493);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(95, 13);
               this.label5.TabIndex = 27;
               this.label5.Text = "Tipo 2: Entrenador";
               // 
               // entrenador
               // 
               this.entrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.entrenador.Location = new System.Drawing.Point(379, 274);
               this.entrenador.Name = "entrenador";
               this.entrenador.Size = new System.Drawing.Size(240, 150);
               this.entrenador.TabIndex = 28;
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.BackColor = System.Drawing.Color.Silver;
               this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.Location = new System.Drawing.Point(35, 583);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(228, 22);
               this.label9.TabIndex = 29;
               this.label9.Text = "Verificación Contraseña";
               // 
               // contraseña2
               // 
               this.contraseña2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.contraseña2.Location = new System.Drawing.Point(33, 612);
               this.contraseña2.Name = "contraseña2";
               this.contraseña2.PasswordChar = '*';
               this.contraseña2.Size = new System.Drawing.Size(250, 35);
               this.contraseña2.TabIndex = 30;
               // 
               // AgregarEntrenador
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ClientSize = new System.Drawing.Size(645, 659);
               this.Controls.Add(this.contraseña2);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.entrenador);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.pictureBox3);
               this.Controls.Add(this.videoSourcePlayer1);
               this.Controls.Add(this.TipoT);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.Contra);
               this.Controls.Add(this.GuardarB);
               this.Controls.Add(this.EliminarC);
               this.Controls.Add(this.CapturarC);
               this.Controls.Add(this.IniciarC);
               this.Controls.Add(this.IdET);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.TelT);
               this.Controls.Add(this.ApesT);
               this.Controls.Add(this.NomT);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.CamBox);
               this.Controls.Add(this.pictureBox1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "AgregarEntrenador";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarEntrenador_FormClosing);
               this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarEntrenador_FormClosed);
               this.Load += new System.EventHandler(this.AgregarEntrenador_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.entrenador)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CamBox;
        private System.Windows.Forms.TextBox NomT;
        private System.Windows.Forms.TextBox ApesT;
        private System.Windows.Forms.TextBox TelT;
        private System.Windows.Forms.TextBox IdET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button IniciarC;
        private System.Windows.Forms.Button CapturarC;
        private System.Windows.Forms.Button EliminarC;
        private System.Windows.Forms.Button GuardarB;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TipoT;
        private System.Windows.Forms.Label label8;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView entrenador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox contraseña2;
    }
}