using SistemaInventa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventa.AccesoDatos.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio : Irepositorio<Categoria>
    {
        void Actualizar(Categoria Categoria);
    }
}
 