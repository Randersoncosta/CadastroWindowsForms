using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    public class Alunos
    {
        public string Nome { get; private set; }

        public int Idade { get; private set; }

        public string Curso { get; private set; }

        public Alunos() { }
        public Alunos(string nome, string idade, string curso)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException("Nome é Obrigatorio.");
            }
            if (string.IsNullOrEmpty(idade))
            {
                throw new ArgumentNullException("Idade é Obrigatorio.");
            }
            if (string.IsNullOrEmpty(curso)) 
            {
                throw new ArgumentNullException("Nome é Obrigatorio.");
            }                      

            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }

    }
}
