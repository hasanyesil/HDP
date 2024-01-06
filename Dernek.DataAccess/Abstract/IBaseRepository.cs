using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DataAccess.Abstract
{
    /// <summary>
    /// Her tablo icin bunlar kullanilacagindan base e aldik
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> where T : BaseEntity
    {
        List<T> GetAll();

        DataTable GetAllAsDt();

        T Get(T obj);

        T Insert(T obj);

        T Update(T obj);

        T Delete(T obj);
    }
}
