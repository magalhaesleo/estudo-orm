using EstudoORM.Domain.Funcionalidades.Alunos;
using EstudoORM.Domain.Funcionalidades.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Common.Tests
{
    public static partial class ObjectMother
    {
        public static Aluno ObterAlunoValido(List<Resultado> resultados)
        {
            Aluno aluno = new Aluno();
            aluno.Idade = 20;
            aluno.Nome = "ze";
            aluno.Resultados = resultados;

            return aluno;

        }
    }
}
