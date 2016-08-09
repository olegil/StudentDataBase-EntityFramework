using System.Windows.Forms;
namespace winforms
{
    public class UniversityPresenter
    {
        public void PopulateList(ListBox list)
        {
            list.DataSource = DataAccessLayer.AllStudentEntriesToList();
        }
            
        public void PopulateFields()
        {
            
        }

        public void OpenGroupsMenu()
        {
            
        }

        public void OpenStudentsMenu()
        {
            
        }
    }
}
