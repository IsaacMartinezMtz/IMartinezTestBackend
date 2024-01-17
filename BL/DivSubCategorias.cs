using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DivSubCategorias
    {

        public static List<object> GetAll()
        {
            List<object> div = new List<object>();
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.DiVSubCategoriasGetAll().ToList();
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.DivSubcategorias division = new ML.DivSubcategorias();
                            division.SubCategoria = new ML.SubCategoria();
                            division.IdDivSubcategorias = item.IdDivSubcategorias;
                            division.Nombre = item.Nombre;
                            division.SubCategoria.IdSubcategorias = item.IdDivSubcategorias;
                            division.SubCategoria.Nomnbre = item.NombreSub;
                            div.Add(division);
                        }
                    }

                }

            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return div;
        }

        public static List<object> GetById(int IdDivSubcategoria)
        {
            List<object> div = new List<object>();
            try
            {
                using (DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.DivSubcategoriasGetById(IdDivSubcategoria).ToList();
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.DivSubcategorias division = new ML.DivSubcategorias();
                            division.SubCategoria = new ML.SubCategoria();
                            division.IdDivSubcategorias = item.IdDivSubcategorias;
                            division.Nombre = item.Nombre;
                            division.SubCategoria.IdSubcategorias = item.IdDivSubcategorias;
                            division.SubCategoria.Nomnbre = item.NomSub;
                            div.Add(division);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return div;
        }
        public static bool Add(ML.DivSubcategorias divSubcategorias)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.AddDivSubcategorias(divSubcategorias.Nombre, divSubcategorias.SubCategoria.IdSubcategorias);
                    if(query >  0)
                    {
                        Correct= true;
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
        public static bool Update(ML.DivSubcategorias divSubcategorias)
        {
            bool Correct = false;
            try
            {
                using (DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.UpdateDivSubcategorias(divSubcategorias.IdDivSubcategorias, divSubcategorias.Nombre, divSubcategorias.SubCategoria.IdSubcategorias);
                    if (query > 0)
                    {
                        Correct =  true;
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
        public static bool Delete (int IdDivSubcategorias)
        {
            bool Correct = false;
            try
            {
                using(DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.DeleteDivSubcategorias(IdDivSubcategorias);
                    if(query > 0)
                    {
                        Correct = true;
                    }
                    else
                    {
                        Correct = false;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return Correct;
        }
        public static List<object> GetByIdSubcategoria(int IdSubcategoria)
        {
            List<object> div = new List<object>();
            try
            {
                using (DL.TestBackendEntities context = new DL.TestBackendEntities())
                {
                    var query = context.GetByIdSubCategorias(IdSubcategoria).ToList();
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            ML.DivSubcategorias division = new ML.DivSubcategorias();
                            division.SubCategoria = new ML.SubCategoria();
                            division.IdDivSubcategorias = (int)item.IdSubCategorias;
                            division.Nombre = item.Nombre;
                            div.Add(division);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return div;
        }
    }
}
