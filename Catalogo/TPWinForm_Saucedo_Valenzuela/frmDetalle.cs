using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace TPWinForm_Saucedo_Valenzuela
{
    public partial class frmDetalle : Form
    {
        Articulo articulo = new Articulo();
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarImagen(articulo.ImagenUrl);
            txtDetalleCodigo.Text = articulo.Codigo;
            txtNombreDetalle.Text = articulo.Nombre;
            string precio = "$" + articulo.Precio.ToString();
            txtPrecioDetalle.Text = precio;
            txtDescripcionDetalle.Text = articulo.Descripcion;

        }

        void cargarImagen(string imagen)
        {
            try
            {
                ptbDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                ptbDetalle.Load("https://th.bing.com/th/id/OIP.B1009X_jAfBqCSnF7pd7mQHaE7?pid=ImgDet&rs=1");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
