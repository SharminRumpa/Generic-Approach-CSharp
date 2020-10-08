using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Generic
{
    public class BooksType
    {
        public BooksType[] booksDetails;

        public DepartmentTypes departmentType { get; set; }

        public string Department { get; set; }

        public BooksType(DepartmentTypes BookType, string department)
        {
            this.departmentType = BookType;
            this.Department = department;
            

        }

        public BooksType()
        {


        }

    }

    public class DetailesBooksType
    {

        public BooksType[] booksDetails;

        public DetailesBooksType()
        {
            BooksType b = new BooksType();

            b.booksDetails = new BooksType[]
            {
               new BooksType(){Department ="English, Bengali, History, Islamic Studes is Arts Department Subject", departmentType = DepartmentTypes.Arts},

               new BooksType(){Department ="Physics, Chemistry, Methmates, Staticstics is Science Department Subject", departmentType = DepartmentTypes.Science},

               new BooksType(){Department ="Marketing, Management, Accounting, Finance is Business Studies Department Subject", departmentType = DepartmentTypes.BusinessStudies}
            };

            booksDetails = b.booksDetails;
        }

    }

}
