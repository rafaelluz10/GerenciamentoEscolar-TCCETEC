using CapaDeDados;
using CapaDeEntidade;
using System.Data;
using System.Text;


namespace CapaDeNegocio
{
    public class ClasseNegocio
    {
        ClasseDados clsdados = new ClasseDados();

        public string senha { get; set; }
        public string usuario { get; set; }

        public DataTable N_login(ClasseEntidade obje)
        {
            return clsdados.DLogin(obje);
        }
    }
}
