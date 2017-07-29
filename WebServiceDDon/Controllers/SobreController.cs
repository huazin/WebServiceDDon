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
    public class SobreController : ApiController
    {
        // GET: api/Sobre
        public Sobre Get()
        {
            return Get(1);
        }

        // GET: api/Sobre/5
        public Sobre Get(int id)
        {
            SobreRepository Db = new SobreRepository();
            return Db.FindById(id);
        }
    }
}
