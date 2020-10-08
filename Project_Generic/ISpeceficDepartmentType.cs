using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Generic
{
    public interface ISpecificDepartment<T>
    {
        string GetSpecificDepartment<T>(T data) where T : Books;
    }
}
