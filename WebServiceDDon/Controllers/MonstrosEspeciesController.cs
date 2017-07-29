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
        MonstroRepository Db = new MonstroRepository();

        public IEnumerable<Monstro> Get()
        {
            return Get(1, 1);
        }

        public IEnumerable<Monstro> Get(int categoria, int idioma)
        {
            return Db.GetAllEspecies(categoria, idioma);
        }

        public IEnumerable<Monstro> Get(int categoria, string especie, int idioma)
        {
            return Db.GetAllForEspecies(categoria, especie, idioma);
        }
    }
}
