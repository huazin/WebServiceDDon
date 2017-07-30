using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceDDon.Models;

namespace WebServiceDDon.Infra.Repository
{
    public class UsuarioRepository : ICrud<Usuario>
    {
        Context Db = new Context();
        public void Add(Usuario Object)
        {
            Db.Usuarios.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Usuario Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Usuario FindById(int id)
        {
            return Db.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> List()
        {
            return Db.Usuarios.ToList() ;
        }

        static public bool Acesso(int id, string senha)
        {
            Context Db = new Context();
            var retorno = Db.Usuarios.Where(p => p.Id == id && p.Senha == senha).FirstOrDefault(null);
            if (retorno != null)
                return true;
            return false;
        }

        public void Remove(Usuario Object)
        {
            Db.Usuarios.Remove(Object);
            Db.SaveChanges();
        }
    }
}