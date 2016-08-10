using System;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;

namespace winforms
{
    public class UniversityPresenter
    {
        private MainWindowForm M;
        public static void PopulateList(ListBox studentListBox)
        {
            studentListBox.Items.Clear();
            foreach (var s in DataAccessLayer.AllStudentEntriesList())
            {
                studentListBox.Items.Add(s.Number + " " + s.Name + " " + s.Surname);
            }
        }

        public static void PopulateFields(TextBox nameBox, TextBox surnameBox, TextBox numberBox, CheckBox budgetCheckBox, int chosenIndex)
        {
            chosenIndex = Math.Abs(chosenIndex);
            nameBox.Text = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Name;
            surnameBox.Text = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Surname;
            numberBox.Text = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Number.ToString();
            budgetCheckBox.Checked = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Budget;
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

        public static void DeleteStudent()
        {

        }
    }
}
