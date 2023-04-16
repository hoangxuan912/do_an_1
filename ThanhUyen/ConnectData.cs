using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhUyen
{
    internal class ConnectData
    {
         
        public SqlConnection Conn = new SqlConnection();
        public SqlCommand sqlCon = new SqlCommand();

        public string StrConn = "Data Source=DSA;Initial Catalog=quanlikho;Integrated Security=True";
        public void Conect_QLT()
        {
            Conn = new SqlConnection(StrConn);
            Conn.Open();

        }
        public DataTable layDl(string Caulenhtruyvan)
        {
            DataTable Dt = new DataTable();
            sqlCon = new SqlCommand(Caulenhtruyvan, Conn);
            SqlDataAdapter dtat = new SqlDataAdapter(sqlCon);
            dtat.Fill(Dt);
            return Dt;

        }
        public void CapnhatDl(string CauLenhCapNhat)
        {
            sqlCon = new SqlCommand(CauLenhCapNhat, Conn);
            sqlCon.ExecuteNonQuery();
        }
    }
}

