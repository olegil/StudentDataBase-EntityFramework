using System;
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

        public static void PopulateFields(TextBox nameBox, TextBox surnameBox, ComboBox groupComboBox, TextBox numberBox, CheckBox budgetCheckBox, int chosenIndex)
        {
            chosenIndex = Math.Abs(chosenIndex);
            nameBox.Text = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Name;
            surnameBox.Text = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Surname;
            groupComboBox.Items.Clear();
            foreach (var g in DataAccessLayer.AllGroupsEntriestList())
            {
                groupComboBox.Items.Add(g.Name);
            }
            groupComboBox.SelectedItem = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Group;
            numberBox.Text = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Number.ToString();
            budgetCheckBox.Checked = DataAccessLayer.AllStudentEntriesList()[chosenIndex].Budget;

        }

        public static void InsertNewStudent()
        {

        }

        public static void DeleteStudent()
        {

        }
    }
}
