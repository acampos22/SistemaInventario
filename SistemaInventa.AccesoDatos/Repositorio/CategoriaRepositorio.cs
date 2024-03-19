using Microsoft.EntityFrameworkCore;
using SistemaInventa.AccesoDatos.Data;
using SistemaInventa.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventa.AccesoDatos.Repositorio
{
    public class CategoriaRepositorio : Repositorio<Categoria>, ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepositorio(ApplicationDbContext db) :base (db)
        {
            _db = db;
        }
        public void Actualizar(Categoria categoria)
        {
            var bodegaBD = _db.Bodegas.FirstOrDefault(b=> b.id == categoria.id);
            if(bodegaBD != null) {
                bodegaBD.Nombre = categoria.Nombre;
                bodegaBD.Descripcion = categoria.Descripcion;
                bodegaBD.Estado = categoria.Estado;
                _db.SaveChanges();
            }
        }
    }
}
