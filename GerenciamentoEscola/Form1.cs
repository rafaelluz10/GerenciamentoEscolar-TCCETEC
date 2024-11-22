using System.ComponentModel;
using System.Data;
using System.Text;
using CapaDeEntidade;
using CapaDeNegocio;


namespace GerenciamentoEscola
{
    public partial class Form1 : Form
    {
        ClasseEntidade clsuser = new ClasseEntidade();
        ClasseNegocio clsent = new ClasseNegocio();

        public static string usuario_nome;
        public static string id_tipo;
        public static string usuario_geral;
        public static string usuario_Codigo;

        frmPrincipal f = new frmPrincipal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            clsuser.usuario = textBox1.Text;
            clsuser.senha = textBox2.Text;

            dt = clsent.N_login(clsuser);

            if (dt.Rows.Count > 0) {
                MessageBox.Show("Bem-Vindo" + dt.Rows[0][0].ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nome = dt.Rows[0][0].ToString();
                id_tipo = dt.Rows[0][1].ToString();
                usuario_geral = dt.Rows[0][2].ToString();
                usuario_Codigo = dt.Rows[0][4].ToString();
                this.Hide();
                f.ShowDialog();
                Limpar();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Incorretos!!!" , "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }
    }
}