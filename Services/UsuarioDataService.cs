using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.SQL;

namespace TwitterClone.Services
{
    public class UsuarioDataService
    {
        public static UsuarioDataService _instance;
        private static readonly object _lock = new object();
        private readonly SqlClient _clientazo;

        public static UsuarioDataService GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UsuarioDataService(connectionString);
                    }
                }
            }
            return _instance;
        }

        private UsuarioDataService(string connectionString)
        {
            _clientazo = new SqlClient(connectionString);
        }

        public bool AddUsuerr(Usuario usuario)
        {
            var result = false;
            try
            {
                if (_clientazo.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _clientazo.Connection,
                        CommandText = "registroFinal",
                        CommandType = CommandType.StoredProcedure
                    };
                    var par1 = new SqlParameter("@Nombre", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.Nombre
                    };
                    var par2 = new SqlParameter("@Correo", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.Correo
                    };
                    var par3 = new SqlParameter("@Contraseña", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.Contraseña
                    };

                    var par4 = new SqlParameter("@Ciudad", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.Ciudad
                    };

                    var par5 = new SqlParameter("@Fecha", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.FechaDeNac
                    };

                    var par6 = new SqlParameter("@FechaRegistro", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.FechaRegistro
                    };
                    
                    var par7 = new SqlParameter("@Descripc", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usuario.Decripc
                    };

                    var par8 = new SqlParameter("@hasError", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);
                    command.Parameters.Add(par5);
                    command.Parameters.Add(par6);
                    command.Parameters.Add(par7);
                    command.Parameters.Add(par8);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@hasError"].Value.ToString());

                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _clientazo.Close();
            }
            return result;
        }


        public Usuario Jalar(string Nombre)
        {
            var result = new Usuario();
            //string Nombre;
            try
            {
                if (_clientazo.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _clientazo.Connection,
                        CommandText = "jalarDatos",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@Nombre", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = Nombre
                    };

                    var par2 = new SqlParameter("@hasError", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    

                    var dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        var usuario = new Usuario
                        {
                            Nombre = dataReader["Nombre"].ToString(),
                            Ciudad = dataReader["Ciudad"].ToString(),
                            FechaDeNac = dataReader["FechaDeNac"].ToString(),
                            FechaRegistro = Convert.ToDateTime(dataReader["FechaDeNac"].ToString()),
                            Decripc = dataReader["Descrip"].ToString()

                        };

                        result = usuario;
                    }
                }
            }
            catch
            {
                //ignored
            }
            finally
            {
                _clientazo.Close();
            }

            return result;

        }

        //public Usuario GetTweets()
        //{
        //    try
        //    {
        //        string SQLConnection = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
        //        using (SqlConnection _clientazo = new SqlConnection(SQLConnection))
        //        {
        //            _clientazo.Open();
        //            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tweets WHERE Nombre='" + "'", _clientazo))

        //            {

        //                SqlDataReader dr = cmd.ExecuteReader();
        //                if (dr.Read())
        //                {
                            
        //                    //var command = new SqlCommand
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
        //                    //var dataReader = command.ExecuteReader();
        //                    //while (dataReader.Read())
        //                    //{
        //                    //    tweets.Add(dataReader["Tweet"].ToString());
        //                    //}
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

    }
}
