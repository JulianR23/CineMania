using Conector;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICineMania.Controllers
{
    public class PersonaController : ApiController
    {
        // GET: api/Persona
        public IEnumerable<PERSONA> Get()
        {
            using (CINEMANIAEntities objUsuario = new CINEMANIAEntities())
            {
                return objUsuario.PERSONA.ToList();
            }
        }

        // GET: api/Persona/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Persona
        public HttpResponseMessage Post([FromBody]PERSONA objusuario)
        {
            EntityState operacion = EntityState.Added;
            return Operacion(objusuario, operacion);
        }

        private HttpResponseMessage Operacion([FromBody] PERSONA objUsuario, EntityState operacion)
        {
            int resp = 0;
            HttpResponseMessage objMenRespuesta = null;
            try
            {
                using (CINEMANIAEntities objEntidad = new CINEMANIAEntities())
                {
                    objEntidad.Entry(objUsuario).State = operacion;
                    resp = objEntidad.SaveChanges();
                    objMenRespuesta = Request.CreateResponse(HttpStatusCode.OK, resp);
                }
            }
            catch (Exception er)
            {
                objMenRespuesta = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, er.Message);
            }
            return objMenRespuesta;
        }
    }
}
