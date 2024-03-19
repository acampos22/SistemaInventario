using Microsoft.EntityFrameworkCore;
using SistemaInventa.AccesoDatos.Data;
using SistemaInventa.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaInventa.AccesoDatos.Repositorio
{
    public class MarcaRepositorio : Repositorio<Marca>, IMarcaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public MarcaRepositorio(ApplicationDbContext db) :base (db)
        {
            _db = db;
        }
        public void Actualizar(Marca marca)
        {
            var marcaBD = _db.Marcas.FirstOrDefault(b=> b.id == marca.id);
            if(marcaBD != null) {
                marcaBD.Nombre = marca.Nombre;
                marcaBD.Descripcion = marca.Descripcion;
                marcaBD.Estado = marca.Estado;
                _db.SaveChanges();
            }
        }
    }
}
