using Project.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.DesignPatterns.UnitOfWorks.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {

        // listeleme

        List<T> GetAll();
        List<T> GetActive();
        List<T> GetPassive();
        List<T> GetUpdate();

        // ekleme silme güncelleme

        void Add(T item);
        void Update(T item);
        void Deleted(T item);
        void SpecialDelete(T item);

        // linq ifadeler

        List<T> where(Expression<Func<T, bool>> exp);

        bool Any(Expression<Func<T, bool>> exp);
        T GetDefault(Expression<Func<T, bool>> exp);

        object Select(Expression<Func<T, bool>> exp);

        T GetByID(int id);

    }
}
