using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Tinsert(T t);
        void Tdelete(T t);
        void Tupdate(T t);
        T TGetById(int id);
        List<T> TGetList();

    }
}
