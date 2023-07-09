using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void insert(T t);
        void delete(T t);
        void update(T t);
        T GetById(int id);
        List<T> GetList();

    }
}
