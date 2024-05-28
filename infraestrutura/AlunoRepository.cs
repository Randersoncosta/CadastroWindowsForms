using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos.infraestrutura
{
    public class AlunoRepository
    {
        public bool Add(Alunos aluno)
        {
            var conn =  new DbConection();

            string query = @"insert into alunos (nome , idade, curso)
                             values(@nome,@idade,@curso);";

            var result = conn.Conection.Execute(sql: query , param: aluno);

            return result == 1;
        }
        public List<Alunos> Get()
        {
            var conn = new DbConection();

            string query = @"select * from alunos";

            var alunos = conn.Conection.Query<Alunos>(sql: query);

            return alunos.ToList();
        }
    }
}
