using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Books Bangla = new Books { BookName = "Noukadubi", AuthorName = "Rabindranath Tagor", ISBN = "122365448", BookType = DepartmentTypes.Arts };
            GenericBook<Books> book = new GenericBook<Books>();
            Console.WriteLine(book.GetGenericDepartmentType(Bangla));

            Books Methmates = new Books { BookName = "Color Farm", AuthorName = "Linus Pauling", ISBN = "O-14-0505867", BookType = DepartmentTypes.Science };
            GenericBook<Books> book1 = new GenericBook<Books>();
            Console.WriteLine(book.GetGenericDepartmentType(Methmates));

            Books Accounting = new Books { BookName = "Managerial Accounting", AuthorName = "F W Taylor", ISBN = "O-671-854216", BookType = DepartmentTypes.BusinessStudies };
            SpecificDepartmant<Books> book2 = new SpecificDepartmant<Books>();
            Console.WriteLine(book2.GetSpecificDepartment(Accounting));

            Console.ReadLine();
        }
    }
}
