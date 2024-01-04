using Portal.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal
{
    public partial class Form2 : Form
    {

        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        public Form2()
        {
            InitializeComponent();
            ObterAlunos();
        }

        private void ObterAlunos()
        {
            var repository = new AlunoRepository();
            Alunos = repository.Get();

            foreach (var item in Alunos)
            {
                lv_alunos.Items.Add(new ListViewItem(new string[] { item.Nome, item.Idade.ToString(), item.Curso }));
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("O item será excluído permanentemente.");
            }
            if (lv_alunos.SelectedIndices.Count > 0)
            {
                int selectedIndex = lv_alunos.SelectedIndices[0];
                lv_alunos.Items.RemoveAt(selectedIndex);
            }
            
        }
        private void btn_filtro_Click(object sender, EventArgs e)
        {

            

        }
    }
}
