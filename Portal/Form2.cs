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
        public bool Sorted { get; set; }

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


        }
        private void btn_filtro_Click(object sender, EventArgs e)
        {



        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    DialogResult conf = MessageBox.Show("O item será excluído permanentemente.", "Deseja excluí-lo?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                if (lv_alunos.SelectedIndices.Count > 0)
                {
                    int selectedIndex = lv_alunos.SelectedIndices[0];
                    lv_alunos.Items.RemoveAt(selectedIndex);
                    var aluno = Alunos[selectedIndex];
                    var repository = new AlunoRepository();
                    repository.Delete(aluno);
                }
            }
            catch (Exception) { }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ordenarPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void realizarEdiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ListAtualizar = new Form3();
            ListAtualizar.ShowDialog();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv_alunos.Sorting = SortOrder.Ascending;
        }

        private void lv_alunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
