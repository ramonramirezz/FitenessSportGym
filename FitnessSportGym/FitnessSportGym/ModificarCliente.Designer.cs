namespace FitnessSportGym
{
     partial class ModificarCliente
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
               this.entrenador = new System.Windows.Forms.DataGridView();
               this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
               this.IdCT = new System.Windows.Forms.TextBox();
               this.label7 = new System.Windows.Forms.Label();
               this.IdET = new System.Windows.Forms.TextBox();
               this.label6 = new System.Windows.Forms.Label();
               this.CorreoT = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.TelT = new System.Windows.Forms.TextBox();
               this.NomT = new System.Windows.Forms.TextBox();
               this.ApepT = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.CamBox = new System.Windows.Forms.ComboBox();
               this.GuardarB = new System.Windows.Forms.Button();
               this.EliminarC = new System.Windows.Forms.Button();
               this.CapturarC = new System.Windows.Forms.Button();
               this.IniciarC = new System.Windows.Forms.Button();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.comboBox1 = new System.Windows.Forms.ComboBox();
               ((System.ComponentModel.ISupportInitialize)(this.entrenador)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // entrenador
               // 
               this.entrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.entrenador.Location = new System.Drawing.Point(374, 305);
               this.entrenador.Name = "entrenador";
               this.entrenador.Size = new System.Drawing.Size(234, 245);
               this.entrenador.TabIndex = 50;
               this.entrenador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.entrenador_CellClick);
               // 
               // videoSourcePlayer1
               // 
               this.videoSourcePlayer1.Location = new System.Drawing.Point(12, 29);
               this.videoSourcePlayer1.Name = "videoSourcePlayer1";
               this.videoSourcePlayer1.Size = new System.Drawing.Size(200, 200);
               this.videoSourcePlayer1.TabIndex = 47;
               this.videoSourcePlayer1.Text = "videoSourcePlayer1";
               this.videoSourcePlayer1.VideoSource = null;
               // 
               // IdCT
               // 
               this.IdCT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.IdCT.Location = new System.Drawing.Point(12, 536);
               this.IdCT.Name = "IdCT";
               this.IdCT.Size = new System.Drawing.Size(250, 35);
               this.IdCT.TabIndex = 37;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.BackColor = System.Drawing.Color.LightGray;
               this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(12, 574);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(135, 22);
               this.label7.TabIndex = 45;
               this.label7.Text = "Entrenador id";
               // 
               // IdET
               // 
               this.IdET.Enabled = false;
               this.IdET.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.IdET.Location = new System.Drawing.Point(12, 599);
               this.IdET.Name = "IdET";
               this.IdET.Size = new System.Drawing.Size(250, 35);
               this.IdET.TabIndex = 38;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.BackColor = System.Drawing.Color.LightGray;
               this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(12, 511);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(96, 22);
               this.label6.TabIndex = 44;
               this.label6.Text = "Cliente id";
               // 
               // CorreoT
               // 
               this.CorreoT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.CorreoT.Location = new System.Drawing.Point(12, 473);
               this.CorreoT.Name = "CorreoT";
               this.CorreoT.Size = new System.Drawing.Size(250, 35);
               this.CorreoT.TabIndex = 36;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.BackColor = System.Drawing.Color.LightGray;
               this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(12, 448);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(73, 22);
               this.label5.TabIndex = 43;
               this.label5.Text = "Correo";
               // 
               // TelT
               // 
               this.TelT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.TelT.Location = new System.Drawing.Point(12, 410);
               this.TelT.Name = "TelT";
               this.TelT.Size = new System.Drawing.Size(250, 35);
               this.TelT.TabIndex = 35;
               // 
               // NomT
               // 
               this.NomT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.NomT.Location = new System.Drawing.Point(12, 286);
               this.NomT.Name = "NomT";
               this.NomT.Size = new System.Drawing.Size(250, 35);
               this.NomT.TabIndex = 32;
               // 
               // ApepT
               // 
               this.ApepT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ApepT.Location = new System.Drawing.Point(12, 347);
               this.ApepT.Name = "ApepT";
               this.ApepT.Size = new System.Drawing.Size(250, 35);
               this.ApepT.TabIndex = 33;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.LightGray;
               this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(12, 385);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(88, 22);
               this.label4.TabIndex = 42;
               this.label4.Text = "Telefono";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.LightGray;
               this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(12, 322);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(162, 22);
               this.label2.TabIndex = 40;
               this.label2.Text = "Apellido Paterno";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.LightGray;
               this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(12, 261);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(83, 22);
               this.label1.TabIndex = 39;
               this.label1.Text = "Nombre";
               // 
               // CamBox
               // 
               this.CamBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.CamBox.FormattingEnabled = true;
               this.CamBox.Location = new System.Drawing.Point(394, -71);
               this.CamBox.Name = "CamBox";
               this.CamBox.Size = new System.Drawing.Size(151, 26);
               this.CamBox.TabIndex = 28;
               // 
               // GuardarB
               // 
               this.GuardarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.GuardarB.Image = global::FitnessSportGym.Properties.Resources.GuardarB;
               this.GuardarB.Location = new System.Drawing.Point(413, 574);
               this.GuardarB.Name = "GuardarB";
               this.GuardarB.Size = new System.Drawing.Size(142, 41);
               this.GuardarB.TabIndex = 46;
               this.GuardarB.UseVisualStyleBackColor = true;
               this.GuardarB.Click += new System.EventHandler(this.GuardarB_Click);
               // 
               // EliminarC
               // 
               this.EliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.EliminarC.Image = global::FitnessSportGym.Properties.Resources.EliminarB;
               this.EliminarC.Location = new System.Drawing.Point(476, 188);
               this.EliminarC.Name = "EliminarC";
               this.EliminarC.Size = new System.Drawing.Size(142, 41);
               this.EliminarC.TabIndex = 31;
               this.EliminarC.UseVisualStyleBackColor = true;
               this.EliminarC.Click += new System.EventHandler(this.EliminarC_Click);
               // 
               // CapturarC
               // 
               this.CapturarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.CapturarC.Image = global::FitnessSportGym.Properties.Resources.CapturarB;
               this.CapturarC.Location = new System.Drawing.Point(476, 129);
               this.CapturarC.Name = "CapturarC";
               this.CapturarC.Size = new System.Drawing.Size(142, 41);
               this.CapturarC.TabIndex = 30;
               this.CapturarC.UseVisualStyleBackColor = true;
               this.CapturarC.Click += new System.EventHandler(this.CapturarC_Click);
               // 
               // IniciarC
               // 
               this.IniciarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.IniciarC.Image = global::FitnessSportGym.Properties.Resources.IniciarB;
               this.IniciarC.Location = new System.Drawing.Point(476, 73);
               this.IniciarC.Name = "IniciarC";
               this.IniciarC.Size = new System.Drawing.Size(142, 41);
               this.IniciarC.TabIndex = 29;
               this.IniciarC.UseVisualStyleBackColor = true;
               this.IniciarC.Click += new System.EventHandler(this.IniciarC_Click);
               // 
               // pictureBox3
               // 
               this.pictureBox3.Location = new System.Drawing.Point(248, 29);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(200, 200);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox3.TabIndex = 27;
               this.pictureBox3.TabStop = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackgroundImage = global::FitnessSportGym.Properties.Resources.Fondo1;
               this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBox1.Location = new System.Drawing.Point(-3, -82);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(651, 830);
               this.pictureBox1.TabIndex = 26;
               this.pictureBox1.TabStop = false;
               // 
               // comboBox1
               // 
               this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.comboBox1.FormattingEnabled = true;
               this.comboBox1.Location = new System.Drawing.Point(468, 29);
               this.comboBox1.Name = "comboBox1";
               this.comboBox1.Size = new System.Drawing.Size(150, 26);
               this.comboBox1.TabIndex = 51;
               this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
               // 
               // ModificarCliente
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(641, 647);
               this.Controls.Add(this.comboBox1);
               this.Controls.Add(this.entrenador);
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
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.EliminarC);
               this.Controls.Add(this.CapturarC);
               this.Controls.Add(this.IniciarC);
               this.Controls.Add(this.CamBox);
               this.Controls.Add(this.pictureBox3);
               this.Controls.Add(this.pictureBox1);
               this.MaximizeBox = false;
               this.Name = "ModificarCliente";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarCliente_FormClosing);
               this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModificarCliente_FormClosed);
               this.Load += new System.EventHandler(this.ModificarCliente_Load);
               ((System.ComponentModel.ISupportInitialize)(this.entrenador)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label5;
          public System.Windows.Forms.TextBox NomT;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button EliminarC;
          private System.Windows.Forms.Button CapturarC;
          private System.Windows.Forms.Button IniciarC;
          private System.Windows.Forms.ComboBox CamBox;
          private System.Windows.Forms.PictureBox pictureBox1;
          public System.Windows.Forms.DataGridView entrenador;
          public System.Windows.Forms.TextBox IdCT;
          public System.Windows.Forms.TextBox IdET;
          public System.Windows.Forms.TextBox CorreoT;
          public System.Windows.Forms.TextBox TelT;
          public System.Windows.Forms.TextBox ApepT;
          public System.Windows.Forms.PictureBox pictureBox3;
          private System.Windows.Forms.ComboBox comboBox1;
          public System.Windows.Forms.Button GuardarB;


     }
}