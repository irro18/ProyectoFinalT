using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TwitterClone.SQL;
using TwitterClone.Services;
using System.Configuration;
using TwitterClone;

namespace TwitterClone.Forms
{
    public partial class Entrar : Form
    {
        //public Entrar()
        //{
        //    InitializeComponent();
        //}

        public readonly  SqlClient _clientazo;
        private readonly string SQLConnection;
        public static string logged_username;
        public static string logged_ciudad;
        public static string logged_regist;
        public static string logged_descrip;
        public static DateTime logged_nac;
        public static DateTime logged_regis;

        Usuario usuarioActual;


        private Entrar(string connectionString)
        {
            _clientazo = new SqlClient(connectionString);
        }

        private static UsuarioService _service;
        public Entrar()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new UsuarioService(connectionString);
        }

        public void log()
        {
            try
            {
                string SQLConnection = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
                using (SqlConnection _clientazo = new SqlConnection(SQLConnection))

                {
                    _clientazo.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre, Correo, Contraseña FROM Userr WHERE Nombre='" + textBoxNameLog.Text + "' AND Correo='" + textBoxEmailLog.Text + "' AND Contraseña='" + textBoxContraseñaLog.Text + "'", _clientazo))

                    {
                        
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            usuarioActual = _service.Jalar(textBoxNameLog.Text);
                            //usuarioActual = textBoxNameLog.Text;
                            logged_username = textBoxNameLog.Text;
                            logged_descrip = usuarioActual.Decripc;
                            logged_ciudad = "Aguascalientes";
                            //MessageBox.Show("Des", usuarioActual.Decripc);
                            //MessageBox.Show("Ciu", usuarioActual.Ciudad);
                            Home miForm1 = new Home();
                            this.Hide();

                            miForm1.ShowDialog(this);
                            this.Dispose();
                            //usuarioActual = _service.Jalar(textBoxNameLog.Text);
                            //logged_username = textBoxNameLog.Text;
                            //logged_descrip = usuarioActual.Decripc;
                            //logged_ciudad = usuarioActual.Ciudad;
                            //MessageBox.Show("Login exitoso.");
                            //MessageBox.Show("Des", usuarioActual.Decripc);
                            //MessageBox.Show("Ciu", usuarioActual.Ciudad);
                            
                        }
                        else
                        {
                            MessageBox.Show("Los datos son incorrectos. Por favor, vuelva a intentarlo.");
                        }
                    }
                    
                }
                //usuarioActual = _service.Jalar(textBoxNameLog.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        //public string Jalar(string Nombre)
        //{
        //    Usuario aux = new Usuario();
        //    //string Nombre;
        //    try
        //    {
        //        if (_clientazo.Open())
        //        {
        //            var command = new SqlCommand
        //            {
        //                Connection = _clientazo.Connection,
        //                CommandText = "jalarDatos",
        //                CommandType = CommandType.StoredProcedure
        //            };

        //            var par1 = new SqlParameter("@Nombre", SqlDbType.NVarChar)
        //            {
        //                Direction = ParameterDirection.Input,
        //                Value = Nombre
        //            };

        //            var par2 = new SqlParameter("@hasError", SqlDbType.Bit)
        //            {
        //                Direction = ParameterDirection.Output
        //            };

        //            command.Parameters.Add(par1);
        //            command.Parameters.Add(par2);

        //            var dataReader = command.ExecuteReader();

        //            while(dataReader.Read())
        //            {
        //                var Usuario = new Usuario
        //                {
        //                    Nombre = dataReader["Nombre"].ToString(),
        //                    Ciudad = dataReader["Ciudad"].ToString(),
        //                    FechaDeNac = dataReader["FechaDeNac"].ToString(),
        //                    FechaRegistro = Convert.ToDateTime(dataReader["FechaDeNac"].ToString()),
        //                    Decripc = dataReader["Descrip"].ToString()

        //                };

        //                aux = Usuario;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        //ignored
        //    }
        //    finally
        //    {
        //        _clientazo.Close();
        //    }
        //    return aux.Nombre;  
        // }

    private void Button1_Click(object sender, EventArgs e)
        {

            //logged_username = textBoxNameLog.Text;
            //logged_descrip = usuarioActual.Decripc;
            //logged_ciudad = usuarioActual.Ciudad;
            //logged_regis = usuarioActual.FechaRegistro.ToString();
            //logged_nac = usuarioActual.FechaDeNac.ToString();

            log();
        }
    }
}

