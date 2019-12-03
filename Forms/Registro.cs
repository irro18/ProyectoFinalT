using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterClone.Services;


namespace TwitterClone
{
    public partial class Registro : Form
    {
        //public Registro()
        //{
        //    InitializeComponent();
        //}

        private static UsuarioService _service;
        //public static string logged_ciudad;
        //public static string logged_descrip;
        //public static string logged_nac;
        //public static DateTime logged_regis;
        public Registro()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new UsuarioService(connectionString);
        }

        private void Registrarr_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nombre = textBoxNombreRegistro.Text;
            usuario.Correo = textBoxCorreoRegistro.Text;
            usuario.Contraseña = textBoxContraseñaRegistro.Text;
            usuario.Ciudad = textBoxCiudadRegistro.Text;
            usuario.FechaDeNac = textBoxFechaRegistro.Text;
            usuario.FechaRegistro = DateTime.Now;
            usuario.Decripc = textBoxDescripc.Text;

            //usuario.Ciudad = logged_ciudad;
            //usuario.Decripc = logged_descrip;
            //usuario.FechaDeNac = logged_nac;
            //usuario.FechaRegistro = logged_regis;

            //logged_ciudad = usuario.Ciudad;
            //logged_descrip = usuario.Decripc;
            //logged_nac = usuario.FechaDeNac;
            //logged_regis = usuario.FechaRegistro;

            try
            {
                ///ignore
                ///
                MessageBox.Show("Registro exitoso! Vuelva a la pantalla Login");
                
            }
            catch
            {
                MessageBox.Show("Error en los datos.");
            }

            var result = _service.AddUsuerr(usuario);
            textBoxNombreRegistro.Text = "";
            textBoxCorreoRegistro.Text = "";
            textBoxContraseñaRegistro.Text = "";
            textBoxCiudadRegistro.Text = "";
            textBoxFechaRegistro.Text = "";
            textBoxDescripc.Text = "";

            //textBoxFechaDeRegistro.Text = DateTime.Now.Date;
            //logged_ciudad = textBoxCiudadRegistro.Text;
            //logged_descrip = textBoxDescripc.Text;
            //logged_nac = textBoxFechaRegistro.Text;
            //logged_regis = DateTime.Now;



            //public static string logged_descrip;
            //public static DateTime logged_nac;
            //public static DateTime logged_regis;
        }

        //public void GuardarDatos()
        //{
        //    logged_ciudad = textBoxCiudadRegistro.Text;
        //    logged_descrip = textBoxDescripc.Text;
        //    logged_nac = textBoxFechaRegistro.Text;
        //    logged_regis = DateTime.Now;
        //}



        private void BotonIrALogin_Click(object sender, EventArgs e)
        {
            Login miForm1 = new Login();
            this.Hide();

            miForm1.ShowDialog(this);
            this.Dispose();
        }
    }
           
}

