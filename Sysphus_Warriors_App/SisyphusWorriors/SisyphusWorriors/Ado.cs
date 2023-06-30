using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SisyphusWorriors
{
    class Ado
    {

        // la declaration de connection  :
        public SqlConnection cnx = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public SqlDataReader dr2;

        public DataTable dt = new DataTable();
        public DataTable dt2 = new DataTable();


        //Mode Deconneter :
        SqlDataAdapter DA = new SqlDataAdapter();
        DataSet ds = new DataSet();
        // Connection State : 
        //methode Connecter :
        public void Connecter()
        {
            if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.ConnectionString = "Data Source=DESKTOP-TNU9JD7;Initial Catalog=SisyphusWarriors;Integrated Security=True";
                cnx.Open();
            }
        }

        //methode Deconnecter :
        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {             
                cnx.Close();
            }
        }
    }
}
