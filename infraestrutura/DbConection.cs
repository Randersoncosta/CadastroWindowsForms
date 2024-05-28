using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos.infraestrutura
{
    public class DbConection :IDisposable
    {
        public NpgsqlConnection Conection { get; set; }

        public DbConection() 
        {
            Conection = new NpgsqlConnection("Server=localhost;Port=5432;Database=ListaAlunos;User Id=postgres;Password=123;");
            Conection.Open();
        }

        public void Dispose()
        {
            Conection.Dispose();
        }
    }
}
