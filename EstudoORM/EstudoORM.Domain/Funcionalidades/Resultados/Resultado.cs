using EstudoORM.Domain.Base;
using EstudoORM.Domain.Funcionalidades.Alunos;
using EstudoORM.Domain.Funcionalidades.Avaliacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Domain.Funcionalidades.Resultados
{
    public class Resultado : Entidade
    {
        public Avaliacao Avaliacao { get; set; }
        public Aluno Aluno { get; set; }
        public virtual double Nota { get; set; }
    }
}
