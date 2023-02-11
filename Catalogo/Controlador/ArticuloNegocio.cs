using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
   public class ArticuloNegocio
   {
        public List<Articulo> listar() {
            List<Articulo> Lista  = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            datos.setConsulta("Select Codigo, Nombre, A.Descripcion, ImagenUrl, precio, M.Descripcion Tipo, C.Descripcion Cat, A.Id from Articulos A, MARCAS M, CATEGORIAS C where a.Idmarca = m.Id and a.IdCategoria = c.Id and A.Activo=1");
            datos.EjecutarLectura();

            while (datos.Lector.Read())
            {
                Articulo aux = new Articulo();

                aux.Id = (int)datos.Lector["Id"];
                if (!(datos.Lector["Codigo"] is DBNull))
                    aux.Codigo = (string)datos.Lector["Codigo"];
                if (!(datos.Lector["Nombre"] is DBNull))
                    aux.Nombre = (string)datos.Lector["Nombre"];
                if (!(datos.Lector["Descripcion"] is DBNull))
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                if (!(datos.Lector["ImagenUrl"] is DBNull))
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                if (!(datos.Lector["Precio"] is DBNull))
                    aux.Precio = (decimal)datos.Lector["Precio"];
                if (!(datos.Lector["Tipo"] is DBNull))
                    aux.marca = new Marca();
                    aux.marca.descripcion = (string)datos.Lector["Tipo"];
                if (!(datos.Lector["Cat"] is DBNull))
                    aux.categoria = new Categoria();
                    aux.categoria.descripcion = (string)datos.Lector["Cat"];

                Lista.Add(aux);
            }
                
            return Lista;
        }

        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("Insert into articulos values(@codigo,@nombre,@descripcion,@idmarca,@idcategoria,@urlimagen,@precio,1)");
                datos.SetearParametros("@codigo", articulo.Codigo);
                datos.SetearParametros("@nombre", articulo.Nombre);
                datos.SetearParametros("@descripcion", articulo.Descripcion);
                datos.SetearParametros("@idmarca", articulo.marca.id);
                datos.SetearParametros("@idcategoria", articulo.categoria.id);
                datos.SetearParametros("@urlimagen", articulo.ImagenUrl);
                datos.SetearParametros("@precio", articulo.Precio);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { 
                datos.CerrarConexion();
            }
         
        }
        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @imagenurl, Precio =  @precio WHERE Id = @id");
                datos.SetearParametros ("@codigo", articulo.Codigo);
                datos.SetearParametros("@nombre", articulo.Nombre);
                datos.SetearParametros("@descripcion", articulo.Descripcion);
                datos.SetearParametros("@imagenurl", articulo.ImagenUrl);
                datos.SetearParametros("@idmarca", articulo.marca.id);
                datos.SetearParametros("@idcategoria", articulo.categoria.id);
                datos.SetearParametros("@precio", articulo.Precio);
                datos.SetearParametros("@id", articulo.Id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        
        public void Eliminar (int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta("delete from ARTICULOS where id=@id");
                datos.SetearParametros("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public void EliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta("update ARTICULOS set Activo = 0 where id = @id");
                datos.SetearParametros("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo> ();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Codigo, Nombre, A.Descripcion, ImagenUrl, precio, M.Descripcion Tipo, C.Descripcion Cat, A.Id from Articulos A, MARCAS M, CATEGORIAS C where a.Idmarca = m.Id and a.IdCategoria = c.Id and A.Activo=1 And ";

                switch (campo)
                {
                    case "Código":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Codigo like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "Codigo like '%" + filtro + "' ";
                                break;
                            case "Contiene":
                                consulta += "Codigo like '%" + filtro + "%' ";
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "' ";
                                break;
                            case "Contiene":
                                consulta += "Nombre like '%" + filtro + "%' ";
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "M.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "M.Descripcion like '%" + filtro + "' ";
                                break;
                            case "Contiene":
                                consulta += "M.Descripcion like '%" + filtro + "%' ";
                                break;
            
                        }
                        break;
                    case "Categoría":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "C.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "C.Descripcion like '%" + filtro + "' ";
                                break;
                            case "Contiene":
                                consulta += "C.Descripcion like '%" + filtro + "%' ";
                                break;
                           default:
                                break;
                        }
                        break;
                    default :
                        break;
                }

                datos.setConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["Tipo"] is DBNull))
                        aux.marca = new Marca();
                    aux.marca.descripcion = (string)datos.Lector["Tipo"];
                    if (!(datos.Lector["Cat"] is DBNull))
                        aux.categoria = new Categoria();
                    aux.categoria.descripcion = (string)datos.Lector["Cat"];

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}


