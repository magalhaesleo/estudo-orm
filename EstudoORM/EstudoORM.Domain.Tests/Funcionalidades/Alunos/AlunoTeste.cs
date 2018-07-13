using EstudoORM.Domain.Funcionalidades.Alunos;
using EstudoORM.Domain.Funcionalidades.Resultados;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Domain.Tests.Funcionalidades.Alunos
{
    [TestFixture]
    public class AlunoTeste
    {
        Mock<Resultado> resultadoMock;
        Mock<Resultado> resultado2Mock;
        Mock<Resultado> resultado3Mock;
        Mock<Resultado> resultado4Mock;

        [SetUp]
        public void IniciarCenario()
        {
            resultadoMock = new Mock<Resultado>();
            resultado2Mock = new Mock<Resultado>();
            resultado3Mock = new Mock<Resultado>();
            resultado4Mock = new Mock<Resultado>();
        }
        [Test]
        public void Aluno_Dominio_CalcularMedia_Sucesso()
        {
            resultadoMock.Setup(r => r.Nota).Returns(8);
            resultado2Mock.Setup(r => r.Nota).Returns(6);
            List<Resultado> resultados = new List<Resultado>();
            resultados.Add(resultadoMock.Object);
            resultados.Add(resultado2Mock.Object);
            Aluno aluno = new Aluno();
            aluno.Resultados = resultados;


            double media = aluno.Calcular_media();

            media.Should().Be(7);
        }

        [Test]
        public void Aluno_Dominio_ArredondarMedia_Sucesso()
        {
            double media = 9.75;

            double mediaArredondadaEsperada = 10;

            Aluno aluno = new Aluno();

            media = aluno.Arredondar_media(media);

            media.Should().Be(mediaArredondadaEsperada);
        }

        [Test]
        public void Aluno_Dominio_ArredondarMedia_ParaZero_35decimos_Sucesso()
        {

        }

        [Test]
        public void Aluno_Dominio_ArredondarMedia_ParaMetade_36decimos_Sucesso()
        {

        }

        [Test]
        public void Aluno_Dominio_ArredondarMedia_ParaMetade_74decimos_Sucesso()
        {

        }

        [Test]
        public void Aluno_Dominio_ArredondarMedia_ParaCima_Sucesso()
        {

        }


    }
}
