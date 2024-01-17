using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    [RoutePrefix("api/SubCategorias")]
    public class SubCategoriasController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            List<object> result = BL.SubCategorias.GetAll();
            if (result != null)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idSubCategoria}")]
        [HttpGet]
        public IHttpActionResult GetById(int idSubCategoria)
        {

            List<object> result = BL.SubCategorias.GetById(idSubCategoria);
            if (result != null)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("")]
        [HttpPost]
        public IHttpActionResult Add(ML.SubCategoria subCategorias)
        {

            bool result = BL.SubCategorias.Add(subCategorias);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idSubCategoria}")]
        [HttpPut]
        public IHttpActionResult Update(int idSubCategoria, [FromBody] ML.SubCategoria subCategorias)
        {
            subCategorias.IdSubcategorias = idSubCategoria;
            bool result = BL.SubCategorias.Update(subCategorias);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idSubacategoria}")]
        [HttpDelete]
        public IHttpActionResult Delete(int idSubacategoria)
        {

            bool result = BL.SubCategorias.Delete(idSubacategoria);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }
        }
        [Route("categorias/{idCategoria}")]
        [HttpGet]
        public IHttpActionResult GetByIdCategorias(int idCategoria)
        {

            List<object> result = BL.SubCategorias.GetByIdCategoria(idCategoria);
            if (result != null)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
    }
}
