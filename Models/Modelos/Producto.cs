using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descrip { get; set; }
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
    }
}
