using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Generic
{
    public interface IGenericDepartmentType<T>
    {
        string GetGenericDepartmentType(T obj);
    }
}
