using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebServiceDDon.Models
{
    public class Job
    {
        
        public int Id_Job { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Id_Tipo { get; set; }


        public virtual TipoClasse TipoClasse { get; set; }
        public virtual IEnumerable<Passivas> Passivas { get; set; }
        public virtual IEnumerable<Habilidades> Habilidades { get; set; }
    }
}