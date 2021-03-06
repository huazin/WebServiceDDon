﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceDDon.Infra;
using WebServiceDDon.Infra.Repository;
using WebServiceDDon.Models;

namespace WebServiceDDon.Controllers
{
    public class LabelsIdiomasController : ApiController
    {
        // GET: api/LabelsIdiomas
        public IEnumerable<LabelsIdiomas> Get()
        {
            LabelsIdiomasRepository Db = new LabelsIdiomasRepository();
            return Db.List();
        }

        // GET: api/LabelsIdiomas/5
        public LabelsIdiomas Get(int id)
        {
            LabelsIdiomasRepository Db = new LabelsIdiomasRepository();
            return Db.FindById(id);
        }
    }
}
