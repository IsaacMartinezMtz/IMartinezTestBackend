using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    [RoutePrefix("api/Categoria")]
    public class CategoriasController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            
            List<object> result = BL.Categoria.GetAll();
            if (result != null)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idCategoria}")]
        [HttpGet]
        public IHttpActionResult GetById(int idCategoria)
        {

            List<object> result = BL.Categoria.GetById(idCategoria);
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
        public IHttpActionResult Add(ML.Categorias categorias)
        {

            bool result = BL.Categoria.Add(categorias);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idCategoria}")]
        [HttpPut]
        public IHttpActionResult Update(int idCategoria, [FromBody]ML.Categorias categorias)
        {
            categorias.IdCategoria = idCategoria;
            bool result = BL.Categoria.Update(categorias);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idCategoria}")]
        [HttpDelete]
        public IHttpActionResult Delete(int idCategoria)
        {

            bool result = BL.Categoria.Delete(idCategoria);
            if (result)
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
