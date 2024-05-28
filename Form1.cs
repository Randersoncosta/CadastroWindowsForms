using CadastroAlunos.infraestrutura;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class Form1 : Form
    {
        public List<Alunos> Alunos { get; private set; } = new List<Alunos>();

        public Form1()
        {
            InitializeComponent();
            ObterAluno();
        }
        private void ObterAluno()
        {
            var repository = new AlunoRepository();
            Alunos = repository.Get();

            foreach (var item in Alunos)
            {
                lv_alunos.Items.Add(new ListViewItem(new string[] { item.Nome, item.Idade.ToString(), item.Curso }));
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt__nome.Text;
                var idade = txt__idade.Text;
                var curso = txt__curso.Text;

                foreach (var item in Alunos) 
                {
                    if(item.Nome == nome)
                    {
                        MessageBox.Show(nome + "Já está cadastrado no sistema.");
                        return;
                    }
                }
                var aluno = new Alunos(nome, idade,curso);
                Alunos.Add(aluno);

                var repository = new AlunoRepository();
                repository.Add(aluno);

                lv_alunos.Items.Add(new ListViewItem(new string[] {nome,idade,curso}));



            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
