using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceDDon.Infra.Repository;
using WebServiceDDon.Models;

namespace WebServiceDDon.Controllers
{
    public class PassivasController : ApiController
    {
        PassivasRepository Db = new PassivasRepository();
        // GET: api/Passivas
        public IEnumerable<Passivas> Get(int idioma, bool ok)
        {
            return Db.List(idioma);
        }

        // GET: api/Passivas/5
        public Passivas Get(int id)
        {
            return Db.FindById(id);
        }

        public IEnumerable<Passivas> Get()
        {
            return Db.List();
        }
    }
}
