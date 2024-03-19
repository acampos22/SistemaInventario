using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaInventa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventa.AccesoDatos.Repositorio.IRepositorio
{
    public interface IProductoRepositorio : Irepositorio<Producto>
    {
        void Actualizar(Producto producto);
        IEnumerable<SelectListItem> ObtenerTodosDropdownLista(String obj);
    }
}
 