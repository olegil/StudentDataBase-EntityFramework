using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace winforms
{
    public partial class MainWindowForm : Form
    {
        DBconnect db = new DBconnect();
        List<Student> StudentList;
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void DeleteClick(object sender, EventArgs e)
        {

        }

        private void SaveAllClick(object sender, EventArgs e)
        {

        }

        private void CreateStudentClick(object sender, EventArgs e)
        {

        }

        private void ManageGroupsClick(object sender, EventArgs e)
        {

        }

        private void QuitDontSaveClick(object sender, EventArgs e)
        {

        }

        private void SaveNQuitClick(object sender, EventArgs e)
        {

        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            db.sqlStudentsToList(out StudentList);
            foreach (var student in StudentList)
            {
                StudentListBox.Items.Add(student._surname + student._name);
            }
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameBox.Text = StudentList[StudentListBox.SelectedIndex]._name;
            SurnameBox.Text = StudentList[StudentListBox.SelectedIndex]._surname;
            NumberBox.Text = StudentList[StudentListBox.SelectedIndex]._number.ToString();
            BudgetCheckBox.Checked = StudentList[StudentListBox.SelectedIndex]._onBudget;
        }
    }
}
