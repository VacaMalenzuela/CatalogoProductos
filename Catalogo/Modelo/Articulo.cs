using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public Marca marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria categoria { get; set; }
        public int  Activo { get; set; }





    }
}
