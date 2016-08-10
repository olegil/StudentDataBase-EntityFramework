using System;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;

namespace winforms
{
    public class UniversityPresenter
    {
        public static void PopulateList(ListBox studentListBox)
        {
            studentListBox.Items.Clear();
            foreach (var s in DataAccessLayer.AllStudentEntriesList())
            {
                studentListBox.Items.Add(s.Number + " " + s.Name + " " + s.Surname);
            }
        }

        public static void PopulateFields(TextBox nameBox, TextBox surnameBox, TextBox numberBox, TextBox avgGradeBox, CheckBox budgetCheckBox, int index)
        {
            int i = index;
            if (i < 0 || i >= DataAccessLayer.AllStudentEntriesList().Count)
                i = DataAccessLayer.AllStudentEntriesList().Count - 1;
            nameBox.Text = DataAccessLayer.AllStudentEntriesList()[i].Name;
            surnameBox.Text = DataAccessLayer.AllStudentEntriesList()[i].Surname;
            numberBox.Text = DataAccessLayer.AllStudentEntriesList()[i].Number.ToString();
            budgetCheckBox.Checked = DataAccessLayer.AllStudentEntriesList()[i].Budget;
            avgGradeBox.Text = DataAccessLayer.AllStudentEntriesList()[i].Avg_Grade.ToString();
        }

        public static void PopulateGroupComboBox (ComboBox groupComboBox, int index = 0)
        {
            index = Math.Abs(index);
            groupComboBox.Items.Clear();
            foreach (var g in DataAccessLayer.AllGroupsEntriestList())
            {
                groupComboBox.Items.Add(g.Name);
            }
            groupComboBox.SelectedItem = DataAccessLayer.AllStudentEntriesList()[index].Group;
        }

        public static void InsertNewStudent(TextBox nameBox, TextBox surnameBox, ComboBox groupComboBox, TextBox numberBox, TextBox avgGradeBox, CheckBox budgetCheckBox)
        {
            try
            {
                Student s = new Student
                {
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    Avg_Grade = Convert.ToDouble(avgGradeBox.Text),
                    Budget = budgetCheckBox.Checked,
                    Group = DataAccessLayer.AllGroupsEntriestList()[groupComboBox.SelectedIndex].Name,
                    Number = Convert.ToInt32(numberBox.Text)

                };
                DataAccessLayer.InsertNewStudent(s);
            }
            catch (Exception e)
            {
                MessageBox.Show("Wrong input, check you input. (Probably Avg. grade with coma instead of point) /n Error: {0}", e.Message);
            }
            
        }

        public static void DeleteStudent(int index)
        {
            DataAccessLayer.DeleteStudent(DataAccessLayer.AllStudentEntriesList()[index].Number);
        }

        public static void UpdateStudent(TextBox nameBox, TextBox surnameBox, ComboBox groupComboBox, TextBox numberBox, TextBox avgGradeBox, CheckBox budgetCheckBox, int index)
        {
            try
            {
                Student s = new Student
                {
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    Avg_Grade = Convert.ToDouble(avgGradeBox.Text),
                    Budget = budgetCheckBox.Checked,
                    Group = DataAccessLayer.AllGroupsEntriestList()[groupComboBox.SelectedIndex].Name,
                    Number = Convert.ToInt32(numberBox.Text)

                };
                DataAccessLayer.UpdateStudent(s);
            }
            catch (Exception e)
            {
                MessageBox.Show("Wrong input, check you input. (Probably Avg. grade with coma instead of point) /n Error: {0}", e.Message);
            }
        }
    }
}
