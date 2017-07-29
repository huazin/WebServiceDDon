using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceDDon.Models
{
    public class Monstro
    {
        public int id_Monstro { get; set; }

        public int categoria { get; private set; }
        public string nome { get; private set; }
        public string apelido { get; private set; }
        public string especie { get; private set; }
        public string pontoFraco { get; private set; }
        public string obs { get; private set; }
        public string elementoFraco { get; private set; }
        public string drop { get; private set; }
        public string localizacao { get; private set; }

        public int idiomaid { get; set; }
    }
}