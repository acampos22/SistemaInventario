using SistemaInventa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventa.AccesoDatos.Repositorio.IRepositorio
{
    public interface IMarcaRepositorio : Irepositorio<Marca>
    {
        void Actualizar(Marca marca);
    }
}
 