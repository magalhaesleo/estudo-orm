using EstudoORM.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Domain.Interfaces
{
    public interface IRepositorio<T> where T : Entidade
    {
        T Adicionar(T entidade);

        //Está sem a entidade porque atualiza todo o contexto
        void Atualizar();

        void Excluir(T entidade);

        IEnumerable<T> BuscarTodos();

        T BuscarPorId(long id);

    }
}
