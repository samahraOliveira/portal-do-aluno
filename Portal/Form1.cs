using Portal.Infrastructure;
using Portal;

namespace Portal
{
    public partial class Form1 : Form
    {
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void alunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome.Text;
                var idade = txt_idade.Text;
                var curso = txt_curso.Text;

                foreach (var item in Alunos)
                {
                    if (item.Nome == nome)
                    {
                        MessageBox.Show(nome + " já está cadastrado no sistema.");
                        return;
                    }
                }

                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);
                var repository = new AlunoRepository();
                repository.Add(aluno);

                MessageBox.Show("Aluno adicionado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_consulta_Click(object sender, EventArgs e)
        {
            Form2 ListaDeAlunos = new Form2();
            ListaDeAlunos.ShowDialog();
        }
    }
}
