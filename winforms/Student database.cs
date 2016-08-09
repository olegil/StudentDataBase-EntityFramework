using System;
using System.Windows.Forms;
namespace winforms
{
    public partial class MainWindowForm : Form
    {
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
            UniversityPresenter u = new UniversityPresenter();
            u.PopulateList();
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
