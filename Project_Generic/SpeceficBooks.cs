using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Generic
{
    public class SpecificDepartmant<T> : ISpecificDepartment<T>
    {
        public string GetSpecificDepartment<T>(T data) where T : Books
        {
            DetailesBooksType db = new DetailesBooksType();

            string Department = string.Empty;

            switch (data.BookType)
            {
                case DepartmentTypes.Arts:
                    Department = db.booksDetails.Where(s => s.departmentType == DepartmentTypes.Arts).FirstOrDefault().Department;
                    break;
                case DepartmentTypes.Science:
                    Department = db.booksDetails.Where(s => s.departmentType == DepartmentTypes.Science).FirstOrDefault().Department;
                    break;
                case DepartmentTypes.BusinessStudies:
                    Department = db.booksDetails.Where(s => s.departmentType == DepartmentTypes.BusinessStudies).FirstOrDefault().Department;
                    break;
                default:
                    Department = "Unknown Department";
                    break;
            }
            return Department;
        }
        
    }
}
