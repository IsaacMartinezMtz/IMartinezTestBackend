using ML;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Categoria
    {
        public static List<object> GetAll()
        {
            List<object> Categorias = new List<object>();
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.GetAllCategorias().ToList();
                    if(query != null)
                    {
                        foreach(var item in query)
                        {
                            ML.Categorias categoria = new ML.Categorias();
                            categoria.IdCategoria = item.IdCategoria;
                            categoria.Nombre = item.Nombre;
                            Categorias.Add(categoria);
                        }
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            return Categorias;

        }
        public static List<object> GetById(int IdCategoria)
        {
            List<object> Object = new List<object>();
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.GetByIdCategoria(IdCategoria);
                    if(query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.Categorias categoria = new ML.Categorias();
                            categoria.IdCategoria = item.IdCategoria;
                            categoria.Nombre=item.Nombre;
                            Object.Add(categoria);
                        }
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            return Object;
        }
        public static bool Add(ML.Categorias categorias)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.AddCategoria(categorias.Nombre);
                    if(query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct =false;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return Correct;
        }
        public static bool Update ( ML.Categorias categorias)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.UpdateCategoria(categorias.IdCategoria, categorias.Nombre);
                    if(query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct =false;
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Correct;
        }
        public static bool Delete(int IdCategoria)
        {
            bool Correct = false;
            try
            {
                using (DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.DeleteCategoria(IdCategoria);
                    if (query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct = false;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Correct;
        }
    }
}
