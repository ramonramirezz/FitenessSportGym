namespace FitnessSportGym
{
     partial class Buscador
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.NumC = new System.Windows.Forms.TextBox();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.cliente = new System.Windows.Forms.DataGridView();
               this.Reloj = new System.Windows.Forms.Label();
               this.timer1 = new System.Windows.Forms.Timer(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.cliente)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::FitnessSportGym.Properties.Resources.Fondo;
               this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(824, 299);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // NumC
               // 
               this.NumC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.NumC.Location = new System.Drawing.Point(76, 234);
               this.NumC.Name = "NumC";
               this.NumC.Size = new System.Drawing.Size(168, 35);
               this.NumC.TabIndex = 3;
               this.NumC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumC_KeyPress);
               // 
               // pictureBox2
               // 
               this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
               this.pictureBox2.Image = global::FitnessSportGym.Properties.Resources.User;
               this.pictureBox2.Location = new System.Drawing.Point(30, 229);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(40, 40);
               this.pictureBox2.TabIndex = 7;
               this.pictureBox2.TabStop = false;
               // 
               // cliente
               // 
               this.cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.cliente.Location = new System.Drawing.Point(258, 181);
               this.cliente.Name = "cliente";
               this.cliente.Size = new System.Drawing.Size(529, 88);
               this.cliente.TabIndex = 8;
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
               this.Reloj.Location = new System.Drawing.Point(317, 79);
               this.Reloj.Name = "Reloj";
               this.Reloj.Size = new System.Drawing.Size(300, 75);
               this.Reloj.TabIndex = 10;
               this.Reloj.Text = "00:00:00";
               // 
               // timer1
               // 
               this.timer1.Enabled = true;
               this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // Buscador
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(799, 292);
               this.Controls.Add(this.Reloj);
               this.Controls.Add(this.cliente);
               this.Controls.Add(this.pictureBox2);
               this.Controls.Add(this.NumC);
               this.Controls.Add(this.pictureBox1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "Buscador";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Load += new System.EventHandler(this.Buscador_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.cliente)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.TextBox NumC;
          private System.Windows.Forms.PictureBox pictureBox2;
          private System.Windows.Forms.DataGridView cliente;
          private System.Windows.Forms.Label Reloj;
          private System.Windows.Forms.Timer timer1;

     }
}