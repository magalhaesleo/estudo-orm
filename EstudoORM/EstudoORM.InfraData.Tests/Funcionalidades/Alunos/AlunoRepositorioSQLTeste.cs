using EstudoORM.Common.Tests;
using EstudoORM.Domain.Funcionalidades.Alunos;
using EstudoORM.Domain.Funcionalidades.Resultados;
using EstudoORM.Infra.Data.Contextos;
using EstudoORM.Infra.Data.Funcionalidades.Alunos;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.InfraData.Tests.Funcionalidades.Alunos
{
    [TestFixture]
    public class AlunoRepositorioSQLTeste
    {

        UniversidadeBdContexto _contexto;
        List<Resultado> _resultados;
        Mock<Resultado> _resultadoMock;

        AlunoRepositorioSQL _repositorio;

        [SetUp]
        public void IniciarCenario()
        {
            _contexto = new UniversidadeBdContexto();

            _repositorio = new AlunoRepositorioSQL(_contexto);

            _resultados = new List<Resultado>();

            _resultadoMock = new Mock<Resultado>();
        }

        [Test]
        public void Aluno_InfraData_Adicionar_Sucesso()
        {
            _resultados.Add(new Resultado());

            Aluno alunoParaAdicao = ObjectMother.ObterAlunoValido(_resultados);
            Aluno alunoAdicionado = _repositorio.Adicionar(alunoParaAdicao);

            alunoAdicionado.Should().NotBeNull();
            alunoAdicionado.Id.Should().BeGreaterOrEqualTo(1);
        }

        [Test]
        public void Aluno_InfraData_Atualizar_Sucesso()
        {

        }

        [Test]
        public void Aluno_InfraData_BuscarPorId_Sucesso()
        {

        }

        [Test]
        public void Aluno_InfraData_BuscarTodos_Sucesso()
        {

        }

        [Test]
        public void Aluno_InfraData_Excluir_Sucesso()
        {

        }

    }
}
