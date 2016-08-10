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

        private void timer_Tick(object sender, EventArgs e)
        {
            int temp = StudentListBox.SelectedIndex;
            UniversityPresenter.PopulateList(StudentListBox);
            StudentListBox.SelectedIndex = temp;
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UniversityPresenter.PopulateFields(NameBox, SurnameBox, NumberBox, BudgetCheckBox, StudentListBox.SelectedIndex);
            UniversityPresenter.PopulateGroupComboBox(GroupListPop, StudentListBox.SelectedIndex);
        }

        private void ListRefreshTimer()
        {
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void CreateStudentClick(object sender, EventArgs e)
        {
            if (student_window_open == false)
            {
                Form form = new Student_window();
                form.Show();
            }
        }

        private void ManageGroupsClick(object sender, EventArgs e)
        {

        }

        private void DeleteClick(object sender, EventArgs e)
        {

        }

        private void SaveAllClick(object sender, EventArgs e)
        {

        }

        private void QuitDontSaveClick(object sender, EventArgs e)
        {

        }

        private void SaveNQuitClick(object sender, EventArgs e)
        {

        }

    }
}
