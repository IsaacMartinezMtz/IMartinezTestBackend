using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SubCategorias
    {
        public static List<object> GetAll() 
        { 
            List<object> Sub = new List<object>();
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.GetAllSubCategorias().ToList();
                    if(query != null)
                    {
                        foreach(var item in query)
                        {
                            ML.SubCategoria subCategoria = new ML.SubCategoria();
                            subCategoria.Categorias = new ML.Categorias();
                            subCategoria.IdSubcategorias = item.IdSubcategorias;
                            subCategoria.Nomnbre = item.Nombre;
                            subCategoria.Categorias.Nombre = item.NombrEcTEGORIAS;
                            Sub.Add(subCategoria);   
                        }
                    }
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Sub;
        }
        public static List<object> GetById(int IdSubcategoria)
        {
            List<object> Sub = new List<object>();
            try
            {
                using (DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.GetByIdSubCategoriasC(IdSubcategoria);
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.SubCategoria subCategoria = new ML.SubCategoria();
                            subCategoria.Categorias = new ML.Categorias();
                            subCategoria.IdSubcategorias = (int)item.IdSubcategorias;
                            subCategoria.Nomnbre = item.Nombre;
                            subCategoria.Categorias.Nombre = item.NombreCategoria;
                            subCategoria.Categorias.IdCategoria = (int)item.IdCategoria;
                            Sub.Add(subCategoria);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Sub;
        }
        public static bool Add(ML.SubCategoria subCategoria)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.AddSucategoriasCategorias(subCategoria.Nomnbre, subCategoria.Categorias.IdCategoria);
                    if(query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct=false;
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Correct;
        }
        public static bool Update(ML.SubCategoria subCategoria)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.UpdateSubcatergorias(subCategoria.IdSubcategorias, subCategoria.Nomnbre, subCategoria.Categorias.IdCategoria);
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
        public static bool Delete(int IdSubcategoria)
        {
            bool correct = false;
            try
            {
                using (DL.TestBackendEntities context = new DL.TestBackendEntities()) { 
                    var query = context.DeleteSubacategorias(IdSubcategoria);
                    if(query > 0)
                    {
                        correct = true;
                    }
                    else
                    {
                        correct = false;
                    }
                }

            }catch (Exception ex)
            {
                correct = false;
            }
            return correct;
        }
        public static List<object> GetByIdCategoria(int IdCategoria)
        {
            List<object> Sub = new List<object>();
            try
            {
                using (DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.GetByIdCategorias(IdCategoria);
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.SubCategoria subCategoria = new ML.SubCategoria();
                            subCategoria.Categorias = new ML.Categorias();
                            subCategoria.IdSubcategorias = item.IdSubcategorias;
                            subCategoria.Nomnbre = item.Nombre;
                            Sub.Add(subCategoria);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Sub;
        }
    }
}
