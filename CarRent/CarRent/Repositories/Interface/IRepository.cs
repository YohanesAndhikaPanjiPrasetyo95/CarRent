using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Repositories.Interface
{
    public interface IRepository <Entity, Id> where Entity : class
    {
        IEnumerable<Entity> Get(); //Read All Data
        Entity Get(Id id); //Read by Id on Data
        int Create(Entity entity);
        int Update(Entity entity);
        int Delete(Id id);
    }
}
