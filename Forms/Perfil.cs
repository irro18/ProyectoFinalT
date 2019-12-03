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

namespace TwitterClone.Forms
{
    public partial class Perfil : Form
    {
        //public Perfil()
        //{
        //    InitializeComponent();
        //}

        private void BotonAtrasAHome_Click(object sender, EventArgs e)
        {
            Home miForm1 = new Home();
            this.Hide();

            miForm1.ShowDialog(this);
            this.Dispose();

        }

        /// <summary>
        /// Sacar datos de Base de Datos
        /// </summary>

        public readonly SqlClient _clientazo;
        private readonly string SQLConnection;

        private Perfil(string connectionString)
        {
            _clientazo = new SqlClient(connectionString);
        }
        private static UsuarioService _service;
        public Perfil()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new UsuarioService(connectionString);

            cargar();
            
        }
        public void cargar()
        {
            
            string SQLConnection = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            using (SqlConnection _clientazo = new SqlConnection(SQLConnection))

                try
                {


                    _clientazo.Open();
                    SqlDataReader myReader = null;
                    SqlCommand cmd = new SqlCommand("SELECT Nombre FROM Userr", _clientazo);

                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        labelNombreUsuario.Text = "Bienvenido";
                        //Entrar.logged_username;
                        //myReader["Nombre"].ToString();
                        //logged_ciudad = textBoxCiudadRegistro.Text;
                        //logged_descrip = textBoxDescripc.Text;
                        //logged_nac = textBoxFechaRegistro.Text;
                        //logged_regis = DateTime.Now;
                        //Entrar.logged_username = Jalar(Usuario);
                        //Entrar.logged_username = 
                        labelUserName.Text = Entrar.logged_username;
                        labelCiudad.Text = Entrar.logged_ciudad;
                        labelDescripcion.Text = Entrar.logged_descrip;
                        //labelFechaDeNac.Text = Entrar.logged_nac;
                        //labelFechaDeRegistro.Text = Entrar.logged_regis.ToString();

                    }

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

        //            while (dataReader.Read())
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
        //}

    }
}
