using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;//Libreraria para manejar las bases de datos

namespace Labtec
{
    public class ConexionBD
    {
        //Declaramos Objeto para realizar la conexion con la base de datos
        public SqlConnection Conexion = new SqlConnection(
            "Data Source=DESKTOP-EOJJH72\\SQLEXPRESS;Initial Catalog=LabTec;Integrated Security=True");
    }
}
