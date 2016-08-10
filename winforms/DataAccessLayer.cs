using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data;
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

        static public void InsertNewStudent(Student stud)
        {
            using (var db = new UniversityEntitiesConnectionSettings())
            {
                bool exception = false;
                try
                {
                    db.Students.Add(stud);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    exception = true;
                    MessageBox.Show("Cannot insert student, check student number for duplicates or ask administrator. \n Error: {0}", e.Message);
                }
                if (!exception)
                {
                    MessageBox.Show("Student inserted!");
                }
            }
        }

        static public void UpdateStudent(Student stud)
        {
            using (var db = new UniversityEntitiesConnectionSettings())
            {
                bool exception = false;
                try
                {
                    var query = from s in db.Students
                                where s.Number == stud.Number
                                select s;
                    foreach (var s in query)
                    {
                        s.Avg_Grade = stud.Avg_Grade;
                        s.Group = stud.Group;
                        s.Budget = stud.Budget;
                        s.Name = stud.Name;
                        s.Surname = stud.Surname;
                    }
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    exception = true;
                    MessageBox.Show("Student update failed, check input, or contact administrator. \n Error: {0}", e.Message);
                }
                if (!exception)
                {
                    MessageBox.Show("Student updated successfuly");
                }
            }
        }

        static public void DeleteStudent(int number)
        {
            using (var db = new UniversityEntitiesConnectionSettings())
            {
                bool exception = false;
                try
                {
                    var query = from s in db.Students
                    where s.Number == number
                    select s;
                foreach (var s in query)
                {
                    db.Students.Remove(s);
                }
                db.SaveChanges();
                }
                catch (Exception e)
                {
                    exception = true;
                    MessageBox.Show("Error deleting student, make sure u selected student or contact administrator. \n Error: {0}", e.Message);
                }
                if (!exception)
                {
                    MessageBox.Show("Student deleted successfuly");
                }
            }
        }

        static public void InsertNewGroup() { }
        static public void UpdateGroup() { }
        static public void DeleteGroup() { }

    }
}

