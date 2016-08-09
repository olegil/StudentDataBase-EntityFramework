using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    class DataAccessLayer
    {
        static public List<Student> AllStudentEntriesToList()
        {
            List<Student> StudentList;
            dynamic query;
            using (var db = new UniversityEntitiesConnectionSettings())
            {
                StudentList = new List<Student>();
                query = from s in db.Students
                    select s;
            }
            foreach (var s in query)
            {
                StudentList.Add(s);
            }
            return StudentList;
        }
    }
}
        
