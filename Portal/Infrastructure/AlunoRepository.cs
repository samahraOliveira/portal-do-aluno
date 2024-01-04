using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure
{
    public class AlunoRepository
    {
        public bool Add(Aluno aluno)
        {
            using var conn = new DbConnection();

            string query = @"INSERT INTO public.alunos(
	                        nome, curso, idade)
	                        VALUES (@nome, @curso, @idade);";
            var result = conn.Connection.Execute(sql: query, param: aluno);

            return result == 1;
        }

        public bool Remove(Aluno aluno)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.alunos WHERE nome = ";
            var result = conn.Connection.Execute(sql: query, param: aluno);

            return result == 1;
        }

        public bool Update(Aluno aluno)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.alunos
	                         SET nome= @nome, curso= @curso, idade= @idade
	                         WHERE <>;";
            var result = conn.Connection.Execute(sql: query, param: aluno);

            return result == 1;
        }

        public List<Aluno> Get() 
        {
            using var conn = new DbConnection();
            string query = @"SELECT nome, curso, idade FROM public.alunos;";
            var alunos = conn.Connection.Query<Aluno>(sql: query);
            return alunos.ToList();
        }


    }
}
