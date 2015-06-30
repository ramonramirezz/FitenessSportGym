namespace FitnessSportGym
{
    partial class AgregarClientes
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClientes));
               this.CamBox = new System.Windows.Forms.ComboBox();
               this.NomT = new System.Windows.Forms.TextBox();
               this.ApepT = new System.Windows.Forms.TextBox();
               this.ApemT = new System.Windows.Forms.TextBox();
               this.TelT = new System.Windows.Forms.TextBox();
               this.CorreoT = new System.Windows.Forms.TextBox();
               this.IdCT = new System.Windows.Forms.TextBox();
               this.IdET = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.GuardarB = new System.Windows.Forms.Button();
               this.EliminarC = new System.Windows.Forms.Button();
               this.CapturarC = new System.Windows.Forms.Button();
               this.IniciarC = new System.Windows.Forms.Button();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
               this.label8 = new System.Windows.Forms.Label();
               this.fecha = new System.Windows.Forms.DateTimePicker();
               this.entrenador = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.entrenador)).BeginInit();
               this.SuspendLayout();
               // 
               // CamBox
               // 
               this.CamBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.CamBox.FormattingEnabled = true;
               this.CamBox.Location = new System.Drawing.Point(472, 15);
               this.CamBox.Name = "CamBox";
               this.CamBox.Size = new System.Drawing.Size(151, 26);
               this.CamBox.TabIndex = 3;
               this.CamBox.SelectedIndexChanged += new System.EventHandler(this.CamBox_SelectedIndexChanged);
               // 
               // NomT
               // 
               this.NomT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.NomT.Location = new System.Drawing.Point(35, 268);
               this.NomT.Name = "NomT";
               this.NomT.Size = new System.Drawing.Size(250, 35);
               this.NomT.TabIndex = 7;
               // 
               // ApepT
               // 
               this.ApepT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ApepT.Location = new System.Drawing.Point(35, 331);
               this.ApepT.Name = "ApepT";
               this.ApepT.Size = new System.Drawing.Size(250, 35);
               this.ApepT.TabIndex = 8;
               // 
               // ApemT
               // 
               this.ApemT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ApemT.Location = new System.Drawing.Point(35, 394);
               this.ApemT.Name = "ApemT";
               this.ApemT.Size = new System.Drawing.Size(250, 35);
               this.ApemT.TabIndex = 9;
               // 
               // TelT
               // 
               this.TelT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.TelT.Location = new System.Drawing.Point(35, 457);
               this.TelT.Name = "TelT";
               this.TelT.Size = new System.Drawing.Size(250, 35);
               this.TelT.TabIndex = 10;
               this.TelT.TextChanged += new System.EventHandler(this.TelT_TextChanged);
               this.TelT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelT_KeyPress);
               // 
               // CorreoT
               // 
               this.CorreoT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.CorreoT.Location = new System.Drawing.Point(35, 520);
               this.CorreoT.Name = "CorreoT";
               this.CorreoT.Size = new System.Drawing.Size(250, 35);
               this.CorreoT.TabIndex = 11;
               // 
               // IdCT
               // 
               this.IdCT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.IdCT.Location = new System.Drawing.Point(35, 577);
               this.IdCT.Name = "IdCT";
               this.IdCT.Size = new System.Drawing.Size(250, 35);
               this.IdCT.TabIndex = 12;
               this.IdCT.TextChanged += new System.EventHandler(this.IdCT_TextChanged);
               this.IdCT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdCT_KeyPress);
               // 
               // IdET
               // 
               this.IdET.Enabled = false;
               this.IdET.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.IdET.Location = new System.Drawing.Point(35, 644);
               this.IdET.Name = "IdET";
               this.IdET.Size = new System.Drawing.Size(250, 35);
               this.IdET.TabIndex = 13;
               this.IdET.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdET_KeyPress);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.LightGray;
               this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(31, 240);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(83, 22);
               this.label1.TabIndex = 14;
               this.label1.Text = "Nombre";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.LightGray;
               this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(31, 306);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(162, 22);
               this.label2.TabIndex = 15;
               this.label2.Text = "Apellido Paterno";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.LightGray;
               this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(31, 369);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(165, 22);
               this.label3.TabIndex = 16;
               this.label3.Text = "Apellido Materno";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.LightGray;
               this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(31, 432);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(88, 22);
               this.label4.TabIndex = 17;
               this.label4.Text = "Telefono";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.BackColor = System.Drawing.Color.LightGray;
               this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(31, 495);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(73, 22);
               this.label5.TabIndex = 18;
               this.label5.Text = "Correo";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.BackColor = System.Drawing.Color.LightGray;
               this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(37, 558);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(96, 22);
               this.label6.TabIndex = 19;
               this.label6.Text = "Cliente id";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.BackColor = System.Drawing.Color.LightGray;
               this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(37, 619);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(135, 22);
               this.label7.TabIndex = 20;
               this.label7.Text = "Entrenador id";
               // 
               // GuardarB
               // 
               this.GuardarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.GuardarB.Image = global::FitnessSportGym.Properties.Resources.GuardarB;
               this.GuardarB.Location = new System.Drawing.Point(450, 643);
               this.GuardarB.Name = "GuardarB";
               this.GuardarB.Size = new System.Drawing.Size(142, 41);
               this.GuardarB.TabIndex = 21;
               this.GuardarB.UseVisualStyleBackColor = true;
               this.GuardarB.Click += new System.EventHandler(this.GuardarB_Click);
               // 
               // EliminarC
               // 
               this.EliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.EliminarC.Image = global::FitnessSportGym.Properties.Resources.EliminarB;
               this.EliminarC.Location = new System.Drawing.Point(476, 176);
               this.EliminarC.Name = "EliminarC";
               this.EliminarC.Size = new System.Drawing.Size(142, 41);
               this.EliminarC.TabIndex = 6;
               this.EliminarC.UseVisualStyleBackColor = true;
               this.EliminarC.Click += new System.EventHandler(this.EliminarC_Click);
               // 
               // CapturarC
               // 
               this.CapturarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.CapturarC.Image = global::FitnessSportGym.Properties.Resources.CapturarB;
               this.CapturarC.Location = new System.Drawing.Point(476, 123);
               this.CapturarC.Name = "CapturarC";
               this.CapturarC.Size = new System.Drawing.Size(142, 41);
               this.CapturarC.TabIndex = 5;
               this.CapturarC.UseVisualStyleBackColor = true;
               this.CapturarC.Click += new System.EventHandler(this.CapturarC_Click);
               // 
               // IniciarC
               // 
               this.IniciarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.IniciarC.Image = global::FitnessSportGym.Properties.Resources.IniciarB;
               this.IniciarC.Location = new System.Drawing.Point(475, 71);
               this.IniciarC.Name = "IniciarC";
               this.IniciarC.Size = new System.Drawing.Size(142, 41);
               this.IniciarC.TabIndex = 4;
               this.IniciarC.UseVisualStyleBackColor = true;
               this.IniciarC.Click += new System.EventHandler(this.IniciarC_Click);
               // 
               // pictureBox3
               // 
               this.pictureBox3.Location = new System.Drawing.Point(247, 16);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(200, 200);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox3.TabIndex = 2;
               this.pictureBox3.TabStop = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo1;
               this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBox1.Location = new System.Drawing.Point(1, 1);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(651, 692);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // videoSourcePlayer1
               // 
               this.videoSourcePlayer1.Location = new System.Drawing.Point(21, 17);
               this.videoSourcePlayer1.Name = "videoSourcePlayer1";
               this.videoSourcePlayer1.Size = new System.Drawing.Size(200, 200);
               this.videoSourcePlayer1.TabIndex = 22;
               this.videoSourcePlayer1.Text = "videoSourcePlayer1";
               this.videoSourcePlayer1.VideoSource = null;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.BackColor = System.Drawing.Color.Transparent;
               this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.Location = new System.Drawing.Point(405, 240);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(65, 22);
               this.label8.TabIndex = 23;
               this.label8.Text = "Fecha";
               // 
               // fecha
               // 
               this.fecha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.fecha.Location = new System.Drawing.Point(400, 268);
               this.fecha.Name = "fecha";
               this.fecha.Size = new System.Drawing.Size(234, 32);
               this.fecha.TabIndex = 24;
               this.fecha.Value = new System.DateTime(2014, 12, 1, 18, 31, 47, 0);
               // 
               // entrenador
               // 
               this.entrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.entrenador.Location = new System.Drawing.Point(400, 331);
               this.entrenador.Name = "entrenador";
               this.entrenador.Size = new System.Drawing.Size(234, 245);
               this.entrenador.TabIndex = 25;
               this.entrenador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.entrenador_CellClick);
               this.entrenador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.entrenador_CellContentClick);
               // 
               // AgregarClientes
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ClientSize = new System.Drawing.Size(653, 687);
               this.Controls.Add(this.entrenador);
               this.Controls.Add(this.fecha);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.videoSourcePlayer1);
               this.Controls.Add(this.GuardarB);
               this.Controls.Add(this.IdCT);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.IdET);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.CorreoT);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.TelT);
               this.Controls.Add(this.NomT);
               this.Controls.Add(this.ApepT);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.ApemT);
               this.Controls.Add(this.EliminarC);
               this.Controls.Add(this.CapturarC);
               this.Controls.Add(this.IniciarC);
               this.Controls.Add(this.CamBox);
               this.Controls.Add(this.pictureBox3);
               this.Controls.Add(this.pictureBox1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "AgregarClientes";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarClientes_FormClosing);
               this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarClientes_FormClosed);
               this.Load += new System.EventHandler(this.AgregarClientes_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.entrenador)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox CamBox;
        private System.Windows.Forms.Button IniciarC;
        private System.Windows.Forms.Button CapturarC;
        private System.Windows.Forms.Button EliminarC;
        private System.Windows.Forms.TextBox ApepT;
        private System.Windows.Forms.TextBox ApemT;
        private System.Windows.Forms.TextBox TelT;
        private System.Windows.Forms.TextBox CorreoT;
        private System.Windows.Forms.TextBox IdCT;
        private System.Windows.Forms.TextBox IdET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GuardarB;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DataGridView entrenador;
        public System.Windows.Forms.TextBox NomT;
    }
}