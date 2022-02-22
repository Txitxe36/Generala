
namespace Generala
{
    partial class Jugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lblUsu1 = new System.Windows.Forms.Label();
            this.lblUsu2 = new System.Windows.Forms.Label();
            this.txtUsu1 = new System.Windows.Forms.TextBox();
            this.txtUsu2 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmpezar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEmpezar.FlatAppearance.BorderSize = 4;
            this.btnEmpezar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnEmpezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezar.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.Color.Blue;
            this.btnEmpezar.Location = new System.Drawing.Point(304, 381);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(155, 57);
            this.btnEmpezar.TabIndex = 1;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lblUsu1
            // 
            this.lblUsu1.AutoSize = true;
            this.lblUsu1.BackColor = System.Drawing.Color.Transparent;
            this.lblUsu1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUsu1.Location = new System.Drawing.Point(85, 251);
            this.lblUsu1.Name = "lblUsu1";
            this.lblUsu1.Size = new System.Drawing.Size(124, 29);
            this.lblUsu1.TabIndex = 2;
            this.lblUsu1.Text = "jugador 1";
            // 
            // lblUsu2
            // 
            this.lblUsu2.AutoSize = true;
            this.lblUsu2.BackColor = System.Drawing.Color.Transparent;
            this.lblUsu2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUsu2.Location = new System.Drawing.Point(575, 251);
            this.lblUsu2.Name = "lblUsu2";
            this.lblUsu2.Size = new System.Drawing.Size(124, 29);
            this.lblUsu2.TabIndex = 3;
            this.lblUsu2.Text = "jugador 2";
            // 
            // txtUsu1
            // 
            this.txtUsu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu1.Location = new System.Drawing.Point(68, 298);
            this.txtUsu1.MaximumSize = new System.Drawing.Size(157, 50);
            this.txtUsu1.MinimumSize = new System.Drawing.Size(140, 30);
            this.txtUsu1.Name = "txtUsu1";
            this.txtUsu1.Size = new System.Drawing.Size(157, 31);
            this.txtUsu1.TabIndex = 4;
            this.txtUsu1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsu2
            // 
            this.txtUsu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu2.Location = new System.Drawing.Point(558, 298);
            this.txtUsu2.MaximumSize = new System.Drawing.Size(157, 50);
            this.txtUsu2.MinimumSize = new System.Drawing.Size(140, 30);
            this.txtUsu2.Name = "txtUsu2";
            this.txtUsu2.Size = new System.Drawing.Size(157, 31);
            this.txtUsu2.TabIndex = 5;
            this.txtUsu2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(628, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "VOLVER AL INICIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtUsu2);
            this.Controls.Add(this.txtUsu1);
            this.Controls.Add(this.lblUsu2);
            this.Controls.Add(this.lblUsu1);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERALA DE MIGUEL GARCÍA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label lblUsu1;
        private System.Windows.Forms.Label lblUsu2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtUsu1;
        private System.Windows.Forms.TextBox txtUsu2;
        private System.Windows.Forms.Button button1;
    }
}