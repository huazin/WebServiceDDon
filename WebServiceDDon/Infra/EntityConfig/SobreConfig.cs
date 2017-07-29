using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebServiceDDon.Models;

namespace WebServiceDDon.Infra.EntityConfig
{
    public class SobreConfig: EntityTypeConfiguration<Sobre>
    {
        public SobreConfig()
        {
            HasKey(p => p.IdiomaId);
        }
    }
}