using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventa.AccesoDatos.Repositorio.IRepositorio
{ 
    public interface Irepositorio<T> where T : class
    {

        Task<T>  Obtener(int id);
        Task<IEnumerable<T>> ObtenerTodos(Expression<Func<T,bool>> filtro = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            String incluirPropiedades = null,
            bool isTracking = true);
        Task<T> ObtenerPrimero(Expression<Func<T, bool>> filtro = null,
            String incluirPropiedades = null,
            bool isTracking = true);
        Task Agregar(T entidad);
        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);
    }

       
         
}
