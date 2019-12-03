using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterClone.Services;
using TwitterClone.SQL;
using TwitterClone.Forms;


namespace TwitterClone.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ButtonIrPerfil_Click(object sender, EventArgs e)
        {
            //Perfil miForm1 = new Perfil();
            //this.Hide();

            //miForm1.ShowDialog(this);
            //this.Dispose();
            Perfil miForm1 = new Perfil();
            this.Hide();

            miForm1.ShowDialog(this);
            this.Dispose();

        }

        private void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Login miForm1 = new Login();
            this.Hide();

            miForm1.ShowDialog(this);
            this.Dispose();
        }
    }
}
