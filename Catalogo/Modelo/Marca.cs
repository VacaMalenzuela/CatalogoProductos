using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Marca
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return descripcion;
        }

        public Marca(int iD, string descripcion)
        {
            this.id = iD;
            this.descripcion = descripcion;
        }
        public Marca() { }
    }
}