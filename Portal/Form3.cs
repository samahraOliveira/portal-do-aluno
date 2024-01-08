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
using Portal;

namespace Portal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ObterAlunos();
        }

        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();

        private void ObterAlunos()
        {
            var repository = new AlunoRepository();
            Alunos = repository.Get();

            foreach (var item in Alunos)
            {
                lv_alunos2.Items.Add(new ListViewItem(new string[] { item.Nome, item.Idade.ToString(), item.Curso }));
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lv_alunos2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lv_alunos2.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txt_NomeAtual.Text = item.SubItems[0].Text;
                txt_IdadeAtual.Text = item.SubItems[1].Text;
                txt_CursoAtual.Text = item.SubItems[2].Text;
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            var nomeAtual = txt_NomeAtual.Text;
            var idadeAtual = txt_IdadeAtual.Text;
            var cursoAtual = txt_CursoAtual.Text;

            var aluno = new Aluno(nomeAtual, idadeAtual, cursoAtual);
            var repository = new AlunoRepository();
           
            repository.Update(aluno);

            MessageBox.Show("Aluno atualizado com sucesso!");
        }
    }
}
