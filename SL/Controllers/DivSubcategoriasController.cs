using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    [RoutePrefix("api/divSubcategorias")]
    public class DivSubcategoriasController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            List<object> result = BL.DivSubCategorias.GetAll();
            if (result != null)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idDivSubcategoria}")]
        [HttpGet]
        public IHttpActionResult GetById(int idDivSubcategoria)
        {

            List<object> result = BL.DivSubCategorias.GetById(idDivSubcategoria);
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
        public IHttpActionResult Add(ML.DivSubcategorias divSubcategorias)
        {

            bool result = BL.DivSubCategorias.Add(divSubcategorias);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idDivSubcategorias}")]
        [HttpPut]
        public IHttpActionResult Update(int idDivSubcategorias, [FromBody] ML.DivSubcategorias divsSbcategorias)
        {
            divsSbcategorias.IdDivSubcategorias = idDivSubcategorias;
            bool result = BL.DivSubCategorias.Update(divsSbcategorias);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idDivsubacategoria}")]
        [HttpDelete]
        public IHttpActionResult Delete(int idDivsubacategoria)
        {

            bool result = BL.DivSubCategorias.Delete(idDivsubacategoria);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }
        }
        [Route("subCategorias/{idSubCategoria}")]
        [HttpGet]
        public IHttpActionResult GetByIdCategorias(int idSubCategoria)
        {

            List<object> result = BL.DivSubCategorias.GetByIdSubcategoria(idSubCategoria);
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
