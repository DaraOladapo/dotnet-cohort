using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace StudentsAndCourses.Library.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
