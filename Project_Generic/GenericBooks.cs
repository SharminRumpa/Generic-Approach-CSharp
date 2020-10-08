using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Generic
{
    public class GenericBook<T> : IGenericDepartmentType<T>
    {
        public string GetGenericDepartmentType(T obj)
        {
            DetailesBooksType db = new DetailesBooksType();

            String Department = string.Empty;

            if (obj is Books)
            {
                Books b = obj as Books;

                switch (b.BookType)
                {
                    case DepartmentTypes.Arts:
                        Department = db.booksDetails.Where(a => a.departmentType == DepartmentTypes.Arts).FirstOrDefault().Department;
                        break;
                    case DepartmentTypes.Science:
                        Department = db.booksDetails.Where(a => a.departmentType == DepartmentTypes.Science).FirstOrDefault().Department;
                        break;
                    case DepartmentTypes.BusinessStudies:
                        Department = db.booksDetails.Where(a => a.departmentType == DepartmentTypes.BusinessStudies).FirstOrDefault().Department;
                        break;
                    default:
                        Department = "Unknown Department";
                        break;

                       
                }

            }
            else
            {
                Department = "Not any other Department";
            }
            return Department;
        }

    }
}
