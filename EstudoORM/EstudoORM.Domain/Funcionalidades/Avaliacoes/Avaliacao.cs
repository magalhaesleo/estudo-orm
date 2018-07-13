using EstudoORM.Domain.Base;
using EstudoORM.Domain.Funcionalidades.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Domain.Funcionalidades.Avaliacoes
{
    public class Avaliacao : Entidade
    {
        public List<Resultado> Resultados { get; set; }
        public string Assunto { get; set; }
        public DateTime Data { get; set; }

    }
}
