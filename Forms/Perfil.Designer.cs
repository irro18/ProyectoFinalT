namespace TwitterClone.Forms
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.botonAtrasAHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelFechaDeNac = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelFechaDeRegistro = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(285, 23);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(129, 25);
            this.labelNombreUsuario.TabIndex = 2;
            this.labelNombreUsuario.Text = "Bienvenido";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(156, 95);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(214, 25);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Nombre de Usuario";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.BackColor = System.Drawing.Color.White;
            this.labelCiudad.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCiudad.Location = new System.Drawing.Point(181, 161);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(129, 15);
            this.labelCiudad.TabIndex = 4;
            this.labelCiudad.Text = "Ciudad de Nacimiento";
            //this.labelCiudad.Click += new System.EventHandler(this.LabelCiudad_Click);
            // 
            // botonAtrasAHome
            // 
            this.botonAtrasAHome.BackColor = System.Drawing.Color.White;
            this.botonAtrasAHome.BackgroundImage = global::TwitterClone.Properties.Resources.atrásssss;
            this.botonAtrasAHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonAtrasAHome.Location = new System.Drawing.Point(234, 12);
            this.botonAtrasAHome.Name = "botonAtrasAHome";
            this.botonAtrasAHome.Size = new System.Drawing.Size(45, 45);
            this.botonAtrasAHome.TabIndex = 1;
            this.botonAtrasAHome.UseVisualStyleBackColor = false;
            this.botonAtrasAHome.Click += new System.EventHandler(this.BotonAtrasAHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TwitterClone.Properties.Resources.ub1;
            this.pictureBox1.Location = new System.Drawing.Point(161, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TwitterClone.Properties.Resources.fecha1;
            this.pictureBox2.Location = new System.Drawing.Point(161, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // labelFechaDeNac
            // 
            this.labelFechaDeNac.AutoSize = true;
            this.labelFechaDeNac.BackColor = System.Drawing.Color.White;
            this.labelFechaDeNac.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFechaDeNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDeNac.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFechaDeNac.Location = new System.Drawing.Point(181, 190);
            this.labelFechaDeNac.Name = "labelFechaDeNac";
            this.labelFechaDeNac.Size = new System.Drawing.Size(124, 15);
            this.labelFechaDeNac.TabIndex = 6;
            this.labelFechaDeNac.Text = "Fecha de Nacimiento";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TwitterClone.Properties.Resources.registro;
            this.pictureBox3.Location = new System.Drawing.Point(161, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // labelFechaDeRegistro
            // 
            this.labelFechaDeRegistro.AutoSize = true;
            this.labelFechaDeRegistro.BackColor = System.Drawing.Color.White;
            this.labelFechaDeRegistro.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFechaDeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDeRegistro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFechaDeRegistro.Location = new System.Drawing.Point(181, 219);
            this.labelFechaDeRegistro.Name = "labelFechaDeRegistro";
            this.labelFechaDeRegistro.Size = new System.Drawing.Size(103, 15);
            this.labelFechaDeRegistro.TabIndex = 8;
            this.labelFechaDeRegistro.Text = "Fecha de Registo";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(158, 131);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(157, 16);
            this.labelDescripcion.TabIndex = 10;
            this.labelDescripcion.Text = "Descripción del Usuario";
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelFechaDeRegistro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelFechaDeNac);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.botonAtrasAHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perfil";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAtrasAHome;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelFechaDeNac;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelFechaDeRegistro;
        private System.Windows.Forms.Label labelDescripcion;
    }
}