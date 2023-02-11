using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
using System.CodeDom;
using System.Configuration;

namespace TPWinForm_Saucedo_Valenzuela
{
    public partial class Catalogo : Form
    {
        private List<Articulo> listaArticulo;

        public Catalogo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
            cbxCampo.Items.Add("Código");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Categoría");

        }


        public void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.listar();
                dgvDatos.DataSource = listaArticulo;
                OcultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            txtFiltro.Text = string.Empty;
           
        }

        private void OcultarColumnas()
        {
            dgvDatos.Columns["ImagenUrl"].Visible = false;
            dgvDatos.Columns["Id"].Visible = false;
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
   
        private void cargarImagen(string imagen) 
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://th.bing.com/th/id/OIP.B1009X_jAfBqCSnF7pd7mQHaE7?pid=ImgDet&rs=1");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("NO HAY NADA SELECIONADO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                Cargar();
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("NO HAY NADA SELECIONADO","ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Articulo seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                frmDetalle detalle = new frmDetalle(seleccionado);
                detalle.ShowDialog();
                Cargar();
            }
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("NO HAY NADA SELECIONADO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            Eliminar();

            }
        }

        private void Eliminar(bool logico = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("NO HAY NADA SELECIONADO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro de que quieres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;

                        if (logico) negocio.EliminarLogico(seleccionado.Id);
                        else negocio.Eliminar(seleccionado.Id);

                        Cargar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvDatos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Codigo.ToLower().Contains(filtro.ToLower()) || x.Descripcion.ToLower().Contains(filtro.ToLower()) || x.marca.descripcion.ToLower().Contains(filtro.ToLower()) || x.categoria.descripcion.ToLower().Contains(filtro.ToLower()));
            else
                listaFiltrada = listaArticulo;

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            cbxCriterio.Items.Clear();
            cbxCriterio.Items.Add("Comienza con");
            cbxCriterio.Items.Add("Termina con");
            cbxCriterio.Items.Add("Contiene");
        }

        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("por favor, seleccione el campo a filtrar");
                return true;
            }

            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("por favor, seleccione el criterio a filtrar");
                return true;
            }
            if(cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(solonumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Solo numeros para filtrar por un campo numerico");
                    return true;
                }

            }

            return false;
        }

        private bool solonumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
    }
}