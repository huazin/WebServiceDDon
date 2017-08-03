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
    public class JobController : ApiController
    {
        JobRepository Db = new JobRepository();
        // GET: api/Job
        public IEnumerable<Job> Get()
        {
            return Db.List();
        }

        // GET: api/Job/5
        public Job Get(int id)
        {
            return Db.FindById(id);
        }
    }
}
