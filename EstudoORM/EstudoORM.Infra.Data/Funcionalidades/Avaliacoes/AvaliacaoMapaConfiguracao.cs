using EstudoORM.Domain.Funcionalidades.Avaliacoes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Infra.Data.Funcionalidades.Avaliacoes
{
    public class AvaliacaoMapaConfiguracao : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoMapaConfiguracao()
        {
            ToTable("TBAvaliacao");
        }
    }
}
