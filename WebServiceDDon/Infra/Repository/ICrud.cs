using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceDDon.Infra.Repository
{
    public interface ICrud<T> 
    {
        void Add(T Object);
        void Edit(T Objecto);
        void Remove(T Object);
        T FindById(int id);
        IEnumerable<T> List();
    }
}