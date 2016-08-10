using System;
using System.Windows.Forms;

namespace winforms
{
    public partial class MainWindowForm : Form
    {
        public static bool student_window_open;
        public static bool group_window_open;

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            UniversityPresenter.PopulateList(StudentListBox);
            ListRefreshTimer();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            UniversityPresenter.PopulateList(StudentListBox);
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UniversityPresenter.PopulateFields(NameBox, SurnameBox, NumberBox, AvgGradeBox, BudgetCheckBox, StudentListBox.SelectedIndex);
            UniversityPresenter.PopulateGroupComboBox(GroupListPop, StudentListBox.SelectedIndex);
        }

        private void ListRefreshTimer()
        {
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private void CreateStudentClick(object sender, EventArgs e)
        {
            if (student_window_open == false)
            {
                Form form = new Student_window();
                form.Show();
            }
            UniversityPresenter.PopulateList(StudentListBox);
        }

        private void ManageGroupsClick(object sender, EventArgs e)
        {

        }

        private void DeleteClick(object sender, EventArgs e)
        {
            UniversityPresenter.DeleteStudent(StudentListBox.SelectedIndex);
            UniversityPresenter.PopulateList(StudentListBox);
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            UniversityPresenter.UpdateStudent(NameBox, SurnameBox, GroupListPop, NumberBox, AvgGradeBox, BudgetCheckBox, StudentListBox.SelectedIndex);
            UniversityPresenter.PopulateList(StudentListBox);
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
