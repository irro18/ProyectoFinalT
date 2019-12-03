using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterClone.SQL;
using TwitterClone.Forms;

namespace TwitterClone
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BotonRegistro_Click(object sender, EventArgs e)
        {
            Registro miForm1 = new Registro();
            this.Hide();

            miForm1.ShowDialog(this);
            this.Dispose();
        }

        private void BotonLogin_Click(object sender, EventArgs e)
        {
            Entrar miForm1 = new Entrar();
            this.Hide();

            miForm1.ShowDialog(this);
            this.Dispose();

            
        }
    }
}
