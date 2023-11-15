using AdoNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNET.Abstratcs
{
    public interface IService<T>
    {
        void Create(T student);
        void Delete(int id);
        List<T> GetAll();
        void Update(T student);
        void GetById(int id);
    }
}
