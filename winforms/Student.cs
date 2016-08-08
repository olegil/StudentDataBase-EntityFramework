using System.Runtime.InteropServices;

namespace winforms
{
    public class Student
    {
        public string _name { set; get; }
        public string _surname { set; get; }
        public string _group { set; get; }
        public int _number { set; get; }
        public double _avgGrade { set; get; }
        public bool _onBudget { set; get; }

        public Student (string name, string surname, string group, int number, double avgGrade, bool onBudget)
        {
            _name = name;
            _surname = surname;
            _group = group;
            _number = number;
            _avgGrade = avgGrade;
            _onBudget = onBudget;
        }
    }
}