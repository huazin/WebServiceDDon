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
            return null;
        }

        // GET: api/Monstro/5
        public IEnumerable<Monstro> Get(int id)
        {
            return Db.FindByIdList(id);
        }

        public Monstro Get(string apelido, int idioma)
        {
            return Db.FindByName(apelido, idioma);
        }

        public IEnumerable<Monstro> Get(int categoria, int id_especie, int idioma)
        {
            return Db.List(categoria, id_especie, idioma);
        }


    }
}
