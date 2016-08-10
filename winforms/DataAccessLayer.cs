using System.Collections.Generic;
using System.Linq;

namespace winforms
{
    class DataAccessLayer
    {
        static public List<Student> AllStudentEntriesList()
        {
            List<Student> studentList;
            using (var db = new UniversityEntitiesConnectionSettings())
            {
                studentList = new List<Student>();
                var query = from s in db.Students
                            select s;

                foreach (var s in query)
                {
                    studentList.Add(s);
                }
            }
            return studentList;
        }
        static public List<Group> AllGroupsEntriestList()
        {
            List<Group> groupList;
            using (var db = new UniversityEntitiesConnectionSettings())
            {
                groupList = new List<Group>();
                var query = from g in db.Groups
                            select g;

                foreach (var g in query)
                {
                    groupList.Add(g);
                }
            }
            return groupList;
        }

        static public void InsertNewStudent() { }
        static public void UpdateStudent() { }
        static public void DeleteStudent() { }

        static public void InsertNewGroup() { }
        static public void UpdateGroup() { }
        static public void DeleteGroup() { }

    }
}

