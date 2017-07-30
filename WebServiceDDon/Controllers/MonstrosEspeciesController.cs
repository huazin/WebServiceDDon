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
    public class MonstrosEspeciesController : ApiController
    {
        EspecieRepository Db = new EspecieRepository();

        public IEnumerable<Especie> Get()
        {
            return Get(1,1);
        }

        public IEnumerable<Especie> Get(int categoria, int idioma)
        {
            return Db.List(categoria, idioma);
        }
    }
}
