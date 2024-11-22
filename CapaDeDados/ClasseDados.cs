using CapaDeEntidade;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CapaDeDados
{
    public class ClasseDados
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable DLogin(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logar",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@senha", obje.senha);
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
