using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

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

        static public void InsertNewStudent(Student s)
        {
            using (var db = new UniversityEntitiesConnectionSettings())
            {
                bool exception = false;
                try
                {
                    db.Students.Add(s);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    exception = true;
                    MessageBox.Show("Cannot insert student, check student number for duplicates or ask administrator.");
                }
                if (!exception)
                {
                    MessageBox.Show("Student inserted!");
                }
            }
        }
        static public void UpdateStudent() { }
        static public void DeleteStudent() { }

        static public void InsertNewGroup() { }
        static public void UpdateGroup() { }
        static public void DeleteGroup() { }

    }
}

