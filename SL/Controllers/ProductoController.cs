using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    [RoutePrefix("api/Productos")]
    public class ProductoController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            List<object> result = BL.Productos.GetAll();
            if (result != null)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idProductos}")]
        [HttpGet]
        public IHttpActionResult GetById(int idProductos)
        {

            List<object> result = BL.Productos.GetById(idProductos);
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
        public IHttpActionResult Add(ML.Productos productos)
        {

            bool result = BL.Productos.Add(productos);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idProductos}")]
        [HttpPut]
        public IHttpActionResult Update(int idProductos, [FromBody] ML.Productos productos)
        {
            productos.IdProductos = idProductos;
            bool result = BL.Productos.Update(productos);
            if (result)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }

        }
        [Route("{idProductos}")]
        [HttpDelete]
        public IHttpActionResult Delete(int idProductos)
        {

            bool result = BL.Productos.Delete(idProductos);
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
