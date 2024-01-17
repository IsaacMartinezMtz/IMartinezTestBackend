using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Productos
    {
        public static List<object> GetAll()
        {
            List<object> Object = new List<object>();
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.GetAllProductos().ToList();
                    if (query != null)
                    {
                        foreach(var item in query)
                        {
                            ML.Productos productos = new ML.Productos();
                            productos.DivSubcategorias = new ML.DivSubcategorias();
                            productos.IdProductos = item.IdProductos;
                            productos.NombreProducto = item.NombreProducto;
                            productos.NumMaterial = item.NumMaterial;
                            productos.DivSubcategorias.IdDivSubcategorias = (int)item.Categoria;
                            productos.DivSubcategorias.Nombre = item.Nombre;
                            productos.Inventario = (int)item.Inventario;
                            Object.Add(productos);
                        }
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Object;
        }
        public static List<object> GetById(int IdProducto)
        {
            List<object> Object = new List<object>();
            try
            {
                using (DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.GetByIdProductos(IdProducto);
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.Productos productos = new ML.Productos();
                            productos.DivSubcategorias = new ML.DivSubcategorias();
                            productos.DivSubcategorias.SubCategoria = new ML.SubCategoria();
                            productos.DivSubcategorias.SubCategoria.Categorias = new ML.Categorias();
                            productos.IdProductos = item.IdProductos;
                            productos.NombreProducto = item.NombreProducto;
                            productos.NumMaterial = item.NumMaterial;
                            productos.DivSubcategorias.IdDivSubcategorias = (int)item.Categoria;
                            productos.DivSubcategorias.Nombre = item.Nombre;
                            productos.DivSubcategorias.SubCategoria.Categorias.IdCategoria = (int)item.IdCategoria;
                            productos.DivSubcategorias.SubCategoria.IdSubcategorias = item.IdSubcategorias;
                            productos.Inventario = (int)item.Inventario;
                            Object.Add(productos);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Object;
        }
        public static bool Add(ML.Productos productos)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.AddProductos(productos.NombreProducto,productos.NumMaterial, productos.DivSubcategorias.IdDivSubcategorias, productos.Inventario);
                    if(query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct = false;
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Correct;
        }
        public static bool Update (ML.Productos productos)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.UpdateProductos(productos.IdProductos, productos.NombreProducto, productos.NumMaterial, productos.DivSubcategorias.IdDivSubcategorias, productos.Inventario);
                    if(query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct = false;
                    }
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Correct;
        }
        public static bool Delete (int IdProductos)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.DeleteProductos(IdProductos);
                    if(query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct = false;
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Correct;
        }
    }
}
