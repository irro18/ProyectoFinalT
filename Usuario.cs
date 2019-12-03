using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TwitterClone.SQL;

namespace TwitterClone
{
    public class Usuario
    {
        //public int id_usuario { set; get; }
        public string Nombre { set; get; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Ciudad { get; set; }
        public string FechaDeNac { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Decripc { get; set; }


        public Usuario Clone()
        {
            return new Usuario { Nombre = Nombre, Correo = Correo, Contraseña = Contraseña, Ciudad = Ciudad, FechaDeNac = FechaDeNac, FechaRegistro = FechaRegistro, Decripc = Decripc };
        }

        
    }
}
