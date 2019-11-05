using Project.Bll.DesignPatterns.SinglettonPattern;
using Project.Bll.DesignPatterns.UnitOfWorks.IntRep;
using Project.Dal.Context;
using Project.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.DesignPatterns.UnitOfWorks.BaseRep
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext db;
        public BaseRepository()
        {
            db = DBTool.DBInstance;
        }

        private void Save()
        {
            db.SaveChanges();
        }

        public void Add(T item)
        {
            db.Set<T>().Add(item);
            Save();
        }

        public void Update(T item)
        {
            item.ModifiedDate = DateTime.Now;
            item.Status = Model.Enums.DataStatus.Updated;

            T updata = GetByID(item.ID);
            db.Entry(updata).CurrentValues.SetValues(item.ID);
            Save();
        }


        public void Deleted(T item)
        {
            item.DeletedDate = DateTime.Now;
            item.Status = Model.Enums.DataStatus.Deleted;
            Save();
        }

        public void SpecialDelete(T item)
        {
            db.Set<T>().Remove(GetByID(item.ID));
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

       

        public List<T> GetActive()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public T GetDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<T> GetPassive()
        {
            throw new NotImplementedException();
        }

        public List<T> GetUpdate()
        {
            throw new NotImplementedException();
        }

        public object Select(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

     

        public List<T> where(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }
    }
}
