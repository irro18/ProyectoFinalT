namespace TwitterClone.Forms
{
    partial class Entrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameLog = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEmailLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar sesión en Twitter";
            // 
            // textBoxNameLog
            // 
            this.textBoxNameLog.BackColor = System.Drawing.Color.White;
            this.textBoxNameLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameLog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxNameLog.Location = new System.Drawing.Point(30, 183);
            this.textBoxNameLog.Name = "textBoxNameLog";
            this.textBoxNameLog.Size = new System.Drawing.Size(259, 18);
            this.textBoxNameLog.TabIndex = 1;
            this.textBoxNameLog.Text = "Nombre";
            // 
            // textBoxContraseñaLog
            // 
            this.textBoxContraseñaLog.BackColor = System.Drawing.Color.White;
            this.textBoxContraseñaLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaLog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxContraseñaLog.Location = new System.Drawing.Point(30, 247);
            this.textBoxContraseñaLog.Name = "textBoxContraseñaLog";
            this.textBoxContraseñaLog.Size = new System.Drawing.Size(259, 18);
            this.textBoxContraseñaLog.TabIndex = 2;
            this.textBoxContraseñaLog.Text = "Contraseña";
            this.textBoxContraseñaLog.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TwitterClone.Properties.Resources.Twitter;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxEmailLog
            // 
            this.textBoxEmailLog.BackColor = System.Drawing.Color.White;
            this.textBoxEmailLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailLog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxEmailLog.Location = new System.Drawing.Point(30, 216);
            this.textBoxEmailLog.Name = "textBoxEmailLog";
            this.textBoxEmailLog.Size = new System.Drawing.Size(259, 18);
            this.textBoxEmailLog.TabIndex = 5;
            this.textBoxEmailLog.Text = "Correo";
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.textBoxEmailLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxContraseñaLog);
            this.Controls.Add(this.textBoxNameLog);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrar";
            this.Text = "Entrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameLog;
        private System.Windows.Forms.TextBox textBoxContraseñaLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxEmailLog;
    }
}