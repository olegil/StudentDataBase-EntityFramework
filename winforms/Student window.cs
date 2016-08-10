using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class Student_window : Form
    {

        public Student_window()
        {
            InitializeComponent();
        }

        private void Student_window_Load(object sender, EventArgs e)
        {
            MainWindowForm.student_window_open = true;
            UniversityPresenter.PopulateGroupComboBox(GroupListPop);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            UniversityPresenter.InsertNewStudent(NameBox, SurnameBox, GroupListPop, NumberBox, GradeBox, BudgetCheckBox);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainWindowForm.student_window_open = false;
            Close();
        }

        private void Student_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainWindowForm.student_window_open = false;
        }

    }
}
