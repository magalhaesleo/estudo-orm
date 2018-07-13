using EstudoORM.Domain.Funcionalidades.Alunos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Infra.Data.Funcionalidades.Alunos
{
    public class AlunoMapaConfiguracao : EntityTypeConfiguration<Aluno>
    {
        public AlunoMapaConfiguracao()
        {
            ToTable("TBAluno");

            HasMany(a => a.Resultados)
                .WithRequired();
        }
    }
}
