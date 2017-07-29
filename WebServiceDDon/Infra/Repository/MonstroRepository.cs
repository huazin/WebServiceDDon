using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceDDon.Models;

namespace WebServiceDDon.Infra.Repository
{
    public class MonstroRepository : ICrud<Monstro>
    {
        Context Db = new Context();
        public void Add(Monstro Object)
        {
            Db.Monstro.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Monstro Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Monstro FindById(int id)
        {
           return Db.Monstro.Find(id);
        }

        public IEnumerable<Monstro> FindByIdCollection(int id)
        {
            return Db.Monstro.ToList().Where(p => p.id_Monstro == id);
        }

        public IEnumerable<Monstro> List(int idioma)
        {
            return Db.Monstro.ToList().Where(p => p.idiomaid == idioma).OrderBy(p => p.especie);
        }

        public IEnumerable<Monstro> List()
        {
            return List(1);
        }

        public void Remove(Monstro Object)
        {
            Db.Monstro.Remove(Object);
            Db.SaveChanges();
        }

        public IEnumerable<Monstro> GetAllEspecies(int categoria, int idioma)
        {
            return Db.Monstro.SqlQuery("select * from Monstro where categoria = {0} and idiomaid = {1} group by especie", categoria, idioma);
        }

         public IEnumerable<Monstro> GetAllForEspecies(int categoria,string especie, int idioma)
        {
            return Db.Monstro.ToList().Where(p => p.categoria == categoria && p.especie == especie && p.idiomaid == idioma);
        }
    }
}