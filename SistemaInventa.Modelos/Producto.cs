﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventa.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Numero de serie es Requerido")]
        [MaxLength(60)]
        public string NumeroSerie { get; set; }
        [Required(ErrorMessage = "Descripcion es Requerido")]
        [MaxLength(60)]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Precio es Requerido")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Costo es Requerido")]

        public double Costo { get; set; }

        public string ImagenUrl { get; set; }

       
        [Required(ErrorMessage = "Estado es Requerido")]

        public bool Estado { get; set; }
        [Required(ErrorMessage = "Categoria es Requerido")]
        public int CategoriaId {  get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria categoria { get; set; }

        [Required(ErrorMessage = "Marca es Requerido")]
        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public Marca marca { get; set; }

        public int? PadreId { get; set; }
        public virtual Producto Padre { get; set; }

    }
}
