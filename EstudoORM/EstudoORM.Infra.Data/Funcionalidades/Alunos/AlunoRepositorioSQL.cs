using EstudoORM.Domain.Funcionalidades.Alunos;
using EstudoORM.Domain.Interfaces.Funcionalidades.Alunos;
using EstudoORM.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Infra.Data.Funcionalidades.Alunos
{
    public class AlunoRepositorioSQL : IAlunoRepositorio
    {
        UniversidadeBdContexto _contexto;

        public AlunoRepositorioSQL(UniversidadeBdContexto contexto)
        {
            _contexto = contexto;
        }

        public Aluno Adicionar(Aluno aluno)
        {
            //aluno não precisaria receber de contexto porque contexto
            //usa a referência de memória
            aluno = _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();
            return aluno;
        }

        public void Atualizar()
        {
            _contexto.SaveChanges();
        }

        public Aluno BuscarPorId(long id)
        {
            //_contexto.Alunos.Include("Endereco").Include("Turma").ToList();
            return _contexto.Alunos.Find(id);
        }

        public IEnumerable<Aluno> BuscarTodos()
        {
            return _contexto.Alunos.ToList();
        }

        public void Excluir(Aluno aluno)
        {
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();
        }
    }
}
