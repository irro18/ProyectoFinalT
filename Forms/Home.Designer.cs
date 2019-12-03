namespace TwitterClone.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonTwittear = new System.Windows.Forms.Button();
            this.botonFeed = new System.Windows.Forms.Button();
            this.buttonIrPerfil = new System.Windows.Forms.Button();
            this.buttonTwittear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(167, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 18);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "¿Qué está pasando?";
            // 
            // botonTwittear
            // 
            this.botonTwittear.BackColor = System.Drawing.Color.DodgerBlue;
            this.botonTwittear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonTwittear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTwittear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonTwittear.ForeColor = System.Drawing.Color.White;
            this.botonTwittear.Location = new System.Drawing.Point(326, 79);
            this.botonTwittear.Name = "botonTwittear";
            this.botonTwittear.Size = new System.Drawing.Size(86, 23);
            this.botonTwittear.TabIndex = 2;
            this.botonTwittear.Text = "Twittear";
            this.botonTwittear.UseVisualStyleBackColor = false;
            // 
            // botonFeed
            // 
            this.botonFeed.BackColor = System.Drawing.Color.Transparent;
            this.botonFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFeed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botonFeed.Location = new System.Drawing.Point(12, 33);
            this.botonFeed.Name = "botonFeed";
            this.botonFeed.Size = new System.Drawing.Size(145, 23);
            this.botonFeed.TabIndex = 4;
            this.botonFeed.Text = "Inicio";
            this.botonFeed.UseVisualStyleBackColor = false;
            // 
            // buttonIrPerfil
            // 
            this.buttonIrPerfil.BackColor = System.Drawing.Color.Transparent;
            this.buttonIrPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIrPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIrPerfil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonIrPerfil.Location = new System.Drawing.Point(12, 62);
            this.buttonIrPerfil.Name = "buttonIrPerfil";
            this.buttonIrPerfil.Size = new System.Drawing.Size(145, 23);
            this.buttonIrPerfil.TabIndex = 5;
            this.buttonIrPerfil.Text = "Perfil";
            this.buttonIrPerfil.UseVisualStyleBackColor = false;
            this.buttonIrPerfil.Click += new System.EventHandler(this.ButtonIrPerfil_Click);
            // 
            // buttonTwittear
            // 
            this.buttonTwittear.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTwittear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTwittear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwittear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwittear.ForeColor = System.Drawing.Color.White;
            this.buttonTwittear.Location = new System.Drawing.Point(12, 120);
            this.buttonTwittear.Name = "buttonTwittear";
            this.buttonTwittear.Size = new System.Drawing.Size(145, 23);
            this.buttonTwittear.TabIndex = 6;
            this.buttonTwittear.Text = "Twittear";
            this.buttonTwittear.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TwitterClone.Properties.Resources.tend;
            this.pictureBox1.Location = new System.Drawing.Point(418, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(12, 91);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(145, 23);
            this.buttonCerrarSesion.TabIndex = 7;
            this.buttonCerrarSesion.Text = "Cerrar Sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.ButtonCerrarSesion_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 519);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonTwittear);
            this.Controls.Add(this.buttonIrPerfil);
            this.Controls.Add(this.botonFeed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonTwittear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonTwittear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonFeed;
        private System.Windows.Forms.Button buttonIrPerfil;
        private System.Windows.Forms.Button buttonTwittear;
        private System.Windows.Forms.Button buttonCerrarSesion;
    }
}