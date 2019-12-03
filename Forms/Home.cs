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
        public readonly SqlClient _clientazo;
        private readonly string SQLConnection;

        public Home()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
        }

        private Home(string connectionString)
        {
            _clientazo = new SqlClient(connectionString);
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

        //private void Home_Load(object sender, EventArgs e)
        //{
        //    List<string> tweets = new List<string>();
        //    try
        //    {
        //        string SQLConnection = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
        //        using (SqlConnection _clientazo = new SqlConnection(SQLConnection))
        //        {
        //            _clientazo.Open();
        //            using (SqlCommand cmd = new SqlCommand("exec dbo.getTweets" + "'", _clientazo))

        //            {

        //                SqlDataReader dr = cmd.ExecuteReader();
        //                if (dr.Read())
        //                {

        //                    var command = new SqlCommand
        //                    //{
        //                    //    Connection = _clientazo.Connection,
        //                    //    CommandText = "getTweets",
        //                    //    CommandType = CommandType.StoredProcedure
        //                    //};

        //                    //var par1 = new SqlParameter("@haserror", SqlDbType.Bit)
        //                    //{
        //                    //    Direction = ParameterDirection.Output
        //                    //};

        //                    //command.Parameters.Add(par1);
        //                    var dataReader = command.ExecuteReader();
        //                    while (dataReader.Read())
        //                    {
        //                        var tweetaux = new tweet { tweets.Add(dataReader["texto"].ToString());
        //                    //}

        //                    //var dataReader2 = command.ExecuteReader();
        //                    //while (dataReader.Read())
        //                    //{
        //                        var tweetaux = new tweet { tweets.Add(dataReader["ubicacion"].ToString());
        //                    //}

        //                    //var dataReader3 = command.ExecuteReader();
        //                    //while (dataReader.Read())
        //                    //{
        //                        var tweetaux = new tweet { tweets.Add(dataReader["hora"].ToString());
        //                    //}

        //                    //var dataReader4 = command.ExecuteReader();
        //                    //while (dataReader.Read())
        //                    //{
        //                        var tweetaux = new tweet { tweets.Add(dataReader["likes"].ToString());
        //                    }
        //                    listatweet.Add(tweetaux);
        //                }
        //            }
        //        }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private void BotonTwittear_Click(object sender, EventArgs e)
        {
            using (SqlConnection _clientazo = new SqlConnection("SQLConnection"))
            {
                _clientazo.Open();
                string query = "INSERT into tweet(texto) values (@texto)";
                SqlCommand cmd = new SqlCommand(query, _clientazo);

                cmd.Parameters.AddWithValue("@texto", textBoxtweet.Text);
                cmd.ExecuteNonQuery();
            }
                
           
        }
    }
}
