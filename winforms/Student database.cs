using System;
using System.Windows.Forms;

namespace winforms
{
    public partial class MainWindowForm : Form
    {
        #region Load
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            UniversityPresenter.PopulateList(StudentListBox);
            ListRefreshTimer();
        }
        #endregion

        #region Buttons
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
        #endregion

        #region Form refresh and index changes
        private void timer_Tick(object sender, EventArgs e)
        {
            int temp = StudentListBox.SelectedIndex;
            UniversityPresenter.PopulateList(StudentListBox);
            StudentListBox.SelectedIndex = temp;
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UniversityPresenter.PopulateFields(NameBox, SurnameBox, GroupListPop, NumberBox, BudgetCheckBox, StudentListBox.SelectedIndex);
        }

        private void ListRefreshTimer()
        {
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        #endregion

    }
}
