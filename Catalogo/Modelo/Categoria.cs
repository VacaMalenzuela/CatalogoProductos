using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return descripcion;
        }
        public Categoria(int ID, string Descripcion)
        {
            this.id = ID;
            this.descripcion = Descripcion;
        }
        public Categoria() { }
    }
}
