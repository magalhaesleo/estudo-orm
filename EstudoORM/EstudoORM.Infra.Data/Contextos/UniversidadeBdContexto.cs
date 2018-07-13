using EstudoORM.Domain.Funcionalidades.Alunos;
using EstudoORM.Domain.Funcionalidades.Avaliacoes;
using EstudoORM.Domain.Funcionalidades.Resultados;
using EstudoORM.Infra.Data.Funcionalidades.Alunos;
using EstudoORM.Infra.Data.Funcionalidades.Avaliacoes;
using EstudoORM.Infra.Data.Funcionalidades.Resultados;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Infra.Data.Contextos
{
    public class UniversidadeBdContexto : DbContext
    {
        public UniversidadeBdContexto() : base("Universidade_Bd")
        {
        }

        public UniversidadeBdContexto(string nomeDoBanco) : base(nomeDoBanco)
        {
        }

        //DbSets - Cada DbSet corresponde a uma tabela
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Resultado> Resultados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //ModelBuilder
            modelBuilder.Configurations.Add(new AlunoMapaConfiguracao());
            modelBuilder.Configurations.Add(new AvaliacaoMapaConfiguracao());
            modelBuilder.Configurations.Add(new ResultadoMapaConfiguracao());
        }
    }
}
