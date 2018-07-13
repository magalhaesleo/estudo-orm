using EstudoORM.Domain.Funcionalidades.Resultados;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Infra.Data.Funcionalidades.Resultados
{
    public class ResultadoMapaConfiguracao : EntityTypeConfiguration<Resultado>
    {
        public ResultadoMapaConfiguracao()
        {
            ToTable("TBResultado");
        }
    }
}
