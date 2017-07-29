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
    public class MonstroController : ApiController
    {
        MonstroRepository Db = new MonstroRepository();

        // GET: api/Monstro
        public Monstro Get()
        {
            return Get(1);
        }

        // GET: api/Monstro/5
        public Monstro Get(int id)
        {
            return Db.FindById(id);
        }


    }
}
