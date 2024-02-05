using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Core
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        int Create(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        ICollection<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
